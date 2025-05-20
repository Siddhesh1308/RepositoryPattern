using Microsoft.AspNetCore.Mvc;
using Pattern.Models;
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
            return View(viewModel);
        }
        public IActionResult Create(YearLevelViewModel YVM)
        {

            return View();
        }

        public IActionResult Save(YearLevelViewModel YVM)
        {
            var years = new YearLevel
            {
                YearLevelTitle = YVM.YearLevelTitle,
                IsActive = true,

            };
            _yearRepository.AddYearLevel(years);
            return RedirectToAction("Index");
        }

        public IActionResult Update(YearLevelViewModel YVM)
        {
            var years = new YearLevel
            {
                YearLevelId = YVM.YearLevelId,
                YearLevelTitle = YVM.YearLevelTitle,
                IsActive = true,
            };
            _yearRepository.UpdateYearLevel(years);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {

            var year = _yearRepository.GetYearLevelById(id);
            if (year == null)
            {
                return NotFound();
            }
            var viewModel = new YearLevelViewModel
            {
                YearLevelId = year.YearLevelId,
                YearLevelTitle = year.YearLevelTitle,
                IsActive = true
            };
            return View(viewModel);
        }

        public IActionResult Delete(int id)
        {
            var result = _yearRepository.GetYearLevelById(id);
            if (result == null)
            {
                return NotFound();
            }
            var _years = new YearLevel
            {
                YearLevelId = result.YearLevelId,
                YearLevelTitle = result.YearLevelTitle,
                IsActive = false,
            };
            _yearRepository.UpdateYearLevel(_years);
            return RedirectToAction("Index");
        }
    }
}
