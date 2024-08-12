using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

//Change this namespace to match your project
namespace spr24_team4_finalproject.Models
{
    public class CustomerProfileViewModel
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        /*public Int32? Miles { get; set; }*/

    }
}
