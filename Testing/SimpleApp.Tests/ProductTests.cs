using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SimpleApp.Models;

namespace SimpleApp.Tests
{
    public class ProductTests
    {
        /* NOTE:
         * The Fact attribute is applied to each method to indicate that
         * it is a test. Within the method body, a unit test follows a pattern
         * called arrange, act, assert (A/A/A). Arrange refers to setting up
         * the conditions for the test, act refers to performing the test, and assert refers to 
         * verifying that the result was the one that was expected.
         */
        [Fact]
        public void CanChangeProductName()
        {
            //Arrange 
            var p = new Product { Name = "Test", Price = 100M };

            //Act
            p.Name = "New Name";

            //Assert
            Assert.Equal("New Name", p.Name);
        }

        [Fact]
        public void CanChangeProductPrice()
        {
            //Arrange 
            var p = new Product { Name = "Test", Price = 100M };

            //Act 
            p.Price = 200M;

            //Assert
            Assert.Equal(200M, p.Price);
        }

    }
}
