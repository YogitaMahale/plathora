using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace plathora.Entity
{
   public  class AffiltateRegistration
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }

        public string profilephoto { get; set; }
        [Required]
        public string mobileno1 { get; set; }
        public string mobileno2 { get; set; }
        public string emailid1 { get; set; }
        public string emailid2 { get; set; }
        public string adharcardno { get; set; }
        public string adharcardphoto { get; set; }

        public string pancardno { get; set; }
        public string pancardphoto { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public Gender gender { get; set; }

        public DateTime DOB { get; set; }

        public DateTime createddate { get; set; }

    }
}
