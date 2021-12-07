using Florella_MVC.DAL;
using Florella_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Florella_MVC.ViewModels;
using System.Linq;

namespace Florella_MVC.Controllers
{
    public class HomeController : Controller
    {
        public AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View(new ViewModelCard { cardimages = _context.CardImages.ToList() ,cardText = _context.CardTexts.ToList(),listItems=_context.CardLists.ToList(), categoryList = _context.Categories.ToList(), productList = _context.Products.ToList(), forms = _context.Forms.ToList()});
        }
       

    }
}
