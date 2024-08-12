using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

//Change this namespace to match your project
namespace spr24_team4_finalproject.Models
{
    public class FlightSearchViewModel
    {

        [Required]
        [Display(Name = "From")]
        public string City1 { get; set; }

        [Required]
        [Display(Name = "To")]
        public string City2 { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Departure Date")]
        public DateTime DepartureDate { get; set; }

        [Required]
        [Display(Name = "Passengers")]
        [Range(1, 16, ErrorMessage = "Number of passengers must be between 1 and 16.")]
        public int Passengers { get; set; }
    }
}
