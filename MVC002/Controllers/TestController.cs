using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace MCV002.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult Second()
        {
            return View("MyView");
        }

        public ContentResult MyContent()
        {
            return Content("THIS CONTENT CREATED BY ACTION");
        }

        public ContentResult MyContent2()
        {
            return Content("<h1>HTML CONTENT</h1>", "text/html");
        }

        public ContentResult MyContent3()
        {
            return Content("<h1>أهلًا بكم!</h1>", "text/html", Encoding.UTF8);
        }
        public FileResult MyFile()
        {
            return File("programming.gif", "image/gif");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(string firstName, string lastName, string email, IFormFile profilePicture, string gender)
        {
            return RedirectToAction("Index");
        }

        public JsonResult MyJson()
        {
            string[] courses = { "SQL", "C#", "HTML" };
            return Json(courses.ToList());
        }

    }
}
