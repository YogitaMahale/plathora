﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace plathora.Models
{
    public class SectorRegistrationEditViewModel
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Sector Name")]
        public string name { get; set; }
        [Display(Name = "Icon")]
        public IFormFile img { get; set; }
        [Display(Name = "Image")]
        public IFormFile photo { get; set; }
    }
}
