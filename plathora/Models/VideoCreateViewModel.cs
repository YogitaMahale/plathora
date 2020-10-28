using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace plathora.Models
{
    public class VideoCreateViewModel
    {
        public int id { get; set; }
        [Required]
        public int fkmoduleid { get; set; }
       

        public string type { get; set; }
        public string videoName { get; set; }

        public string videoLink { get; set; }
        public string description { get; set; }

        
        public Boolean isdeleted { get; set; }
      
        public Boolean isactive { get; set; }

    }
}
