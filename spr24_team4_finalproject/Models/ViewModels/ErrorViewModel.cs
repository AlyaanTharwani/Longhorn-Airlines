using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using spr24_team4_finalproject.Models;

namespace spr24_team4_finalproject.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public string ErrorMessage { get; set; }  // Custom property for error messages
    }
}
