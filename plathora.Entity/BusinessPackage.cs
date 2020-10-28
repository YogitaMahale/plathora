using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml.Schema;

namespace plathora.Entity
{
   public  class BusinessPackage
    {
        public int id { get; set; }



        public int pkgId { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal   Amount { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public string period { get; set; }


        [DefaultValue("false")]
        public Boolean isdeleted { get; set; }
        [DefaultValue("false")]
        public Boolean isactive { get; set; }

        [ForeignKey("pkgId")]
        public virtual PackageRegistration PackageRegistration { get; set; }

    }
}
