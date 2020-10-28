using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace plathora.Models
{
    public class MembershipCreateViewModel
    {
        public int id { get; set; }
        [Required]
        public string membershipName { get; set; }

       
        public Boolean isdeleted { get; set; }
         
        public Boolean isactive { get; set; }
    }
}
