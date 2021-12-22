using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Florella_MVC.Models
{
    public class Layout : BaseEntity
    {
        [Required]
        [MaxLength(30)]
        public string Slogan { get; set; }
        [MaxLength(60)]
        public string  facebook_url { get; set; }

        [MaxLength(60)]
        public string twitter_url { get; set; }

        public string image { get; set; }
        
        [NotMapped]
        public IFormFile File { get; set; }
    }
}
