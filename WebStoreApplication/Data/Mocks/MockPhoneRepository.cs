using System.Collections.Generic;
using System.Linq;
using WebStoreApplication.Data.Repository;
using WebStoreApplication.Models;

namespace WebStoreApplication.Data.Mocks
{
    public class MockPhoneRepository : IPhoneRepository
    {
        private readonly  ICompanyRepository _companyRepository = new MockCompanyRepository();
        public IEnumerable<Phone> Phones 
        {
            get 
            {
                return new List<Phone>
                {
                    new Phone
                    {
                        PhoneId = 1,
                        Name = "Xiaomi Note 10",
                        Company = _companyRepository.Companies.Where(c => c.CompanyId == 1).FirstOrDefault(),
                        CompanyId = 1,
                        Discount = 0,
                        ImageUrl = "/images/XiaomiMiNote10.jpg",
                        InStock = true,
                        IsTopBuying = true,
                        Description = @"Unpresentedly, Mi Note 10 features a 108MP camera, with a single photo resolution of up to 12032 x 9024, 12 times as high as 4K resolution! With a super large image sensor in a size of 1/1.33"", the camera in Mi Note 10 surpasses most digital cameras. By capturing more light and details, it reproduces the magnificence of the landscape. Isn't it breathtaking?",
                        Price = 28990M
                    },
                    new Phone
                    {
                        PhoneId = 2,
                        Name = "Redmi Note 8T",
                        Company = _companyRepository.Companies.Where(c => c.CompanyId == 1).FirstOrDefault(),
                        CompanyId = 1,
                        Discount = 0,
                        ImageUrl = "/images/XiaomiMi9t.jpg",
                        InStock = true,
                        IsTopBuying = true,
                        Description = "48MP Quad Camera All-Star 48MP AI quad camera Qualcomm® Snapdragon™ 665 4000mAh high-capacity battery",
                        Price = 18290M
                    },
                    new Phone
                    {
                        PhoneId = 3,
                        Name = "Iphone XR",
                        Company = _companyRepository.Companies.Where(c => c.CompanyId == 2).FirstOrDefault(),
                        CompanyId = 2,
                        Discount = 0,
                        ImageUrl = "/images/IphoneXR.jpg",
                        InStock = true,
                        IsTopBuying = false,
                        Description = "IPhone XR is a South Korean multinational conglomerate headquartered in Samsung Town, Seoul. It comprises numerous affiliated businesses, most of them united under the Samsung brand, and is the largest South Korean chaebol (business conglomerate).",
                        Price = 45990M
                    },
                    new Phone
                    {
                        PhoneId = 4,
                        Name = "Samsung Galaxy A10",
                        Company = _companyRepository.Companies.Where(c => c.CompanyId == 3).FirstOrDefault(),
                        CompanyId = 3,
                        Discount = 0.1,
                        ImageUrl = "/images/SamsungGalaxyA10.jpg",
                        InStock = true,
                        IsTopBuying = false,
                        Description = "The Samsung Galaxy A10 is an Android smartphone developed by Samsung Electronics. It was released in March 2019. It comes with Android 9 (Pie) with One UI, 32GB internal storage, and a 3400 mAh battery.",
                        Price = 7790M
                    }
                };
            }
        }

        public IEnumerable<Phone> TopBuyingPhone => Phones.Where(p => p.IsTopBuying == true);

        public Phone GetPhoneById(int phoneId) => Phones.Where(p => p.PhoneId == phoneId).FirstOrDefault();
    }
}
