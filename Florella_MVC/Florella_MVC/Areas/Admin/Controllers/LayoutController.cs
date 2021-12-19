using Florella_MVC.DAL;
using Florella_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Florella_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LayoutController : Controller
    {

        private readonly AppDbContext _context;

        public LayoutController(AppDbContext context)
        {
            _context = context;
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
                return View();
            }
            await _context.Layout.AddAsync(layout);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
