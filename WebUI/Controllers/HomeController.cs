using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using WebUI.ViewModels;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        public HomeController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        public IActionResult Index()
        {
            var categories = _categoryService.GetAllCategories();
            var popularProducts = _productService.GetAllPopularProducts();
            var recentProducts = _productService.GetAllRecentProducts();
            HomeVM homeVM = new()
            {
                Categories = categories,
                PopularProducts = popularProducts,
                RecentProducts = recentProducts
            };
            return View(homeVM);
        }
    }
}
