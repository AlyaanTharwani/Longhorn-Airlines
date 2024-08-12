using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace spr24_team4_finalproject.Models
{
	public enum Payment
	{
		Miles,
		Dollars
	}

    public enum ResStatus
    {
        Active,
        Inactive
    }

	public class Reservations
	{
        private const Decimal TAX_RATE = 0.0825m;

        [Key]
		public Int32 ReservationsID { get; set; }

        [DisplayName("Reservation Number")]
        [Required(ErrorMessage = "Reservation Number is Required.")]
        public Int32 ReservationNumber { get; set; }

        [Display(Name = "Reservation Status")]
        public ResStatus ResStatus { get; set; }

        [Display(Name = "Payment Type")]
		public Payment PaymentType { get; set; }

        //where does price, modification fee from tickets class affect subtotal, tax, total

        [Display(Name = "Subtotal")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [DataType(DataType.Currency)]
        public Decimal Subtotal { get; set; }

        [Display(Name = "Tax")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [DataType(DataType.Currency)]
        public Decimal Tax
        {
            get { return Subtotal * TAX_RATE;}
        }

        [Display(Name = "Total")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal Total
        {
            get { return Subtotal + Tax; }
        }
        
        [Display(Name = "Miles Deduction")]
        public Int32 MilesDeduction { get; set; }

        //navigational properties
        public AppUser ReservationMaker { get; set; }

        public List<Tickets> Ticket { get; set; }

        public Reservations()
        {
            if (Ticket == null)

            {
                Ticket = new List<Tickets>();
            }
        }
    }
}