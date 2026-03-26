using Microsoft.AspNetCore.Mvc;

namespace DoAnCS.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
