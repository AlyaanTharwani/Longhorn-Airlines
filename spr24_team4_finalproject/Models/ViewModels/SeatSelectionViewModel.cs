using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using spr24_team4_finalproject.Migrations;
using Microsoft.SqlServer.Server;

//Change this namespace to match your project
namespace spr24_team4_finalproject.Models
{
    public enum SearchSeats
    {
        [Display(Name = "1A")] First1A, [Display(Name = "1B")] First1B, [Display(Name = "2A")] First2A, [Display(Name = "2B")] First2B,
        [Display(Name = "3A")] Econ3A, [Display(Name = "3B")] Econ3B, [Display(Name = "3C")] Econ3C, [Display(Name = "3D")] Econ3D,
        [Display(Name = "4A")] Econ4A, [Display(Name = "4B")] Econ4B, [Display(Name = "4C")] Econ4C, [Display(Name = "4D")] Econ4D,
        [Display(Name = "5A")] Econ5A, [Display(Name = "5B")] Econ5B, [Display(Name = "5C")] Econ5C, [Display(Name = "5D")] Econ5D
    }


        public class SeatSelectionViewModel
        {
            public Flights Flight { get; set; }  
            public int NumPassengers { get; set; }
            public List<string> SelectedSeats { get; set; }
            public List<SelectListItem> AvailableSeats { get; set; }
            public List<string> PassengerNames { get; set; }
            public List<string> PassengerEmails { get; set; }
            public List<string> AdvantageNumbers { get; set; }

        public SeatSelectionViewModel()
            {
                SelectedSeats = new List<string>();
                AvailableSeats = new List<SelectListItem>();
                PassengerNames = new List<string>();

        }
    }
    }

