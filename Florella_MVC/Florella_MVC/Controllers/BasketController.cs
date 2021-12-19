using Florella_MVC.DAL;
using Florella_MVC.Models;
using Florella_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Florella_MVC.Controllers
{
    public class BasketController : Controller
    {
        private readonly AppDbContext _context;

        public BasketController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> AddToBasket(int id)
        {
            Product product = await _context.Products.FindAsync(id);

            List<BasketViewModel> basket;

            var basketJson = Request.Cookies["Basket"];
            if (String.IsNullOrEmpty(basketJson))
            {
                basket = new List<BasketViewModel>();

            }
            else {
                basket = JsonConvert.DeserializeObject<List<BasketViewModel>>(basketJson);
            }

            var existProduct = basket.Find(p => p.id == id);

            if (existProduct == null)
            {
                BasketViewModel proBVM = new BasketViewModel();

                proBVM.id = product.Id;
                proBVM.image = product.image;
                proBVM.name = product.name;
                proBVM.price = product.price;
                proBVM.CategoryId = product.CategoryId;
                proBVM.category = product.category;

                basket.Add(proBVM);
            }
            else {
                existProduct.count++;
            }

            basketJson = JsonConvert.SerializeObject(basket);
            Response.Cookies.Append("Basket", basketJson);

            return Json(basketJson);
        }

        public   IActionResult GetBasket()
        {
            var basket = JsonConvert.DeserializeObject<List<BasketViewModel>>(Request.Cookies["basket"]);
            return PartialView("_BasketPartial", basket);
            
        }
    }
}
