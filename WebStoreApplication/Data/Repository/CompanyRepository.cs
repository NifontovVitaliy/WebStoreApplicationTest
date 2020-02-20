using System.Collections.Generic;
using WebStoreApplication.Models;

namespace WebStoreApplication.Data.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly WebStoreDbContext _dbContext;
        public CompanyRepository(WebStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Company> Companies => _dbContext.Companies;
    }
}
