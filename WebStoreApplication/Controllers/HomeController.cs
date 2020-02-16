using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebStoreApplication.Data.Repository;
using WebStoreApplication.Models;
using WebStoreApplication.ViewModels;

namespace WebStoreApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPhoneRepository _phoneRepository;
        private readonly ICompanyRepository _companyRepository;

        public HomeController(IPhoneRepository phoneRepository, ICompanyRepository companyRepository)
        {
            _phoneRepository = phoneRepository;
            _companyRepository = companyRepository;
        }

        public IActionResult ShowPhones()
        {
            var phoneViewModel = new PhoneViewModel()
            {
                Phones = _phoneRepository.Phones.ToList()
            };


            return View(phoneViewModel);
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
