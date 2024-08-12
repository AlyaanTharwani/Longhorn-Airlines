using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;

//Change this namespace to match your project
namespace spr24_team4_finalproject.Models
{
    public class ReportViewModel
    {
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        [Display(Name = "City")]
        public string? City { get; set; }

        [Display(Name = "Route")]
        public int? RouteID { get; set; }

        [Display(Name = "Class")]
        public string? Class { get; set; }

        public IEnumerable<SelectListItem> Routes { get; set; }

        // Properties to hold report results
        [Display(Name = "Total Revenue")]
        [DisplayFormat(DataFormatString = "{0:C}")] // Currency format
        public decimal TotalRevenue { get; set; }

        [Display(Name = "Total Seats Sold")]
        public int TotalSeatsSold { get; set; }
    }

}
