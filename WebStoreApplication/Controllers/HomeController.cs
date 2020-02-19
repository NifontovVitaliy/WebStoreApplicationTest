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

        public HomeController(IPhoneRepository phoneRepository)
        {
            _phoneRepository = phoneRepository;
        }
        
        public IActionResult Index()
        {
            var phones = _phoneRepository.Phones.Where(p => p.IsTopBuying == true).OrderBy(p => p.CompanyId);
            var phoneViewModel = new PhoneViewModel
            {
                Phones = phones
            };
            return View(phoneViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
