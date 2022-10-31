using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubCategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ISubCategoryService _subCategoryService;

        public SubCategoryController(ICategoryService categoryService, ISubCategoryService subCategoryService)
        {
            _categoryService = categoryService;
            _subCategoryService = subCategoryService;
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> Create()
        {
            var categories = _categoryService.GetAllCategories();
            return View(categories);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SubCategory subCategory, List<int> categoryIds)
        {
            _subCategoryService.AddSubCategory(subCategory, categoryIds);
            return RedirectToAction("Index");
        }



    }
}
