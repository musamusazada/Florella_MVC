using Florella_MVC.Models;
using System.Collections.Generic;

namespace Florella_MVC.ViewModels
{
    public class ViewModelCard
    {
        public List<CardImage> cardimages { get; set; }
        public List<CardText> cardText { get; set; }
        public List<CardList> listItems { get; set; }
        public List<Category> categoryList { get; set; }

        public List<Product> productList { get; set; }
        public List<Form> forms { get; set; }



    }
}
