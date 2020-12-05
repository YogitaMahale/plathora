using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plathora.Models.Dtos
{
    public class BusinessOwnerRegistrationDtos
    {
        public int id { get; set; } = 0;

        
        public string customerid { get; set; }
      

        public string description { get; set; }
        public string Regcertificate { get; set; }
        public string businessid { get; set; }
        // public string productid { get; set; }
      
        public string  productid { get; set; }
      
        public string lic { get; set; }

        public string MondayOpen { get; set; }
        public string MondayClose { get; set; }

        public string TuesdayOpen { get; set; }
        public string TuesdayClose { get; set; }

        public string WednesdayOpen { get; set; }
        public string WednesdayClose { get; set; }

        public string ThursdayOpen { get; set; }
        public string ThursdayClose { get; set; }

        public string FridayOpen { get; set; }
        public string FridayClose { get; set; }

        public string SaturdayOpen { get; set; }
        public string SaturdayClose { get; set; }
        public string SundayOpen { get; set; }
        public string SundayClose { get; set; }

        public int CallCount { get; set; } = 0;
        public int SMSCount { get; set; } = 0;
        public int WhatssappCount { get; set; } = 0;
        public int ShareCount { get; set; } = 0;


        public string sliderimg1 { get; set; }
        public string sliderimg2 { get; set; }
        public string sliderimg3 { get; set; }
        public string sliderimg4 { get; set; }
        public string sliderimg5 { get; set; }
        public string facebookLink { get; set; }
        public string twitterLink { get; set; }
        public string youtubeLink { get; set; }
        public string linkedinLink { get; set; }
        public string googleplusLink { get; set; }
        public string instagramLink { get; set; }
    }
}
 