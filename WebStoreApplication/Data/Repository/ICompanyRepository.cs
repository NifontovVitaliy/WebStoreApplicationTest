using System.Collections.Generic;
using WebStoreApplication.Models;

namespace WebStoreApplication.Data.Repository
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> Companies { get; }
    }
}
