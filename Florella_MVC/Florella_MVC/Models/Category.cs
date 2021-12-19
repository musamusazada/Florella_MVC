using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Florella_MVC.Models
{
    public class Category : BaseEntity
    {
        public string name { get; set; }
        public List<Product> products { get; set; }
    }

  
}
