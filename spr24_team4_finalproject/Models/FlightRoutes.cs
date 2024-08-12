using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace spr24_team4_finalproject.Models
{
	public class FlightRoutes
	{
		[Key]
		public Int32 FlightRoutesID { get; set; }

        [Required(ErrorMessage = "Origin city is required.")]
        [Display(Name = "Origin City ")]
		public string City1 { get; set; }

        [Required(ErrorMessage = "Destination city is required.")]
        [Display(Name = "Destination City")]
        public string City2 { get; set; }

        [Required(ErrorMessage = "Flight distance is required.")]
        [Display(Name = "Flight Distance (miles)")]
        public Int32 Distance { get; set; }

        [Required(ErrorMessage = "Duration is required.")]
        [Display(Name = "Estimated Duration")]
        public TimeSpan Duration { get; set; }

        public List<Flights> Flight { get; set; }

        public FlightRoutes()
        {
            if (Flight == null)
            {
                Flight = new List<Flights>();
            }
        }
    }
}