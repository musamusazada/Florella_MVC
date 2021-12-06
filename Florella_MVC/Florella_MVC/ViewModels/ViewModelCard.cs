using Florella_MVC.Models;
using System.Collections.Generic;

namespace Florella_MVC.ViewModels
{
    public class ViewModelCard
    {
        public List<CardImage> cardimages { get; set; }
        public List<CardText> cardText { get; set; }
        public List<CardList> listItems { get; set; }

    }
}
