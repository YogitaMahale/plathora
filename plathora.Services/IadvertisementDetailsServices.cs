using plathora.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace plathora.Services
{
   public  interface IadvertisementDetailsServices
    {   
        Task<int> CreateAsync(AdvertisementDetails obj);
        AdvertisementDetails GetById(int id);
        Task UpdateAsync(AdvertisementDetails obj);
        Task Delete(int id);

        IEnumerable<AdvertisementDetails> GetAll();
    }
}
