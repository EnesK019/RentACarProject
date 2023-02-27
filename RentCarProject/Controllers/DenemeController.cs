using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class DenemeController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public DenemeController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(int a)
        {
            var files = Request.Form.Files;
            var file = files?.FirstOrDefault();
            string uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "resimler");
            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }

            await using FileStream fileStream = new($"{uploadPath}/{file.FileName}", FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024, useAsync: false);
            await file.CopyToAsync(fileStream);
            await fileStream.FlushAsync();

            return View();
        }

        [HttpGet]
        public IActionResult Image()
        {
            Byte[] b;
            string filename = "110000024747556.jpg";
            b = System.IO.File.ReadAllBytes($"{_webHostEnvironment.WebRootPath}/resimler/{filename}");
            return File(b, "image/jpeg");
        }
    }
}
