using Florella_MVC.DAL;
using Florella_MVC.Models;
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
            var Products = _context.Products.Take(4).Include(p => p.category).ToList();
            return View(new ViewModelProduct {products = Products });
        }

        public PartialViewResult LoadMore() {

            var Products = _context.Products.Skip(4).Include(p => p.category).ToList();
            return PartialView("_ProductPartial",Products);
        }


        public async Task<IActionResult> Search(string searchedStr) {


            if (String.IsNullOrWhiteSpace(searchedStr))
            {
                return PartialView("_ProductSearchPartial", new List<Product>());
            }

            var products = await _context.Products.Where(i => i.name.ToLower().Contains(searchedStr.ToLower())).ToListAsync();

            return PartialView("_ProductSearchPartial",products);


        }
    }
}
