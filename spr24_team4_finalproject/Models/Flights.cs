//add using directive for the data annotations
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace spr24_team4_finalproject.Models
{
    public enum Status { Active, Inactive, Departed }

    public class Flights
    {
        [Key]
        public Int32 FlightsID { get; set; }

        [DisplayName("Flight Identifier: ")]
        public Int32 FlightIdentifier { get; set; }

        [DisplayName("Flight Number: ")]
        [Required(ErrorMessage = "Flight Number is Required.")]
        public Int32 FlightNumber { get; set; }

        [DisplayName("Departure Time: ")]
        [Required(ErrorMessage = "Departure time is Required.")]
        public DateTime DepartureDateTime { get; set; }

        [DisplayName("Arrival Time: ")]
        [Required(ErrorMessage = "Arrival time is Required.")]
        public DateTime ArrivalDateTime { get; set; }
 
        [DisplayName("Status: ")]
        [Required(ErrorMessage = "Customer Status is Required.")]
        public Status status { get; set; }

        [DisplayName("Economy Price: ")]
        [Required(ErrorMessage = "Economy price is required.")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal EconomyPrice { get; set; }

        [DisplayName("Available Seats: ")]
        [Required(ErrorMessage = "Available seats is required.")]
        public Int32 AvailableSeats { get; set; }

        //navigational properties

        public FlightRoutes FlightRoute { get; set; }

        public virtual List<Tickets> Ticket { get; set; }

        public Flights()
        {
            if (Ticket == null)

            {
                Ticket = new List<Tickets>();
            }
        }
    }
}