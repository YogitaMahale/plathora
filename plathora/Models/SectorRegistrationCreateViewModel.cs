using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace plathora.Models
{
    public class SectorRegistrationCreateViewModel
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Sector Name")]
        public string name { get; set; }

        public IFormFile img { get; set; }
        public IFormFile photo { get; set; }
        public Boolean isdeleted { get; set; }

        public Boolean isactive { get; set; }
    }
}
