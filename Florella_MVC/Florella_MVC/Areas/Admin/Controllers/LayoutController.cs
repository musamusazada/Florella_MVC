using Florella_MVC.DAL;
using Florella_MVC.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Florella_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LayoutController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public LayoutController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            var layouts = await _context.Layout.ToListAsync();

            return View(layouts);
        }
        public async Task<IActionResult> Detail(int id)
        {

            var layoutItem = await _context.Layout.FindAsync(id);

            if (layoutItem == null)
            {
                return NotFound();
            }


            return View(layoutItem);
        }


        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Layout layout)
        {

           

            if (!ModelState.IsValid)
            {
                return View(layout);
            }

            if (!layout.File.ContentType.Contains("image")) {
                ModelState.AddModelError(nameof(layout.File), "File type is not supported");
                return View(layout);
            }

            if(layout.File.Length > 1024 * 1000)
            {
                ModelState.AddModelError(nameof(layout.File), "Your file size is: " + layout.File.Length + " /n Please compress it!");
                return View(layout);
            }


            string fileName = Guid.NewGuid() + layout.File.FileName;
            string wwwRoot = _env.WebRootPath;

            var path = Path.Combine(wwwRoot, "img", fileName);
            FileStream fileStream = new FileStream(path, FileMode.Create);
            await layout.File.CopyToAsync(fileStream);
            fileStream.Close();

            await _context.Layout.AddAsync(layout);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {

            Layout layout = await _context.Layout.FindAsync(id);

            if (layout == null)
            {
                return NotFound();
            }

            return View(layout);

        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteCategory(int id)
        {

            Layout layout = await _context.Layout.FindAsync(id);

            if (layout == null)
            {
                return NotFound();
            }
            _context.Categories.Remove(layout);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
