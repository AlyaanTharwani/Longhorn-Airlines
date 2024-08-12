using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace spr24_team4_finalproject.Models
{
    public class CreateReservationViewModel
    {
        [Required]
        [Display(Name = "Departure City")]
        public string DepartureCity { get; set; }

        [Required]
        [Display(Name = "Arrival City")]
        public string ArrivalCity { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Flight")]
        public DateTime? Date { get; set; }

        [Required]
        [Display(Name = "Number of Passengers")]
        public int NumberOfPassengers { get; set; }


        [Display(Name = "Selected Flight Identifier")]
        public int? FlightsID { get; set; }

        public IEnumerable<SelectListItem> AvailableFlights { get; set; } = new List<SelectListItem>();
    }

}