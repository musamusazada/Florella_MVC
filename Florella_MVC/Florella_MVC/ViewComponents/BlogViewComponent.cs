using Florella_MVC.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Florella_MVC.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private AppDbContext _context;
        public BlogViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke() {
            var blogs = _context.Blogs.ToList();
            return View(blogs);
        }
    }
}
