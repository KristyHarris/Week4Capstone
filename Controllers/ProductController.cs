using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Week4Capstone.Data;
using Week4Capstone.Models;

namespace Week4Capstone.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductContext _dbContext;
        private readonly ISession _session;

        public ProductController(ProductContext dbContext, IHttpContextAccessor accessor)
        {
            _dbContext = dbContext;
            _session = accessor.HttpContext.Session;
        }
        
        public IActionResult Index()
        {
            var products = _dbContext.Products.ToList();
            return View(products);
        }

        public IActionResult AddToCart(int? id)
        {
            List<Product> list;
            if (_session.Keys.Any(x => x == "Cart"))
            {
                list = JsonConvert.DeserializeObject<List<Product>>(_session.GetString("Cart"));
            }
            else
            {
                list = new List<Product>();
            }
            var product = _dbContext.Products.Find(id);
            list.Add(product);
            _session.SetString("Cart", JsonConvert.SerializeObject(list));

            return RedirectToAction("Index");
        }

        public IActionResult Checkout()
        {
            List<Product> list;
            if (_session.Keys.Any(x => x == "Cart"))
            {
                list = JsonConvert.DeserializeObject<List<Product>>(_session.GetString("Cart"));
                _session.SetString("Cart", JsonConvert.SerializeObject(list));
            }
            else
            {
                list = new List<Product>();
            }

            for (int i = 0; i < list.Count; i++)
            {
                ViewBag.Total = list.Sum(i => i.Price);
              
            }

            return View(list);

        }
           
            
        
    }
}