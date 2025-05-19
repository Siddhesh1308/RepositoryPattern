using Microsoft.AspNetCore.Mvc;
using Pattern.Repositories;

namespace Pattern.Controllers
{
    public class YearController(IYearLevelRepo _yearRepository) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Save()
        {

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}
