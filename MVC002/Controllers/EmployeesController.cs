using Microsoft.AspNetCore.Mvc;
using MVC002.Models;

namespace MVC002.Controllers
{
    public class EmployeesController : Controller
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee{EmployeeID=1, FirstName="Ahmed", LastName="Mahmoud", Position="Manager", Salary=50000, HireDate=DateTime.Now.AddYears(-5), IsMarried = true},
            new Employee{EmployeeID=2, FirstName="Mazen", LastName="Ghanem", Position="Developer", Salary=60000, HireDate=DateTime.Now.AddYears(-3), IsMarried = true},
            new Employee{EmployeeID=3, FirstName="Ali", LastName="Mohamed", Position="Designer", Salary=55000, HireDate=DateTime.Now.AddYears(-2), IsMarried = false},
            new Employee{EmployeeID=4, FirstName="Rana", LastName="Nasser", Position="QA Engineer", Salary=50000, HireDate=DateTime.Now.AddYears(-1), IsMarried = true},
            new Employee{EmployeeID=5, FirstName="Salam", LastName="Ezzat", Position="Support Engineer", Salary=45000, HireDate=DateTime.Now.AddMonths(-6), IsMarried = false}
        };

        public IActionResult Index()
        {
            return View(employees);
        }
    }
}
