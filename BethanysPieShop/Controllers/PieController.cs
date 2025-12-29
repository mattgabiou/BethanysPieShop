using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            // Constructor Injection
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List() // Action Method
        {
            //ViewBag.CurrentCategory = "Cheese cakes";
            //return View(_pierepository.AllPies);

            PieListViewModel pieListViewModel = new PieListViewModel
                (_pieRepository.AllPies, "Cheese cakes");
            return View(pieListViewModel);
        }
    }
}
