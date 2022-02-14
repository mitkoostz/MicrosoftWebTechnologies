using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MunicipalityStaraZagora.Interfaces;
using System;
using System.Threading.Tasks;

namespace MunicipalityStaraZagora.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsService _newsService;
        private readonly IWebHostEnvironment _enviroment;

        public NewsController(INewsService newsService, IWebHostEnvironment enviroment)
        {
            _newsService = newsService ?? throw new ArgumentNullException(nameof(newsService));
            _enviroment = enviroment ?? throw new ArgumentNullException(nameof(enviroment));
        }
        public async Task<IActionResult> Index()
        {
            return View(await _newsService.GetNewsData(_enviroment.WebRootPath));
        }
    }
}
