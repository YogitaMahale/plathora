using plathora.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace plathora.Services
{
  public  interface IadvertiseDetailsServices
    {
        Task<int> CreateAsync(AdvertiseDetails obj);
        AdvertiseDetails GetById(int id);
        Task UpdateAsync(AdvertiseDetails obj);
        Task Delete(int id);
        // IEnumerable<SelectListItem> GetAllState(int businssid);
        IEnumerable<AdvertiseDetails> GetAll();
    }
}
