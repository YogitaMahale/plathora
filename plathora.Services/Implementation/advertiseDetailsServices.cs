using plathora.Entity;
using plathora.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace plathora.Services.Implementation
{
  public  class advertiseDetailsServices: IadvertiseDetailsServices
    {
        private readonly ApplicationDbContext _context;
        public advertiseDetailsServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<int> CreateAsync(AdvertiseDetails obj)
        {
            try
            {
                await _context.advertiseDetails.AddAsync(obj);
                await _context.SaveChangesAsync();
            }
            catch(Exception p)
            {
                string s = p.Message;
            }
         
            return obj.Id;
        }
        


        public async Task Delete(int id)
        {
            var obj = GetById(id);
            obj.isdeleted = true;
            _context.advertiseDetails.Update(obj);
            await _context.SaveChangesAsync();
        }
        public IEnumerable<AdvertiseDetails> GetAll() => _context.advertiseDetails.Where(x => x.isdeleted == false).ToList();



        public AdvertiseDetails GetById(int id) =>
            _context.advertiseDetails.Where(x => x.Id == id).FirstOrDefault();

        public async Task UpdateAsync(AdvertiseDetails obj)
        {
            _context.advertiseDetails.Update(obj);
            await _context.SaveChangesAsync();
        }

        
    }
}