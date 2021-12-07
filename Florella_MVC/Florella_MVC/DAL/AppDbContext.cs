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
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Profiles> Profiles { get; set; }

        public DbSet<Experts> Experts { get; set; }

        public DbSet<Position> Positions { get; set; }




    }
}
