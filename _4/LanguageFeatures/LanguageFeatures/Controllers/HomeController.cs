using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        //public ViewResult Index()
        public async Task<ViewResult> Index()
        {
            /* STRINGS */
            //List<string> results = new List<string>();
            //foreach (Product p in Product.GetProducts())
            //{
            //    string name = p?.Name ?? "<NoName>";
            //    decimal? price = p?.Price ?? 0;
            //    string relatedName = p?.Related?.Name ?? "<None>";
            //    //results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}", name, price, relatedName));
            //    results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
            //}
            //return View(results);

            /* DICTIONARIES */
            //Dictionary<string, Product> products = new Dictionary<string, Product>
            //{
            //    {"Kayak", new Product{Name = "Kayak", Price = 275M} },
            //    {"Lifejacket", new Product{Name = "Lifejacket", Price = 48.95M} }
            //};

            //Dictionary<string, Product> products = new Dictionary<string, Product>
            //{
            //    ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
            //    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
            //};
            //return View("Index", products.Keys);

            /* EXTENSION METHODS */
            //ShoppingCart cart = new ShoppingCart
            //{
            //    Products = Product.GetProducts()
            //};
            //decimal cartTotal = cart.TotalPrices();
            //return View("Index", new string[] { $"Total: {cartTotal:C2}" });

            /* TYPES */
            //var products = new[]
            //{
            //    new {Name = "Kayak", Price = 275M},
            //    new {Name = "Lifejacket", Price = 48.95M},
            //    new {Name = "Soccer ball", Price = 34.95M},
            //    new {Name = "Corner flag", Price = 34.95M}
            //};
            //return View(products.Select(p => p.Name));

            /* ASYNC */
            long? length = await MyAsyncMethods.GetPageLength();
            return View(new string[] { $"Length: {length}" });
        }
    }
}
