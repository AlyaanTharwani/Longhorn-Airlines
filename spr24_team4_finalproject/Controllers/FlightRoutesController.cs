using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using spr24_team4_finalproject.DAL;
using spr24_team4_finalproject.Models;

namespace spr24_team4_finalproject.Controllers
{
    public class FlightRoutesController : Controller
    {
        private readonly AppDbContext _context;

        public FlightRoutesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: FlightRoutes
        public async Task<IActionResult> Index()
        {
            return View(await _context.FlightRoute.ToListAsync());
        }

        // GET: FlightRoutes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
            }

            //find the flightroute in the database
            FlightRoutes flightRoutes = await _context.FlightRoute
                .Include(f => f.Flight)
                .FirstOrDefaultAsync(m => m.FlightRoutesID == id);

            //if the route is not in the database, show the user an error
            if (flightRoutes == null)
            {
                return View("Error", new String[] { "This routes was not found!" });
            }

            //show the user the details for this route
            return View(flightRoutes);
        }

        // GET: FlightRoutes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FlightRoutes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create (FlightRoutes flightRoutes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flightRoutes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flightRoutes);
        }

        // GET: FlightRoutes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //user did not specify a route to edit            
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a route to edit!" });
            }

            //find the route in the database
            FlightRoutes flightRoutes = await _context.FlightRoute.FindAsync(id);

            //see if the route exists in the database
            if (flightRoutes == null)
            {
                return View("Error", new String[] { "This route does not exist in the database!" });
            }

            //send the user to the edit route page
            return View(flightRoutes);
        }

        // POST: FlightRoutes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, FlightRoutes flightRoutes)
        {
            //this is a security measure to make sure they are editing the correct department
            if (id != flightRoutes.FlightRoutesID)
            {
                return View("Error", new String[] { "There was a problem editing this route. Try again!" });
            }

            //if the user messed up, send them back to the view to try again
            if (ModelState.IsValid == false)
            {
                return View(flightRoutes);
            }

            //if code gets this far, make the updates
            try
            {
                _context.Update(flightRoutes);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this route.", ex.Message });
            }

            //send the user back to the view with all the departments
            return RedirectToAction(nameof(Index));
        }

        // GET: FlightRoutes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flightRoutes = await _context.FlightRoute
                .FirstOrDefaultAsync(m => m.FlightRoutesID == id);
            if (flightRoutes == null)
            {
                return NotFound();
            }

            return View(flightRoutes);
        }

        // POST: FlightRoutes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flightRoutes = await _context.FlightRoute.FindAsync(id);
            if (flightRoutes != null)
            {
                _context.FlightRoute.Remove(flightRoutes);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlightRoutesExists(int id)
        {
            return _context.FlightRoute.Any(e => e.FlightRoutesID == id);
        }

        private SelectList GetAllFlights()
        {
            //create a list for all the products
            List<Flights> allFlights = _context.Flight.ToList();

            //the user MUST select a product, so you don't need a dummy option for no product

            //use the constructor on select list to create a new select list with the options
            SelectList slAllFlights = new SelectList(allFlights, nameof(Flights.FlightsID), nameof(Flights.FlightIdentifier));

            return slAllFlights;
        }
    }
}
