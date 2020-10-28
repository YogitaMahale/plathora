using plathora.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace plathora.Services
{
 public    interface IadvertisementtestServices
    {
        Task<int> CreateAsync(advertisementtest obj);
        advertisementtest getbyid(int id);
        Task UpdateAsync(advertisementtest obj);
        Task Delete(int id);
        //ienumerable<selectlistitem> getallcity(int stateid);
        IEnumerable<advertisementtest> GetAll();
    }
}
