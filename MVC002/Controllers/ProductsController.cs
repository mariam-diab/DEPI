using Microsoft.AspNetCore.Mvc;
using MVC002.Models;

namespace MVC002.Controllers
{
    public class ProductsController : Controller
    {
        List<Product> products = new List<Product>
        {
            new Product{ProductID=101, ProductName="Coffee", Price=300,
            ProductionDate = DateTime.Now, Stock = 100, IsActive = true},
            new Product{ProductID=102, ProductName="Tea", Price=150,
            ProductionDate = DateTime.Now, Stock = 200, IsActive = true},
            new Product{ProductID=103, ProductName="Milk", Price=50,
            ProductionDate = DateTime.Now, Stock = 300, IsActive = true},
            new Product{ProductID=104, ProductName="Juice", Price=120,
            ProductionDate = DateTime.Now, Stock = 150, IsActive = true},
            new Product{ProductID=105, ProductName="Bread", Price=20,
            ProductionDate = DateTime.Now, Stock = 500, IsActive = true},
            new Product{ProductID=106, ProductName="Butter", Price=60,
            ProductionDate = DateTime.Now, Stock = 250, IsActive = true},
            new Product{ProductID=107, ProductName="Cheese", Price=80,
            ProductionDate = DateTime.Now, Stock = 220, IsActive = true},
            new Product{ProductID=108, ProductName="Eggs", Price=40,
            ProductionDate = DateTime.Now, Stock = 180, IsActive = true},
            new Product{ProductID=109, ProductName="Pasta", Price=30,
            ProductionDate = DateTime.Now, Stock = 330, IsActive = true},
            new Product{ProductID=110, ProductName="Rice", Price=90,
            ProductionDate = DateTime.Now, Stock = 400, IsActive = true}
        };

        public IActionResult Index()
        {
            
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
