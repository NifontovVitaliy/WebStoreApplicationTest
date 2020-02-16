using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStoreApplication.Models
{
    public class Phone
    {
        public int PhoneId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        public double Discount { get; set; }
        public bool InStock { get; set; }
        public string ImageUrl { get; set; }
    }
}
