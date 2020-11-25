using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace plathora.Entity
{
  public  class BusinessOwnerRegi
    {
//        id, , , , , , , , , , 
//, , , pinno, , , , , , , , , , ,
// , , , , , Discription, Regcertificate, businessid, productid, lic
// , registerbyAffilateID, deviceid, customerid, MondayOpen, MondayClose, TuesdayOpen, TuesdayClose,
//  WednesdayOpen, WednesdayClose, ThursdayOpen, ThursdayClose, FridayOpen, FridayClose, SaturdayOpen,
//   SaturdayClose, SundayOpen, SundayClose, CallCount, SMSCount, WhatssappCount, ShareCount,
//    sliderimg1, sliderimg2, sliderimg3, sliderimg4, sliderimg5

        public int id { get; set; }  

        [ForeignKey("ApplicationUser")]
        public string customerid { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
       
       
        public string description { get; set; }
        public string Regcertificate { get; set; }
        public string businessid { get; set; }
        // public string productid { get; set; }
        [ForeignKey("ProductMaster")]
        public int productid { get; set; }
        public ProductMaster ProductMaster { get; set; }
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

    }
}
