using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebStoreApplication.Data.Repository;
using WebStoreApplication.Models;
using WebStoreApplication.ViewModels;

namespace WebStoreApplication.Controllers
{
    public class PhoneController : Controller
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IPhoneRepository _phoneRepository;
        public PhoneController(ICompanyRepository companyRepository, IPhoneRepository phoneRepository)
        {
            _companyRepository = companyRepository;
            _phoneRepository = phoneRepository;
        }
        public ViewResult List(string company)
        {
            var _company = company;
            IEnumerable<Phone> phones;
            string currentCompany = string.Empty;

            if (string.IsNullOrEmpty(company))
            {
                phones = _phoneRepository.Phones.OrderBy(p => p.CompanyId);
                currentCompany = "All Companies";
            }
            else
            {
                phones = _phoneRepository.Phones
                    .Where(p => p.Company.CompanyName.Equals(_company, StringComparison.CurrentCultureIgnoreCase))
                    .OrderBy(p => p.CompanyId);
                currentCompany = _company;
            }

            var phoneViewModel = new PhoneViewModel
            {
                Phones = phones,
                CurrentCompany = currentCompany
            };

            return View(phoneViewModel);
        }
    }
}