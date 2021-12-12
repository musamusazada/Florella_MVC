using System;
using System.ComponentModel.DataAnnotations;

namespace Florella_MVC.Models
{
    public class Blog : BaseEntity
    {
        public string image { get; set; }

        [DisplayFormat( DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime? date { get; set; }
        public string title { get; set; }

        public string  article { get; set; }
    }
}
