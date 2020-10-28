using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace plathora.Models
{
    public class MembershipEditViewModel
    {
        public int id { get; set; }
        [Required]
        public string membershipName { get; set; }

    }
}
