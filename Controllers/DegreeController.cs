using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pattern.Models;
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
            return View(viewModel);
        }
        public IActionResult Create(DegreeProgramViewModel DVM)
        {
            return View();
        }
        public IActionResult Save(DegreeProgramViewModel DVM) {
            var degree = new DegreeProgram
            {
                DegreeProgramTitle = DVM.DegreeProgramTitle,
                IsActive = true,

            };
            _degreeRepository.AddDegreeProgram(degree);
            return RedirectToAction("Index");
        }
        public IActionResult Update(DegreeProgramViewModel DVM)
        {
            var degree = new DegreeProgram
            {
                DegreeProgramTitle = DVM.DegreeProgramTitle,
                IsActive = true,

            };
            _degreeRepository.UpdateDegreeProgram(degree);
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
