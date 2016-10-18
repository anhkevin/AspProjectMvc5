using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoValidation.Models
{
    public class ValidationModels
    {
        [Required]
        public string name { get; set; }

        [Required]
        public string pass { get; set; }
    }
}