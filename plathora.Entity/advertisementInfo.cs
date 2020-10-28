using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace plathora.Entity
{
  public class advertisementInfo
    {
      
        public int id { get; set; }
      
        public int? affilateid { get; set; }
        

        
        public int cusotmerid { get; set; }
       

       //// [ForeignKey("Advertise")]
        public int advertiseid { get; set; }
      //  public Advertise advertise { get; set; }

        //id, affilateid, customerId, Advertiseid, startdate, title, videourl, shortdesc, longdesc, img1, img2, isdeleted

        public DateTime startdate { get; set; }
        public string title { get; set; }
        public string videourl { get; set; }
        public string shortdesc { get; set; }
        public string longdesc { get; set; }
        public string image1 { get; set; }
        public string image2 { get; set; }       
      


        [DefaultValue("false")]
        public Boolean isdeleted { get; set; }
        
    }
}
