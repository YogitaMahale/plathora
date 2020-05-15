using plathora.Entity;
using plathora.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plathora.Services.Implementation
{
   public  class AffiltateRegistrationService: IAffiltateRegistrationService
    {
        private readonly ApplicationDbContext _context;
        public AffiltateRegistrationService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(AffiltateRegistration obj)
        {
       
            await _context.affiltateRegistrations.AddAsync(obj);
            await _context.SaveChangesAsync();

        }

        public async Task Delete(int affilateid)
        {
            var affilate = GetById(affilateid);


            _context.Remove(affilate);
            await _context.SaveChangesAsync();

        }

        public IEnumerable<AffiltateRegistration > GetAll() => _context.affiltateRegistrations;

        public AffiltateRegistration  GetById(int affilateid) =>
            _context.affiltateRegistrations.Where(x => x.id == affilateid).FirstOrDefault();

        public async Task UpdateAsync(AffiltateRegistration obj)
        {
            _context.Update(obj);
            await _context.SaveChangesAsync();
        }
    }
}
