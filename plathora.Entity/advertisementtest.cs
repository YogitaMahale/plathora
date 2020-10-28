using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace plathora.Entity
{
  public   class advertisementtest
    {
        [Key]
        public int id { get; set; }
      //  [ForeignKey("CustomerRegistration")]
        public int customerid { get; set; }
        //public CustomerRegistration CustomerRegistration { get; set; }


     //   [ForeignKey("AffiltateRegistration")]
        public int? agentid { get; set; }
      //  public AffiltateRegistration AffiltateRegistration { get; set; }

       // [ForeignKey("Advertise")]
        public int adviceid { get; set; }
      //  public Advertise Advertise { get; set; }

        public DateTime startdate { get; set; }

        [Required]
        public string title { get; set; }

        public string url { get; set; }
        public string shortdesc { get; set; }
       public string longdesc { get; set; }


        public string img1 { get; set; }
        public string img2 { get; set; }

        [DefaultValue("false")]
        public Boolean isdeleted { get; set; }
        [DefaultValue("false")]
        public Boolean isactive { get; set; }
    }
}
