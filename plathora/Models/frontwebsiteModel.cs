using plathora.Entity;
using plathora.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plathora.Models
{
    public class frontwebsiteModel
    {

        public IEnumerable<SectorRegistrationIndexViewModel> objSectorRegistration { get; set; }
        public IEnumerable<selectallBusinessDetailsDtos> objBusinessDetails { get; set; }
        public IEnumerable<NewIndexViewModel> objNews { get; set; }



    }
}
