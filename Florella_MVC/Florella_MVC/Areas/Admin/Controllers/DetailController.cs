using Florella_MVC.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Florella_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DetailController : Controller
    {
        private readonly AppDbContext _context;

        public DetailController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int id)
        {

            var categoryItem = await _context.Categories.FindAsync(id);

            if (categoryItem == null) {
                return NotFound();
            }


            return View(categoryItem);
        }
    }
}
