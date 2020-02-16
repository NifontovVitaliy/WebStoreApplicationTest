using System.Collections.Generic;
using WebStoreApplication.Models;

namespace WebStoreApplication.ViewModels
{
    public class PhoneViewModel
    {
        public IEnumerable<Phone> Phones { get; set; }
        public string CurrentCategory { get; set; }
    }
}
