using System;
using System.ComponentModel.DataAnnotations;

namespace WebStoreApplication.Models
{
    public class OrderDetail
    {
        [Key]
        public Guid OrderDetailId { get; set; }
        public Guid OrderId { get; set; }
        public int PhoneId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual Phone Phone { get; set; }
        public virtual Order Order { get; set; }
    }
}
