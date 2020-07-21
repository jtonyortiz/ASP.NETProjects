using Microsoft.AspNetCore.Mvc;
using SimpleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.Controllers
{
    //Inherit HomeController from Controller
    public class HomeController: Controller
    {


        /*
        The Index action method tells ASP.NET Core to render the default view and provides
            it with the Product objects obtained from the static Product.GetProducts method
        */

        public IDataSource dataSource = new ProductDataSource();


        public ViewResult Index()
        {
            //return View(Product.GetProducts());

            return View(dataSource.Products);
        }
    }
}
