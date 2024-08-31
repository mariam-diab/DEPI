using MVC003.Models;
using System.ComponentModel.DataAnnotations;

namespace MVC_003.Models
{
    public class Order
    {
        [Key]
        public int InvoiceNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public float Price { get; set; }
        public int qantity { get; set; }
        public int clientID { get; set; }
        public Client client { get; set; }




    }
}
