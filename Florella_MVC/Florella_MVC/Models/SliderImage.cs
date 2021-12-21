using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Florella_MVC.Models
{
    public class SliderImage : BaseEntity
    {
        public string Image { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }
    }
}
