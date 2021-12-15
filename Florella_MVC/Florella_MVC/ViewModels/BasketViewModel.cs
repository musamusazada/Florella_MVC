using Florella_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Florella_MVC.ViewModels
{
    public class BasketViewModel 
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public double price { get; set; }
        public int CategoryId { get; set; }
        public Category category { get; set; }
        public int count { get; set; }
    }
}
