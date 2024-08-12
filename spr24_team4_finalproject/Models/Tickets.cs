using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace spr24_team4_finalproject.Models
{
    public enum TicketClass
    {
        Economy,
        First
    }

	public enum Seats
    {	[Display(Name = "1A")] First1A, [Display(Name = "1B")] First1B, [Display(Name = "2A")] First2A,[Display(Name = "2B")] First2B,
		[Display(Name = "3A")] Econ3A, [Display(Name = "3B")] Econ3B, [Display(Name = "3C")] Econ3C, [Display(Name = "3D")] Econ3D,
		[Display(Name = "4A")] Econ4A, [Display(Name = "4B")] Econ4B, [Display(Name = "4C")] Econ4C, [Display(Name = "4D")] Econ4D,
		[Display(Name = "5A")] Econ5A, [Display(Name = "5B")] Econ5B, [Display(Name = "5C")] Econ5C, [Display(Name = "5D")] Econ5D
    }

    public enum DiscountType
    {
        [Display(Name = "General (No discount)")]
        General,
        [Display(Name = "Senior Citizen Discount")]
        SeniorCitizen,
        [Display(Name = "Child Discount")]
        Child
    }

    public enum TicketStatus {  Active, Cancelled, NoShow};

	public class Tickets
	{
  
		[Key]
		public Int32 TicketsID { get; set; }

        [Required(ErrorMessage = "Seat number is required.")]
        [Display(Name = "Seat Number")]
		public Seats SeatNumber { get; set; }

        [Display(Name = "Ticket Class")]
        public TicketClass Class => SeatNumber.ToString().StartsWith("First") ? TicketClass.First : TicketClass.Economy;

        private decimal baseTicketPrice;
       
        [Required(ErrorMessage = "Ticket price is required.")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Display(Name = "Base Ticket Price")]
        public decimal TicketPrice
        {
            get { return baseTicketPrice; }
            set { baseTicketPrice = value; }
        }

        public decimal CalculateDiscountedPrice()
        {
            if (DiscountType == DiscountType.SeniorCitizen)
            {
                return baseTicketPrice - (baseTicketPrice * .10m);
            }

            if (DiscountType == DiscountType.Child)
            {
                return baseTicketPrice - (baseTicketPrice * .15m);
            }

            return baseTicketPrice;
        }

        //ticket status
        [Display(Name = "Ticket Status ")]
        public TicketStatus TicketStatus { get; set; }

        //discount type
        [Display(Name = "Discount Type")]
        public DiscountType DiscountType { get; set; }

        //miles earned
        [Display(Name = "Miles Earned")]
        public Int32 MilesEarned { get; set; }

        //modification fee
        [Display(Name = "Modification Fee")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal ModificationFee { get; set; }

        [Display(Name = "Flight ID")]
        public int FlightsID { get; set; }

        //navigational properties
        public AppUser Ticketholder { get; set; }
        public Reservations Reservation { get; set; }
        [ForeignKey("FlightsID")]
        public Flights Flight { get; set; }

    }
}