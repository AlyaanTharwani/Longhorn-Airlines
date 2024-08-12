using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Humanizer.Localisation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using spr24_team4_finalproject.DAL;
using spr24_team4_finalproject.Models;
using spr24_team4_finalproject.Utilities;

namespace spr24_team4_finalproject.Controllers
{
    public class FlightsController : Controller
    {
        private readonly AppDbContext _context;

        public FlightsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Flights
        public async Task<IActionResult> Index()
        {
            var flights = await _context.Flight
                 .Include(f => f.FlightRoute)
                 .OrderBy(f => f.DepartureDateTime)
                 .ToListAsync();
            { }
            return View(flights);
        }

        // GET: Flights/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a flight to view!" });
            }

            Flights flights = await _context.Flight
                .Include(f => f.FlightRoute)
                .FirstOrDefaultAsync(m => m.FlightsID == id);

            if (flights == null)
            {
                View("Error", new String[] { "Flight was not found!" });
            }

            return View(flights);
        }

        // GET: Flights/Create
        public IActionResult Create()
        {
            ViewBag.AllFlightRoutes = GetAllFlightRoutes();
            return View();
        }

        // POST: Flights/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FlightsID,FlightNumber,DepartureDateTime,EconomyPrice")] Flights flights, int SelectedFlightRoutes, List<string> SelectedDaysOfWeek)
        {
            var selectedFlightRoute = await _context.FlightRoute.FindAsync(SelectedFlightRoutes);

            // Start date: April 15, 2024
            DateTime startDate = new DateTime(2024, 4, 15);
            // End date: May 30, 2024
            DateTime endDate = new DateTime(2024, 5, 30);

            // Loop through each date within the specified date range
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                // Check if the current date falls within the selected days of the week
                if (SelectedDaysOfWeek.Contains(date.DayOfWeek.ToString()))
                {
                    // Calculate departure datetime for the current date
                    DateTime departureDateTime = new DateTime(date.Year, date.Month, date.Day, flights.DepartureDateTime.Hour, flights.DepartureDateTime.Minute, 0);

                    // Calculate arrival datetime based on flight route duration
                    DateTime arrivalDateTime = departureDateTime + selectedFlightRoute.Duration;

                    // Create a new flight object
                    var flight = new Flights
                    {
                        FlightNumber = flights.FlightNumber,
                        DepartureDateTime = departureDateTime,
                        ArrivalDateTime = arrivalDateTime,
                        FlightIdentifier = Utilities.GenerateNewFlightIdentifier.GetNextFlightIdentifier(_context),
                        EconomyPrice = flights.EconomyPrice,
                        status = Status.Active,
                        AvailableSeats = 16,
                        FlightRoute = selectedFlightRoute
                    };

                    _context.Add(flight);
                }
            }

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }



        // GET: Flights/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flights = _context.Flight.Include(f => f.FlightRoute).FirstOrDefault(f => f.FlightsID == id);

            if (flights == null)
            {
                return NotFound();
            }
            ViewData["FlightRouteID"] = new SelectList(_context.FlightRoute, "FlightRoutesID", "RouteDescription", flights.FlightRoute);
            return View(flights);
        }

        // POST: Flights/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FlightsID,FlightNumber,DepartureDateTime,status,EconomyPrice,AvailableSeats,FlightRoute")] Flights flights)
        {
            if (id != flights.FlightsID)
            {
                return NotFound();
            }

            if (!IsDepartureWithin15MinuteInterval(flights.DepartureDateTime))
            {
                ModelState.AddModelError("", "Departure time must be at 15-minute intervals (e.g., 10:00, 10:15, 10:30, etc.).");
                ViewBag.AllFlightRoutes = GetAllFlightRoutes();
                return View(flights);
            }

            var originalFlight = await _context.Flight.FindAsync(id);

            TimeSpan originalDuration = originalFlight.ArrivalDateTime - originalFlight.DepartureDateTime;

            DateTime arrivalDateTime = flights.DepartureDateTime + originalDuration;

            flights.ArrivalDateTime = arrivalDateTime;

            _context.Entry(originalFlight).State = EntityState.Detached;

            _context.Update(flights);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: Flights/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flights = await _context.Flight
                .FirstOrDefaultAsync(m => m.FlightsID == id);
            if (flights == null)
            {
                return NotFound();
            }

            return View(flights);
        }

        // POST: Flights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flights = await _context.Flight.FindAsync(id);
            if (flights != null)
            {
                _context.Flight.Remove(flights);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlightsExists(int id)
        {
            return _context.Flight.Any(e => e.FlightsID == id);
        }

        // GET: Flights/Search
        public IActionResult Search()
        {
            return View();
        }

        // POST: Flights/SearchResults
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SearchResults(FlightSearchViewModel searchModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Search", searchModel);
            }

            var flightDetails = _context.Flight
                .Include(f => f.FlightRoute)
                .Where(f => f.FlightRoute.City1 == searchModel.City1 &&
                            f.FlightRoute.City2 == searchModel.City2 &&
                            f.DepartureDateTime.Date == searchModel.DepartureDate.Date &&
                            f.status == Status.Active) // Filter out inactive flights
                .Select(f => new FlightDetailViewModel
                {
                    FlightNumber = f.FlightNumber.ToString(),
                    Origin = f.FlightRoute.City1,
                    Destination = f.FlightRoute.City2,
                    DepartureTime = f.DepartureDateTime,
                    AvailableSeats = 16 - _context.Ticket.Count(t => t.FlightsID == f.FlightsID)
                })
                .ToList();

            return View(flightDetails);
        }

        private SelectList GetAllFlightRoutes()
        {
            List<FlightRoutes> routeList = _context.FlightRoute.ToList();

            // Create a new anonymous type to hold both ID and formatted city string
            var routeInfoList = routeList.Select(route => new { RouteId = route.FlightRoutesID, CityCombined = $"{route.City1} to {route.City2}" }).ToList();

            // Use the anonymous type to create the SelectList
            SelectList routeSelectList = new SelectList(routeInfoList, "RouteId", "CityCombined");

            return routeSelectList;
        }

        private SelectList GetStatusList()
        {
            List<Flights> flightList = _context.Flight.ToList();

            // Use the anonymous type to create the SelectList
            SelectList statusSelectList = new SelectList(flightList.OrderBy(b => b.FlightsID), "FlightsID", "status");

            return statusSelectList;
        }

        private bool IsDepartureWithin15MinuteInterval(DateTime departure)
        {
            if (departure.Minute % 15 != 0)
            {
                return false;
            }
            return true;
        }

    }
}