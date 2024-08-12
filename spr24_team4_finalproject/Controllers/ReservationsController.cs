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
using spr24_team4_finalproject.Utilities;

namespace spr24_team4_finalproject.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public ReservationsController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Reservations
        public async Task<IActionResult> Index()
        {
            List<Reservations> reservations;

            if (User.IsInRole("Manager"))
            {
                reservations = _context.Reservation.Include(r => r.Ticket).ToList();
            }
            else //user is a customer
            {
                reservations = _context.Reservation.Include(r => r.Ticket).Where(r => r.ReservationMaker.UserName == User.Identity.Name).ToList();
            }

            return View(reservations);
        }

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //the user did not specify a reservation to view
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a reservation to view!" });
            }

            //find the reservation in the database
            Reservations reservations = await _context.Reservation
                                .Include(r => r.Ticket)
                                .ThenInclude(r => r.Flight)
                                .ThenInclude(r => r.FlightRoute)
                                .Include(r => r.Ticket)
                                .ThenInclude(r => r.Ticketholder)
                                .FirstOrDefaultAsync(m => m.ReservationsID == id);

            //reservation was not found in the database
            if (reservations == null)
            {
                return View("Error", new String[] { "This reservation was not found!" });
            }

            //make sure this reservation belongs to this user
            if (User.IsInRole("Customer") && reservations.ReservationMaker.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your reservation!  Don't be such a snoop!" });
            }

            return View(reservations);
        }


        // GET: Reservations/Create
        public IActionResult Create()
        {
            var model = new CreateReservationViewModel
            {
                AvailableFlights = new SelectList(Enumerable.Empty<SelectListItem>())
            };
            return View(model);
        }

        // POST: Reservations/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateReservationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.AvailableFlights = GetAvailableFlights(model.DepartureCity, model.ArrivalCity, model.Date);
                return View(model);
            }

            var flight = await _context.Flight.FirstOrDefaultAsync(f => f.FlightsID == model.FlightsID);
            if (flight == null || !IsSeatAvailable(flight.FlightsID, model.NumberOfPassengers))
            {
                ModelState.AddModelError("", "Flight not found or no available seats.");
                model.AvailableFlights = GetAvailableFlights(model.DepartureCity, model.ArrivalCity, model.Date);
                return View(model);
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var reservation = new Reservations
            {
                ReservationMaker = user,
                ResStatus = ResStatus.Active,
                PaymentType = Payment.Dollars,
                ReservationNumber = Utilities.GenerateNextReservationNumber.GetNextReservationNumber(_context)
            };

            _context.Add(reservation);
            await _context.SaveChangesAsync();

            // Create a ticket for each passenger as a placeholder example
            for (int i = 0; i < model.NumberOfPassengers; i++)
            {
                var ticket = new Tickets
                {
                    Flight = flight,
                    TicketStatus = TicketStatus.Active,
                    Ticketholder = user, // This assumes all tickets are for the reservation maker
                    Reservation = reservation,
                    SeatNumber = Seats.Econ3A // Placeholder, should be dynamically set based on actual selection
                };
                _context.Ticket.Add(ticket);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Details", new { id = reservation.ReservationsID });
        }

        // GET: Reservations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //user did not specify a reservation to edit
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a reservation to edit" });
            }

            //find the reservation in the database, and be sure to include flight
            Reservations reservations = _context.Reservation
                          .Include(r => r.Ticket)
                          .ThenInclude(r => r.Flight)
                          .Include(r => r.ReservationMaker)
                          .FirstOrDefault(m => m.ReservationsID == id);

            //reservations was not found in the database
            if (reservations == null)
            {
                return View("Error", new String[] { "This reservation was not found in the database!" });
            }

            //reservation does not belong to this reservation maker
            if (User.IsInRole("Admin") == false && reservations.ReservationMaker.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "You are not authorized to edit this reservation!" });
            }

            //send the user to the order edit view
            return View(reservations);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReservationsID,ReservationNumber,ResStatus,PaymentType,Subtotal,MilesDeduction")] Reservations reservations)
        {
            //this is a security measure to make sure the user is editing the correct order
            if (id != reservations.ReservationsID)
            {
                return View("Error", new String[] { "There was a problem editing this reservation. Try again!" });
            }

            //if there is something wrong with this order, try again
            if (ModelState.IsValid != false);
            {

                //if code gets this far, update the record
                try
                {
                    //find the record in the database
                    Reservations dbReservations = _context.Reservation.Find(reservations.ReservationsID);

                    //update the scalar properties!!
                    //dbOrder.OrderNotes = order.OrderNotes;

                    _context.Update(dbReservations);

                    await _context.SaveChangesAsync();
                }

                catch (Exception ex)
                {
                    return View("Error", new String[] { "There was an error updating this reservation!", ex.Message });
                }

                //send the user to the Orders Index page.
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: Reservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservations = await _context.Reservation
                .FirstOrDefaultAsync(m => m.ReservationsID == id);
            if (reservations == null)
            {
                return NotFound();
            }

            return View(reservations);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservations = await _context.Reservation.FindAsync(id);
            if (reservations != null)
            {
                _context.Reservation.Remove(reservations);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationsExists(int id)
        {
            return _context.Reservation.Any(e => e.ReservationsID == id);
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
        public async Task<IActionResult> SelectSeats(int? FlightsID, int numPassengers)
        {
            if (!FlightsID.HasValue)
            {
                return View("Error", new ErrorViewModel { ErrorMessage = "Flight ID is required." });
            }

            try
            {
                var flight = await _context.Flight
                                           .Include(f => f.Ticket)
                                           .FirstOrDefaultAsync(f => f.FlightsID == FlightsID.Value);

                if (flight == null)
                {
                    return View("Error", new ErrorViewModel { ErrorMessage = "Flight not found." });
                }

                int bookedSeats = flight.Ticket.Count(t => t.TicketStatus != TicketStatus.Cancelled);
                if ((flight.AvailableSeats - bookedSeats) < numPassengers)
                {
                    return View("Error", new ErrorViewModel { ErrorMessage = "Not enough available seats." });
                }

                var model = new SeatSelectionViewModel
                {
                    Flight = flight,
                    NumPassengers = numPassengers,
                    AvailableSeats = GetAvailableSeats(flight),
                    SelectedSeats = new List<string>(new string[numPassengers]),
                };

                return View(model);
            }
            catch (Exception ex)
            {
                // Log the exception details here to help with debugging
                return View("Error", new ErrorViewModel { ErrorMessage = ex.Message });
            }
        }

        private bool IsSeatAvailable(int flightId, int numPassengers)
        {
            var flight = _context.Flight.Include(f => f.Ticket).FirstOrDefault(f => f.FlightsID == flightId);
            if (flight == null) return false;

            var bookedSeats = flight.Ticket.Where(t => t.TicketStatus != TicketStatus.Cancelled).Count();
            var availableSeats = flight.AvailableSeats - bookedSeats;

            return (flight != null && flight.AvailableSeats - flight.Ticket.Count(t => t.TicketStatus != TicketStatus.Cancelled) >= numPassengers);
        }

        private SelectList GetAvailableFlights(string departureCity, string arrivalCity, DateTime? date)
        {
            if (string.IsNullOrEmpty(departureCity) || string.IsNullOrEmpty(arrivalCity) || !date.HasValue)
                return new SelectList(Enumerable.Empty<SelectListItem>());

            var flights = _context.Flight
                .Where(f => f.FlightRoute.City1 == departureCity && f.FlightRoute.City2 == arrivalCity && f.DepartureDateTime.Date == date.Value.Date)
                .Select(f => new SelectListItem { Value = f.FlightsID.ToString(), Text = $"{f.FlightNumber} - {f.DepartureDateTime}" })
                .ToList();

            return new SelectList(flights, "Value", "Text");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SearchFlights(CreateReservationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", model);
            }

            model.AvailableFlights = GetAvailableFlights(model.DepartureCity, model.ArrivalCity, model.Date);
            return View("Create", model);
        }

        private List<SelectListItem> GetAvailableSeats(Flights flight)
        {
            var bookedSeats = _context.Ticket
                                      .Where(t => t.Flight.FlightsID == flight.FlightsID && t.TicketStatus != TicketStatus.Cancelled)
                                      .Select(t => t.SeatNumber)
                                      .ToList();

            var availableSeats = new List<SelectListItem>();
            foreach (Seats seat in Enum.GetValues(typeof(Seats)))
            {
                if (!bookedSeats.Contains(seat))
                {
                    availableSeats.Add(new SelectListItem { Text = seat.ToString(), Value = seat.ToString() });
                }
            }

            return availableSeats;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmSeats(SeatSelectionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var flight = await _context.Flight.Include(f => f.Ticket).FirstOrDefaultAsync(f => f.FlightsID == model.Flight.FlightsID);
            if (flight == null)
            {
                return View("Error", new ErrorViewModel { ErrorMessage = "Flight not found." });
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var reservation = new Reservations
            {
                ReservationMaker = user,
                ResStatus = ResStatus.Active,
                PaymentType = Payment.Dollars,
                ReservationNumber = Utilities.GenerateNextReservationNumber.GetNextReservationNumber(_context),
                Ticket = new List<Tickets>() // Initialize the Ticket list
            };

            _context.Add(reservation);

            for (int i = 0; i < model.NumPassengers; i++)
            {
                var ticket = new Tickets
                {
                    SeatNumber = (Seats)Enum.Parse(typeof(Seats), model.SelectedSeats[i]),
                    TicketStatus = TicketStatus.Active,
                    Flight = flight,
                    Reservation = reservation,
                    Ticketholder = user, // Assuming all tickets are for the reservation maker
                    TicketPrice = flight.EconomyPrice, // Assuming price from flight as default
                    DiscountType = DiscountType.General, // Default discount type, should be dynamic based on user input or criteria
                    MilesEarned = 0, // Default value, calculate based on flight distance or other factors
                    ModificationFee = 0 // Default to zero, update if modifications are made
                };

                // Apply discount if applicable
                ticket.TicketPrice = ticket.CalculateDiscountedPrice();

                reservation.Ticket.Add(ticket);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Reservations", new { id = reservation.ReservationsID });
        }

        // POST action to set the number of passengers and reload the seat selection form
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SetPassengers(SeatSelectionViewModel model, int flightId, int numPassengers)
        {
            var flight = _context.Flight.Include(f => f.Ticket).FirstOrDefault(f => f.FlightsID == flightId);

            if (flight == null)
            {
                return View("Error", new ErrorViewModel { ErrorMessage = "Flight not found." });
            }

            int bookedSeats = flight.Ticket.Count(t => t.TicketStatus != TicketStatus.Cancelled);
            int availableSeats = flight.AvailableSeats - bookedSeats;

            if (availableSeats < numPassengers)
            {
                return View("Error", new ErrorViewModel { ErrorMessage = "Not enough available seats." });
            }

            // Initialize lists with enough entries
            model.SelectedSeats = Enumerable.Repeat(string.Empty, numPassengers).ToList();
            model.PassengerNames = Enumerable.Repeat(string.Empty, numPassengers).ToList();
            model.PassengerEmails = Enumerable.Repeat(string.Empty, numPassengers).ToList();
            model.AdvantageNumbers = Enumerable.Repeat(string.Empty, numPassengers).ToList();

            model.Flight = flight;
            model.NumPassengers = numPassengers;
            model.AvailableSeats = GetAvailableSeats(flight);

            return View("SelectSeats", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GenerateTickets(SeatSelectionViewModel model)
        {

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var reservation = new Reservations
            {
                ReservationMaker = user,
                ResStatus = ResStatus.Active,
                PaymentType = Payment.Dollars,
                ReservationNumber = Utilities.GenerateNextReservationNumber.GetNextReservationNumber(_context),
                Ticket = new List<Tickets>()
            };

            _context.Add(reservation);

            for (int i = 0; i < model.NumPassengers; i++)
            {
                var flight = await _context.Flight.Include(f => f.Ticket).FirstOrDefaultAsync(f => f.FlightsID == model.Flight.FlightsID);
                if (flight == null)
                {
                    continue; // Log error or handle missing flight case
                }

                var ticket = new Tickets
                {
                    Flight = flight,
                    FlightsID = flight.FlightsID,
                    SeatNumber = (Seats)Enum.Parse(typeof(Seats), model.SelectedSeats[i]),
                    Ticketholder = user,
                    Reservation = reservation,
                    TicketStatus = TicketStatus.Active,
                    TicketPrice = flight.EconomyPrice, // Initial price from flight
                    DiscountType = DiscountType.General, // Set default or determine based on logic
                    MilesEarned = 0, // Calculate based on flight or loyalty program
                    ModificationFee = 0 // Default or calculated
                };

                // Apply discounts and calculate final ticket price
                ticket.TicketPrice = ticket.CalculateDiscountedPrice();

                reservation.Ticket.Add(ticket);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Reservations", new { id = reservation.ReservationsID });
        }


    }
}
