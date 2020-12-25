﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace plathora.Models
{
    public class AffilateListSPViewModel
    {
        public string Id { get; set; }

        
        public string name { get; set; }

        

        public string MiddleName { get; set; }

         
        public string LastName { get; set; }
        


         
        
        public string profilephoto { get; set; }
         
        public string PhoneNumber { get; set; }
        
        public string mobileno2 { get; set; }
         
        public string Email { get; set; }
       
        public string emailid2 { get; set; }
        
        public string adharcardno { get; set; }
        
        public string adharcardphoto { get; set; }

        public string pancardno { get; set; }
        
        public string pancardphoto { get; set; }

        
        public string gender { get; set; }

        public DateTime DOB { get; set; }


      

        public string bankname { get; set; }
        public string accountname { get; set; }
        public string accountno { get; set; }
        public string ifsccode { get; set; }
        public string branch { get; set; }
        public string passbookphoto { get; set; }
        public string uniqueId { get; set; }
        
        public string registrationDate { get; set; }
    }
}





