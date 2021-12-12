namespace Florella_MVC.Models
{
    public class Author : BaseEntity
    {
        public string image { get; set; }
        public string fullName { get; set; }
        public string quote { get; set; }
        public string jobTitle { get; set; }
    }
}
