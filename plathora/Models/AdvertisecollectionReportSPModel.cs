using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plathora.Models
{
    public class AdvertisecollectionReportSPModel
    {
     //   id,advertiseid,title ,pkgamount,gstper,gstamt,PaymentAmount,startdate
        public string Id { get; set; }
        public int advertiseid { get; set; }
        public string title { get; set; }
        public decimal pkgamount { get; set; }

        public decimal gstper { get; set; }
        public decimal gstamt { get; set; }
        public decimal PaymentAmount { get; set; }
        public string startdate { get; set; }
    }
}
