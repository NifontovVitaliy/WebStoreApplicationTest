using System.Collections.Generic;
using WebStoreApplication.Models;

namespace WebStoreApplication.Data.Repository
{
    public interface IPhoneRepository
    {
        IEnumerable<Phone> Phones { get; }
        IEnumerable<Phone> TopBuyingPhone { get; }
        Phone GetPhoneById(int phoneId);
    }
}
