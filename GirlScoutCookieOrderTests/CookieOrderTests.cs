
using System;
using Xunit;

namespace GirlScoutCookieOrder.Tests
{
    public class CookieOrderTests
    {
        [Fact]
        public void AddCookiesToYourOrder()
        {
            //Arrange
            var cookie = new CookieOrder();

            //Act
            cookie.AddToOrder();

            //Assert

        }
        
    }
}
