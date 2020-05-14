using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace plathora.Models
{
    public class AffiltateRegistrationEditViewModel
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Name is Required"), StringLength(500, MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-Z\s]+$"), Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name = "Profile Photo")]
        public IFormFile profilephoto { get; set; }
        [Display(Name = "Mobile No.")]
        [Required(ErrorMessage = "Mobile No is Required")]
        public string mobileno1 { get; set; }
        [Display(Name = "Alternet Mobile No.")]
        public string mobileno2 { get; set; }
        [Display(Name = "Email ID")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string emailid1 { get; set; }
        [Display(Name = "Alternet Email ID")]
        public string emailid2 { get; set; }
        public string adharcardno { get; set; }
        public IFormFile adharcardphoto { get; set; }

        public string pancardno { get; set; }
        public IFormFile pancardphoto { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string password { get; set; }
        [Required]
        public string gender { get; set; }

        [DataType(DataType.Date), Display(Name = "Date of Borth")]
        public DateTime DOB { get; set; }
        [DataType(DataType.Date), Display(Name = "Date")]
        public DateTime createddate { get; set; }
    }
}
