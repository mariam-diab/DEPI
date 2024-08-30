namespace MVC002.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public DateTime ProductionDate { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }
    }
}
