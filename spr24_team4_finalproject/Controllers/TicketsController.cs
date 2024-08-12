using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using spr24_team4_finalproject.DAL;
using spr24_team4_finalproject.Models;

namespace spr24_team4_finalproject.Controllers
{
    public class TicketsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public TicketsController(AppDbContext context, UserManager<AppUser> userManger)
        {
            _context = context;
            _userManager = userManger;
        }

        // GET: Tickets
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Ticket.Include(t => t.Flight);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Tickets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tickets = await _context.Ticket

                .Include(t => t.Flight)

                .FirstOrDefaultAsync(m => m.TicketsID == id);

            if (tickets == null)
            {
                return NotFound();
            }

            return View(tickets);
        }

        // GET: Tickets/Create
        public IActionResult Create()
        {
            ViewData["FlightsID"] = new SelectList(_context.Flight, "FlightsID", "FlightsID");
            ViewBag.AllReservations = GetReservationList();
            ViewBag.AllFlights = GetFlightsList();
            ViewBag.AllUsers = GetTicketholderList();
            return View();
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TicketsID,SeatNumber")] Tickets tickets, int SelectedReservations, string SelectedCustomer, int SelectedFlights)
        {
            var selectedReservation = await _context.Reservation.FindAsync(SelectedReservations);
            var selectedUser = await _context.Users.FindAsync(SelectedCustomer);
            var selectedFlight = await _context.Flight
                .Include(f => f.FlightRoute)
                .FirstOrDefaultAsync(f => f.FlightsID == SelectedFlights);

            tickets.Reservation = selectedReservation;
            tickets.Ticketholder = selectedUser;
            tickets.Flight = selectedFlight;
            tickets.TicketStatus = TicketStatus.Active;
            tickets.TicketPrice = selectedFlight.EconomyPrice;
            tickets.MilesEarned = selectedFlight.FlightRoute.Distance;
            tickets.FlightsID = selectedFlight.FlightsID;
            tickets.ModificationFee = 0;

            if ((DateTime.Today.Year - selectedUser.DateOfBirth.Value.Year) >= 65)
            {
                tickets.DiscountType = DiscountType.SeniorCitizen;
            }
            if ((DateTime.Today.Year - selectedUser.DateOfBirth.Value.Year) <= 12)
            {
                tickets.DiscountType = DiscountType.Child;
            }
            else
            {
                tickets.DiscountType = DiscountType.General;
            }

            ViewData["FlightsID"] = new SelectList(_context.Flight, "FlightsID", "FlightsID", tickets.FlightsID);
            _context.Add(tickets);
            await _context.SaveChangesAsync();
            ViewBag.AllReservations = GetReservationList();
            ViewBag.AllUsers = GetTicketholderList();
            ViewBag.AllFlights = GetFlightsList();
            return RedirectToAction(nameof(Index));
        }

        // GET: Tickets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tickets = await _context.Ticket.FindAsync(id);
            if (tickets == null)
            {
                return NotFound();
            }
            ViewData["FlightsID"] = new SelectList(_context.Flight, "FlightsID", "FlightsID", tickets.FlightsID);
            return View(tickets);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TicketsID,SeatNumber,TicketPrice,TicketStatus,DiscountType,MilesEarned,ModificationFee,FlightsID")] Tickets tickets)
        {
            if (id != tickets.TicketsID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tickets);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketsExists(tickets.TicketsID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["FlightsID"] = new SelectList(_context.Flight, "FlightsID", "FlightsID", tickets.FlightsID);
            return View(tickets);
        }

        // GET: Tickets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tickets = await _context.Ticket
                .Include(t => t.Flight)
                .FirstOrDefaultAsync(m => m.TicketsID == id);
            if (tickets == null)
            {
                return NotFound();
            }

            return View(tickets);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tickets = await _context.Ticket.FindAsync(id);
            if (tickets != null)
            {
                _context.Ticket.Remove(tickets);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketsExists(int id)
        {
            return _context.Ticket.Any(e => e.TicketsID == id);
        }

        private SelectList GetReservationList()
        {
            List<Reservations> reservationsList = _context.Reservation.ToList();

            // Use the anonymous type to create the SelectList
            SelectList reservationSelectList = new SelectList(reservationsList.OrderBy(b => b.ReservationsID), "ReservationsID", "ReservationNumber");

            return reservationSelectList;
        }

        private SelectList GetTicketholderList()
        {
            List<AppUser> usersList = _context.Users.ToList();

            // Use the anonymous type to create the SelectList
            SelectList userSelectList = new SelectList(usersList.OrderBy(b => b.Id), "Id", "UserName");

            return userSelectList;
        }

        private SelectList GetFlightsList()
        {
            List<Flights> flightsList = _context.Flight.ToList();

            // Use the anonymous type to create the SelectList
            SelectList flightsSelectList = new SelectList(flightsList.OrderBy(b => b.FlightsID), "FlightsID", "FlightIdentifier");

            return flightsSelectList;
        }

        public async Task<SelectList> GetAllCustomerUserNamesSelectList()
        {
            //create a list to hold the customers
            List<AppUser> allCustomers = new List<AppUser>();

            //See if the user is a customer
            foreach (AppUser dbUser in _context.Users)
            {
                //if the user is a customer, add them to the list of customers
                if (await _userManager.IsInRoleAsync(dbUser, "Customer") == true)//user is a customer
                {
                    allCustomers.Add(dbUser);
                }
            }

            //create a new select list with the customer emails
            SelectList sl = new SelectList(allCustomers.OrderBy(c => c.Email), nameof(AppUser.UserName), nameof(AppUser.Email));

            //return the select list
            return sl;

        }
    }
}
