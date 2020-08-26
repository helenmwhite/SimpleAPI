using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController(null);

        [Fact]
        public void Get5ReturnsTextAnd5()
        {
            var returnValue = controller.Get(5);
            Assert.Equal("The temperature is 5°F", returnValue);
        }

        [Fact]
        public void Test1()
        {
 
        }
    }
}
