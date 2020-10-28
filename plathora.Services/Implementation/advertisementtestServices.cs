using plathora.Entity;
using plathora.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace plathora.Services.Implementation
{
   public  class advertisementtestServices:IadvertisementtestServices
    {
        private readonly ApplicationDbContext _context;
        public advertisementtestServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<int> CreateAsync(advertisementtest obj)
        {
            await _context.advertisementtest.AddAsync(obj);
            await _context.SaveChangesAsync();
            return obj.id;
        }

        public async Task Delete(int id)
        {
            var state = getbyid(id);
            state.isdeleted = true;
            _context.advertisementtest.Update(state);
            await _context.SaveChangesAsync();
        }
        public IEnumerable<advertisementtest> GetAll() => _context.advertisementtest.Where(x => x.isdeleted == false).ToList();
        public advertisementtest getbyid(int id) =>
            _context.advertisementtest.Where(x => x.id == id).FirstOrDefault();

     
        public async Task UpdateAsync(advertisementtest obj)
        {
            _context.advertisementtest.Update(obj);
            await _context.SaveChangesAsync();
        }
        
    }
}