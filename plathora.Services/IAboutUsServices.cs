using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using plathora.Entity;
namespace plathora.Services
{
    public interface IAboutUsServices
    {
       // Task<int> CreateAsync(advertisementInfo obj);
        AboutUs GetById(int id);
        Task UpdateAsync(AboutUs obj);
      //  Task Delete(int id);
        // IEnumerable<SelectListItem> GetAllState(int businssid);
       // IEnumerable<advertisementInfo> GetAll();
    }
}
