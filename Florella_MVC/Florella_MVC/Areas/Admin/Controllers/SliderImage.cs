using Florella_MVC.DAL;
using Florella_MVC.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Florella_MVC.Areas.Admin.Controllers
{
    public class SliderImageController : Controller
    {
        private readonly AppDbContext _context;

        private readonly IWebHostEnvironment _env;

        public SliderImageController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SliderImage sliderimage) {

            if (sliderimage == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(sliderimage);
            }

            if (sliderimage.File.ContentType.Contains("image"))
            {
                ModelState.AddModelError(nameof(File), "file type not supported");
                return View(sliderimage);

            }

            if (sliderimage.File.Length > 1024 * 1000)
            {
                ModelState.AddModelError(nameof(File), "file too big");
                return View(sliderimage);
            }


            string filePath = sliderimage.File.FileName;
            string wwwroot = _env.WebRootPath;

            var path = Path.Combine(wwwroot, "img", filePath);

            FileStream stream = new FileStream(path,FileMode.Create);
            await sliderimage.File.CopyToAsync(stream);
            stream.Close();

            sliderimage.Image = filePath;

            await _context.SliderImage.AddAsync(sliderimage);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }
    }
}
