using Business.Abstract;
using Core.Utilities.FileHelper;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebUI.Areas.Admin.ViewModels;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PictureController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IPictureService _pictureService;

        public PictureController(IWebHostEnvironment env, IPictureService pictureService)
        {
            _env = env;
            _pictureService = pictureService;
        }

        [HttpPost]
        public JsonResult Upload(List<IFormFile> Picture)
        {
            var pictureResult = _pictureService.AddPicture(Picture, _env.WebRootPath);
            return Json(pictureResult);
        }
    }
}
