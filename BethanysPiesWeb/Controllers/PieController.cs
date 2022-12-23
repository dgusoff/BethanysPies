using BethanysPiesWeb.Models;
using BethanysPiesWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPiesWeb.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;
        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;       
        }

        public IActionResult List()
        {
            PieListViewModel viewModel = new PieListViewModel(_pieRepository.AllPies, "All Pies");           
            return View(viewModel);
        }
    }
}
