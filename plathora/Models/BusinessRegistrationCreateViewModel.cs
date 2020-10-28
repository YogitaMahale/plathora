using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace plathora.Models
{
    public class BusinessRegistrationCreateViewModel
    {
        public int id { get; set; }


        [Required]
        public int sectorid { get; set; }
        [Required(ErrorMessage = "Name is Required"), StringLength(500, MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-Z\s]+$"), Display(Name = "Name")]

        public string name { get; set; }
        public IFormFile img { get; set; }


        public Boolean isdeleted { get; set; }
        
        public Boolean isactive { get; set; }
    }
}
