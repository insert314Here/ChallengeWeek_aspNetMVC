using Microsoft.AspNetCore.Mvc;

namespace TemplateInheritance.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
