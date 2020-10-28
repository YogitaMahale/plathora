using plathora.Entity;
using plathora.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace plathora.Services.Implementation
{
   public  class advertisementDetailsServices:IadvertisementDetailsServices
    {
        private readonly ApplicationDbContext _context;
        public advertisementDetailsServices(ApplicationDbContext context)
        {
            _context = context;
        }
        //public async Task CreateAsync(AffiltateRegistration obj)
        //{

        //    await _context.affiltateRegistrations.AddAsync(obj);
        //    await _context.SaveChangesAsync();

        //}
        public async Task<int> CreateAsync(AdvertisementDetails obj)
        {

            await _context.advertisementDetails.AddAsync(obj);
            await _context.SaveChangesAsync();
            return obj.id;
        }

        public async Task Delete(int id)
        {
            var affilate = GetById(id);
            affilate.isdeleted = true;
            _context.Update(affilate);
            // _context.Remove(affilate);
            await _context.SaveChangesAsync();

        }

        public IEnumerable<AdvertisementDetails> GetAll() => _context.advertisementDetails.Where(x => x.isdeleted == false).ToList();

        public AdvertisementDetails GetById(int affilateid) =>
            _context.advertisementDetails.Where(x => x.id == affilateid).FirstOrDefault();

        public async Task UpdateAsync(AdvertisementDetails obj)
        {
            _context.Update(obj);
            await _context.SaveChangesAsync();
        }
    }
}
