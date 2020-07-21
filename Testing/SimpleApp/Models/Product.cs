using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
    }

    public class ProductDataSource: IDataSource
    {
        public IEnumerable<Product> Products =>
            new Product[]
            {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M}
            };
    }
}
