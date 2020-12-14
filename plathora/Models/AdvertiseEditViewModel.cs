using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace plathora.Models
{
    public class AdvertiseEditViewModel
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }


        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        [Display(Name ="Period( Month )")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Enter Only Numbers")]
        public int period { get; set; }

        [Required]
        [Display(Name = "GST")]
        public decimal gst { get; set; }

        public IFormFile img { get; set; }
    }
}
