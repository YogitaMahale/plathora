using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plathora.Models.Dtos
{
    public class BusinessOwnerRegistrationDtos
    {
        public int id { get; set; } 
        public string name { get; set; } 
        public string profilephoto { get; set; } 
        public string mobileno1 { get; set; }
         
        public string mobileno2 { get; set; }
         
        public string emailid1 { get; set; }
         
        public string emailid2 { get; set; }
       
        public string adharcardno { get; set; }
         
        public string adharcardphoto { get; set; }
        
        public string pancardno { get; set; }
         
        public string pancardphoto { get; set; }
        public string password { get; set; }
        public string gender { get; set; }
        public string pinno { get; set; }
        public DateTime DOB { get; set; } = DateTime.UtcNow;
       // public DateTime createddate { get; set; } = DateTime.UtcNow;


      //  public Boolean isdeleted { get; set; }

       // public Boolean isactive { get; set; }
        public string house { get; set; }
        public string landmark { get; set; }
        public string street { get; set; }
        //public int countryid { get; set; }
        //public int stateid { get; set; }
        public int cityid { get; set; }
        public string zipcode { get; set; }

        public string latitude { get; set; }
        public string longitude { get; set; }
        public string companyName { get; set; }
        public string designation { get; set; }
        public string gstno { get; set; }
        public string Website { get; set; }
        public string Discription { get; set; }
        public string Regcertificate { get; set; }

        //public int sectorid { get; set; }
        public string businessid { get; set; }


        

        public string productid { get; set; }
        public string lic { get; set; }
        public int registerbyAffilateID { get; set; }
        public string deviceid { get; set; }
        public int? customerid { get; set; }

        public string sliderimg1 { get; set; }
        public string sliderimg2 { get; set; }
        public string sliderimg3 { get; set; }
        public string sliderimg4 { get; set; }
        public string sliderimg5 { get; set; }
    }
}

//id:1
//name:test
//profilephoto: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
//mobileno1:9146582495
//mobileno2:9146582495
//emailid1:test @gmail.com
//emailid2:test @gmail.com
//adharcardno:123
//adharcardphoto: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
//pancardno:232
//pancardphoto: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
//password:123
//gender:1
//pinno:42202
//DOB:06/03/2020
//house:houes
//landmark:landmark
//street:street
//cityid:1
//zipcode:42202
//latitude:32323
//longitude:2434
//companyName:compna name
//designation:desig
//gstno:gst
//Website:websi
//Discription:desc
//Regcertificate:regcer
//productid:1
//lic:lic
//registerbyAffilateID:5
//deviceid:432423434