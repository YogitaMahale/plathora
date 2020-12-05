﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plathora.Models
{
    public class NewCreateViewModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public IFormFile img { get; set; }
        public string description { get; set; }
        public Boolean isdeleted { get; set; }
        public Boolean isactive { get; set; }
        public DateTime date1 { get; set; }
        public DateTime createddate { get; set; }
    }
}
