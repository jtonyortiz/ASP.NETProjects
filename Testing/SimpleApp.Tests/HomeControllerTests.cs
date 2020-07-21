using SimpleApp.Controllers;
using SimpleApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;

namespace SimpleApp.Tests
{
    public class HomeControllerTests{

        /*
        class FakeDataSource: IDataSource
        {
            public FakeDataSource(Product[] data) => Products = data;
            public IEnumerable<Product> Products { get; set; }
        }
        */




   
    [Fact]
    public void InexActionModelIsComplete()
        {
            //Arrange:
            /*var controller = new HomeController();
            Product[] products = new Product[]
            {
                new Product { Name = "Kayak", Price = 275M },  
                new Product { Name = "Lifejacket", Price = 48.95M }
            };
            */

            Product[] testData = new Product[]
            {
                new Product{Name = "P1", Price = 75.10M},
                new Product{Name = "P2", Price = 120M},
                new Product{Name = "P3", Price = 110M}
            };
            //IDataSource data = new FakeDataSource(testData);

            var mock = new Mock<IDataSource>();
            mock.SetupGet(m => m.Products).Returns(testData);
            var controller = new HomeController();
            //controller.dataSource = data;
            controller.dataSource = mock.Object;

            //Act:
            var Model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Product>;

            //Assert:
            Assert.Equal(testData, Model,
                Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name
                && p1.Price == p2.Price));

            mock.VerifyGet(m => m.Products, Times.Once);
        }  
    
    }
}
