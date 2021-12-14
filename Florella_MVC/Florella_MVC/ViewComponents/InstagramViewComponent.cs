using Florella_MVC.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Florella_MVC.ViewComponents
{
    public class InstagramViewComponent : ViewComponent
    {
        AppDbContext _context;
        public InstagramViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var ig = _context.Instagram.ToList();
            return View(ig);
        }
    }
}
