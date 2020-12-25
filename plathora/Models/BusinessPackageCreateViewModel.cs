using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace plathora.Models
{
    public class BusinessPackageCreateViewModel
    {
        public int id { get; set; }


        [Required]
        [Display(Name = "Package Name")]
        public int pkgId { get; set; }

        [Required]
         
        [RegularExpression(@"((\d+)((\.\d{1,2})?))$"), Display(Name = "Amount")]
        public decimal Amount { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string description { get; set; }
        [Required]
        [Display(Name ="Period in Month")]
        public string period { get; set; }
        
        public Boolean isdeleted { get; set; }
        [Required]
        [Display(Name ="GST")]
        [RegularExpression(@"((\d+)((\.\d{1,2})?))$")]
        public decimal gst { get; set; }
        public Boolean isactive { get; set; }
    }
}
