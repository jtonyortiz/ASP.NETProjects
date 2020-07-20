using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        /*
         
        public static decimal TotalPrices(this ShoppingCart cartParam)
        {
            decimal total = 0;
            foreach(Product prod in cartParam.Products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }

        */

        //New Function works directly with the Product class and product objects
        //as done by the for-each loop:

        public static decimal TotalPrices(this IEnumerable<Product> products)
        {
            decimal total = 0;
            foreach(Product prod in products)
            {
                total += prod?.Price ?? 0;
            }

            return total;
        }

        //Filtering Collections of Objects:
        /*
        public static IEnumerable<Product> FilterByPrice(
            this IEnumerable<Product> productEnum, decimal minimumPrice)
        {
            foreach(Product prod in productEnum)
            {
                if((prod?.Price ?? 0) >= minimumPrice)
                {
                    yield return prod; // prod - apply selection criteria to product a reduced set of results:
                }
            }
        }

        public static IEnumerable<Product> FilterByName(
            this IEnumerable<Product> productEnum, char 
            firstLetter)
        {
            foreach (Product prod in productEnum)
            {
                if(prod?.Name?[0] == firstLetter)
                {
                    yield return prod;
                }
            }
        }
        */

        public static IEnumerable<Product> Filter(
            this IEnumerable<Product> productEnum,
            Func<Product, bool> selector)
        {
            foreach(Product prod in productEnum)
            {
                if(selector(prod))
                {
                    yield return prod;
                }
            }
        }
    }
}
