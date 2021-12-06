using Florella_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Florella_MVC.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<CardImage> CardImages { get; set; }
        public DbSet<CardList> CardLists { get; set; }
        public DbSet<CardText> CardTexts { get; set; }
    }
}
