using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace plathora.Models
{
    public class AffilatePackageEditModel
    {
        public int id { get; set; }

        public int membershipid { get; set; }


        public int commissionid { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal amount { get; set; }
        [Required]
        [Display(Name = "GST")]
        public decimal gst { get; set; }
        public string Description { get; set; }


    }
}
