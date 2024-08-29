using Microsoft.AspNetCore.Mvc;

namespace MVC001.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ContentResult MyContent()
        {
            return Content("<h1>WELCOME TO MVC!<h1/>", "text/html");
        }

        public JsonResult MyJson() 
        {
            string[] names = { "Ahmed", "Ali", "Sayed" };
            return Json(names);
        }
        //public IActionResult()
        //{
        //    return NotFound();
        //}
    }
}
