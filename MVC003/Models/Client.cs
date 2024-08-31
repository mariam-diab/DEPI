using MVC_003.Models;

namespace MVC003.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        //public string ClientName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Order> Orders { get; set; }


    }
}