namespace Florella_MVC.Models
{
    public class Profiles :BaseEntity
    {
        public string image { get; set; }
        public string fullName { get; set; }
        public Position position { get; set; }

    }
}
