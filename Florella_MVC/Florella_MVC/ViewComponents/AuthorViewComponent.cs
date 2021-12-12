using Florella_MVC.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Florella_MVC.ViewComponents
{
    public class AuthorViewComponent : ViewComponent
    {
        private AppDbContext _context;

        public AuthorViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke() {
            var authors = _context.Authors.ToList();
            return View(authors);
        }
    }
}
