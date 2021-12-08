using Florella_MVC.DAL;
using Florella_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Florella_MVC.Controllers
{
    public class ProductController : Controller
    {
        public AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(new ViewModelProduct {products = _context.Products.Include(p=>p.category).ToList() });
        }
    }
}
