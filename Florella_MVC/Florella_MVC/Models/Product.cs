using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Florella_MVC.Models
{
    public class Product : BaseEntity
    {
        public string name { get; set; }
        public string image { get; set; }
        public double price { get; set; }
        public int CategoryId { get; set; }
        public Category category { get; set; }
    }
}
