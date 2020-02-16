using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStoreApplication.Models
{
    public class Order
    {
        public Order(){}
        public Order(string firstName, 
            string lastName,
            string address,
            string zipCode,
            string city,
            string country,
            string phoneNumber,
            string email)
        {
            OrderId = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            ZipCode = zipCode;
            City = city;
            Country = country;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        [Key]
        public Guid OrderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal OrderTotal { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
