using System.Collections.Generic;

namespace Florella_MVC.Models
{
    public class Position : BaseEntity
    {
        public string Name { get; set; }
        public List<Profiles> profiles { get; set; }
    }
}
