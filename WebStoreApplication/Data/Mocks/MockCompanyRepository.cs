using System.Collections.Generic;
using WebStoreApplication.Data.Repository;
using WebStoreApplication.Models;

namespace WebStoreApplication.Data.Mocks
{
    public class MockCompanyRepository : ICompanyRepository
    {
        public IEnumerable<Company> Companies
        {
            get
            {
                return new List<Company>
                {
                    new Company
                    {
                        CompanyId = 1,
                        Name = "Xiaomi",
                        Country = "China",
                        Description = @"The ""MI"" in our logo stands for “Mobile Internet”. It also has other meanings, including ""Mission Impossible"", because Xiaomi faced many challenges that had seemed impossible to defy in our early days."
                    },
                    new Company
                    {
                        CompanyId = 2,
                        Name = "Apple",
                        Country = "USA",
                        Description = "Apple Inc. is an American multinational technology company headquartered in Cupertino, California, that designs, develops, and sells consumer electronics, computer software, and online services."
                    },
                    new Company
                    {
                        CompanyId = 3,
                        Name = "Samsung",
                        Country = "Korean",
                        Description = "Samsung is a South Korean multinational conglomerate headquartered in Samsung Town, Seoul. It comprises numerous affiliated businesses, most of them united under the Samsung brand, and is the largest South Korean chaebol (business conglomerate)."
                    }
                };
            }
        }
    }
}
