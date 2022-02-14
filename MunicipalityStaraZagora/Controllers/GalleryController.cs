using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MunicipalityStaraZagora.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MunicipalityStaraZagora.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IGalleryImagesService _imagesService;
        private readonly IWebHostEnvironment _enviroment;

        public GalleryController(IGalleryImagesService imagesService, IWebHostEnvironment enviroment)
        {
            _imagesService = imagesService ?? throw new ArgumentNullException(nameof(imagesService));
            _enviroment = enviroment ?? throw new ArgumentNullException(nameof(enviroment));
        }
        public async Task<IActionResult> Index()
        {       
            return View(await _imagesService.GetGalleryImages(_enviroment.WebRootPath));
        }
    }
}
