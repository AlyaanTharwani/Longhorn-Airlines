using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using spr24_team4_finalproject.DAL;
using spr24_team4_finalproject.Models;

namespace spr24_team4_finalproject.Controllers
{
    [Authorize(Roles = "Manager")]
    public class ReportController : Controller
    {
        private readonly AppDbContext _context;

        public ReportController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Index action to display initial form with Routes dropdown
        // GET: Index action to display initial form with Routes dropdown
        public IActionResult Index()
        {
            ViewBag.AllFlightRoutes = GetAllFlightRoutes();
            return View();
        }


        [HttpPost]
public IActionResult GenerateReport(ReportViewModel model)
{

    var query = _context.Ticket.Include(t => t.Flight).AsQueryable();

    if (model.StartDate != null && model.StartDate != DateTime.MinValue)
    {
        query = query.Where(t => t.Flight.DepartureDateTime >= model.StartDate.Value);
    }

    if (model.EndDate != null && model.EndDate != DateTime.MinValue)
    {
        query = query.Where(t => t.Flight.DepartureDateTime <= model.EndDate.Value);
    }

    if (!string.IsNullOrEmpty(model.City))
    {
        query = query.Where(t => t.Flight.FlightRoute.City1 == model.City || t.Flight.FlightRoute.City2 == model.City);
    }

    if (model.RouteID.HasValue)
    {
        query = query.Where(t => t.Flight.FlightRoute.FlightRoutesID == model.RouteID.Value);
    }

    if (!string.IsNullOrEmpty(model.Class))
    {
        if (model.Class == "First")
        {
            // Filter first-class seats
            query = query.Where(t => t.SeatNumber >= Seats.First1A && t.SeatNumber <= Seats.First2B);
        }
        else
        {
            // Filter economy-class seats
            query = query.Where(t => t.SeatNumber >= Seats.Econ3A && t.SeatNumber <= Seats.Econ5D);
        }
    }

            //// Filter by City if provided
            //if (!string.IsNullOrEmpty(model.City))
            //{
            //    query = query.Where(t => t.Flight.FlightRoute.City1 == model.City || t.Flight.FlightRoute.City2 == model.City);
            //}

            //// Filter by RouteID if selected
            //if (model.RouteID.HasValue)
            //{
            //    query = query.Where(t => t.Flight.FlightRoute.FlightRoutesID == model.RouteID.Value);
            //}

            //// Filter by Class if selected, ensuring to parse correctly
            //if (!string.IsNullOrEmpty(model.Class) && Enum.TryParse(model.Class, out TicketClass ticketClass))
            //{
            //    if (ticketClass == TicketClass.First)
            //    {
            //        query = query.Where(t => t.SeatNumber.ToString().StartsWith("First"));
            //    }
            //    else
            //    {
            //        query = query.Where(t => !t.SeatNumber.ToString().StartsWith("First"));
            //    }
            //}

            // Calculate total revenue and total seats sold
    var totalRevenue = query.Sum(t => t.TicketPrice);
    var totalSeatsSold = query.Count();

    model.TotalRevenue = totalRevenue;
    model.TotalSeatsSold = totalSeatsSold;

    // Populate Routes again to ensure it's available in the view
    model.Routes = new SelectList(_context.FlightRoute.ToList(), "FlightRoutesID", "Description");

    return View("GenerateReport", model);
}

        private SelectList GetAllFlightRoutes()
        {
            // Get the list of FlightRoutes from the database
            List<FlightRoutes> routeList = _context.FlightRoute.ToList();

            // Create an empty list to hold SelectListItem objects
            List<SelectListItem> routeSelectListItems = new List<SelectListItem>();

            // Add the default option "-- Select Route --" with an empty value
            routeSelectListItems.Add(new SelectListItem { Value = "", Text = "-- Select Route --" });

            // Now, map the FlightRoutes objects to SelectListItem objects
            routeSelectListItems.AddRange(routeList.Select(route => new SelectListItem
            {
                Value = route.FlightRoutesID.ToString(),
                Text = $"{route.City1} to {route.City2}"
            }));

            // Create the SelectList using the combined list of items
            SelectList routeSelectList = new SelectList(routeSelectListItems, "Value", "Text");

            return routeSelectList;
        }
    }
}
