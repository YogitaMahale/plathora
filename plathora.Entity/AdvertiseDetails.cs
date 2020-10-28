using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace plathora.Entity
{
   public  class AdvertiseDetails
    {
        //id,customerid,advertismenttype id, start date,video url, title, shortdesc, longdesc, img1, img2
        [Key]
        public int Id { get; set; }

        //public int? affilateid { get; set; }
        //[ForeignKey("affilateid")]
        //public AffiltateRegistration affiltateRegistration { get; set; }

        //public int customerId { get; set; }
        //[ForeignKey("customerId")]
        //public CustomerRegistration customerRegistration { get; set; }


        //public int Advertiseid { get; set; }
        //[ForeignKey("Advertiseid")]
        //public Advertise advertise { get; set; }

        
        public int? affilateid { get; set; }
         

         
        public int customerId { get; set; }
        
        
        public int Advertiseid { get; set; }
       

        public DateTime startdate { get; set; } = DateTime.UtcNow;
        public string title { get; set; }
        public string videourl { get; set; }
   
        public string shortdesc { get; set; }
        public string longdesc { get; set; }
        public string img1 { get; set; }
        public string img2 { get; set; }
        public bool isdeleted { get; set; } = false;
        

    }
}
