using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {

        //Index Action - Tells ASP.NET Core to render the default view 
        //with an array of strings as its view model, which will be 
        //included with the HTML sent to the client. 
        public ViewResult Index()
        {
            /*
            //return View(new String[] { "C#", "Language", "Features"});

            List<string> results = new List<string>();

            //The GetProducts method defind by the Product class returns an array
            //of objects, to get a List of the name and Price values:

            foreach (Product p in Product.GetProducts())
            {
                //Null-checking using the Null-Coniditonal Operator


                //Null-operator is a single question mark ?
                //??  is a null coalescing operator to set a fallback value to prevent 
                //null values from being used in the application:
                string name = p?.Name ?? "<No Name>"; 

                //Variable name-type assigned to null
                decimal? price = p?.Price ?? 0; 

                //Null operator can be applied to each part of a chain of properties:
                string relatedName = p?.Related?.Name ?? "<None>";
                //Add values to results:
                results.Add(string.Format($"Name: {name}, Price: {price}, Related: {relatedName}");
            }

            //Return values to Razor View:
            return View(results);
            */
            /*
            string[] names = new string[3];
            names[0] = "Bob";
            names[1] = "Joe";
            names[2] = "Alice";
            return View("Index", names);
            */

            /*
            Dictionary<string, Product> products = new Dictionary<string, Product>
            {
                {"Kayak", new Product{ Name = "Kayak", Price = 275M} },
                {"Lifejacket", new Product{Name = "Lifejacket", Price = 48.95M} }
            };
            return View("Index", products.Keys);
            */

            /*
            Dictionary<string, Product> Products = new Dictionary<string, Product>
            {
                ["Kayak"] = new Product { Name = "Kayak", Price = 275M},
                ["Lifejacket"]  = new Product { Name = "Lifejacket", Price = 48.95M}
            };

            return View("Index", Products.Keys);
            */

            /*
             * Pattern Matching:
             */

            /*
            object[] data = new object[] {275M, 29.95M,
            "apple", "orange", 100, 10};
            decimal total = 0;
            for(int i = 0; i < data.Length; i++)
            {
                switch(data[i])
                {
                    case decimal decimalValue:
                        total += decimalValue;
                        break;
                    case int intValue when intValue > 50:
                        total += intValue;
                        break;
                }
            }
            return View("Index", new string[] { $"Total: {total:C2}" });
            */

            /*
            ShoppingCart cart
                = new ShoppingCart { Products = Product.GetProducts() };
            decimal cartTotal = cart.TotalPrices();
            return View("Index", new string[] {$"Total: {cartTotal:C2}"});
            */

            ShoppingCart cart =
                new ShoppingCart { Products = Product.GetProducts() };
            Product[] productArray =
            {
                new Product {Name = "Kayak", Price = 275M},
                new Product{Name = "Lifejacket", Price = 48.95M},
                new Product{Name = "Soccer Ball", Price = 19.50M},
                new Product{Name = "Corner Flag", Price = 34.95M}
            };

            decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices() ;

            return View("Index", new string[]
            {
                $"Array Total: {arrayTotal:C2}" 
            });

        }
    }
}
