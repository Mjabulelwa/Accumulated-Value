
using AccumulatedValue.Models;
using Microsoft.AspNetCore.Mvc;

namespace AccumulatedValue.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Name = "Mjabulelwa";
            ViewBag.AV = 99999.99;
            return View();
        }
        [HttpPost]
        public IActionResult Index(AccumulatedValueModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.AV = model.CalculateAccumulatedValue();
            }
            else
            {
                ViewBag.AV = 0;
            }
            return View(model);
        }
    }
}
