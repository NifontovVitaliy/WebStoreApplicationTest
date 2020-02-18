using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebStoreApplication.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        [Required]
        [StringLength(100)]
        public string CompanyName { get; set; }
        [Required]
        [StringLength(100)]
        public string Country { get; set; }
        public IEnumerable<Phone> Phones { get; set; }
        public string Description { get; set; }
    }
}
