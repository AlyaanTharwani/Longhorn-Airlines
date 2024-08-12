 using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;


namespace spr24_team4_finalproject.Models
{
    public enum EmpStatus {Active, Inactive};
    
    public class AppUser : IdentityUser
    {

        [Display(Name = "First Name:")]
        [Required(ErrorMessage = "First name is required.")]
        public String FirstName { get; set; }

        [Display(Name = "Middle Initial:")]
        public String? MiddleInitial { get; set; }

        [Display(Name = "Last Name:")]
        [Required(ErrorMessage = "Last name is required.")]
        public String LastName { get; set; }

        public String FullName
        {
            get { return FirstName + " " + MiddleInitial + " " + LastName; }
        }

        [Display(Name = "Date of Birth:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Street:")]
        [Required(ErrorMessage = "Street is required.")]
        public String Street { get; set; }

        [Display(Name = "City:")]
        [Required(ErrorMessage = "City is required.")]
        public String City { get; set; }

        [Display(Name = "Zip:")]
        [Required(ErrorMessage = "Zipcode is required.")]
        public String Zip { get; set; }

        [Display(Name = "State:")]
        [Required(ErrorMessage = "State is required.")]
        public String State { get; set; }

        public String Address
        {
            get { return Street + " " + City + " " + State + " " + Zip; }
        }

        [Display(Name = "Status:")]
        //[Required(ErrorMessage = "Status is required.")]
        public EmpStatus? empStatus { get; set; }//

        [Display(Name = "Advantage Number:")]
        public Int32? AdvNumber { get; set; }

        [Display(Name = "Miles:")]
        public Int32? Miles { get; set; }

        //NAVIGATIONAL PROPERTIES
        public List<Tickets> Ticket { get; set; }
        public List<Reservations> Reservation { get; set; }

        public AppUser()
        {
            Ticket ??= new List<Tickets>();
            Reservation ??= new List<Reservations>();
        }
    }
}
