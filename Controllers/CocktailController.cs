using Microsoft.AspNetCore.Mvc;

namespace mvcassignment.Controllers
{
    public class CocktailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult OrderQueue()
        {
            return View();
        }
    }
}