using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plathora.Models
{
    public class collectionreport_affilateViewModel
    {
        // Id,name,PhoneNumber ,pkgamount,gstamt,createddate
        public string Id { get; set; }
        public string name { get; set; }
        public string PhoneNumber { get; set; }
        public decimal pkgamount { get; set; }
 
        public decimal PaymentAmount { get; set; }
        public decimal  gstamt { get; set; }
        public string createddate { get; set; }
    }
}
