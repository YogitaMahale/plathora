using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace plathora.Entity
{
    public class AdvertisementDetails
    {
        [Key]
        public int id { get; set; }

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
        public bool isdeleted { get; set; }
    }
}
