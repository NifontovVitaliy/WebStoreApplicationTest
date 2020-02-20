using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebStoreApplication.Models;

namespace WebStoreApplication.Data.Repository
{
    public class PhoneRepository : IPhoneRepository
    {
        private readonly WebStoreDbContext _dbContext;
        public PhoneRepository(WebStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Phone> Phones => _dbContext.Phones.Include(p => p.Company);

        public IEnumerable<Phone> TopBuyingPhone => _dbContext.Phones
            .Where(p => p.IsTopBuying == true)
            .Include(p => p.Company);

        public Phone GetPhoneById(int phoneId) => _dbContext.Phones
            .Where(p => p.PhoneId == phoneId)
            .FirstOrDefault();
    }
}
