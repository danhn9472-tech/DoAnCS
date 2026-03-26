using DoAnCS.Data; // thêm dòng này
using Microsoft.AspNetCore.Mvc;
using DoAnCS.Models;

namespace DoAnCS.Controllers
{
    public class TipController : Controller
    {
        public IActionResult Index()
        {
            return View(FData.Tips);
        }

        // DETAILS
        public IActionResult Details(int id)
        {
            var tip = FData.Tips.FirstOrDefault(t => t.Id == id);
            return View(tip);
        }

        // CREATE
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Tip tip)
        {
            tip.Id = FData.Tips.Count + 1;
            tip.CreatedAt = DateTime.Now;

            FData.Tips.Add(tip);
            return RedirectToAction("Index");
        }

    }
}
