using Microsoft.AspNetCore.Mvc;
using Pattern.Repositories;
using Pattern.ViewModels;

namespace Pattern.Controllers
{
    public class DegreeController(IDegreeProgramRepo _degreeRepository) : Controller
    {
        public IActionResult Index()
        {
            var degreePrograms = _degreeRepository.GetAllDegreePrograms();
            var viewModel = new DegreeProgramViewModel
            {
                DegreePrograms = degreePrograms
            };
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Save() {

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            return View(id);
        }
               
        public IActionResult Delete(int id)
        {
            return View(id);
        }
    }
}
