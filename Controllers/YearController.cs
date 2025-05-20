using Microsoft.AspNetCore.Mvc;
using Pattern.Repositories;
using Pattern.ViewModels;

namespace Pattern.Controllers
{
    public class YearController(IYearLevelRepo _yearRepository) : Controller
    {
        public IActionResult Index()
        {
            var yearLevels = _yearRepository.GetAllYearLevels();
            var viewModel = new YearLevelViewModel
            {
                YearLevels = yearLevels
            };
            return View(yearLevels);
        }
        public IActionResult Create(YearLevelViewModel YVM)
        {

            return View();
        }

        public IActionResult Save(YearLevelViewModel YVM)
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
