using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pierepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            // Constructor Injection
            _pierepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List() // Action Method
        {
            ViewBag.CurrentCategory = "Cheese cakes";
            return View(_pierepository.AllPies);
        }
    }
}
