using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Florella_MVC.DAL
{
    public static class DataSeeder
    {
        public static IApplicationBuilder Seed(this IApplicationBuilder builder)
        {
            using(var scope = builder.ApplicationServices.CreateScope())
            {
                var _context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                DataInitializer datainitializer = new DataInitializer(_context);
                datainitializer.DataSeed();

            }

            return builder;
        }
    }
}
