using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plathora.Models
{
    public class BusinessownercollectionReportSPModel
    {

     //   id,MembershipId,customerName,membershipName,gstper,pkgamt,gstamt,PaymentAmount,Registrationdate
        public int id { get; set; }
        public int MembershipId { get; set; }
        public string customerName { get; set; }
        public string membershipName { get; set; }
        public decimal pkgamt { get; set; }

        public decimal gstper { get; set; }
        public decimal gstamt { get; set; }
        public decimal PaymentAmount { get; set; }
        public string Registrationdate { get; set; }
    }
}
