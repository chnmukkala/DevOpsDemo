using System;
using Xunit;
using DevOpsDemo.Controllers;
using System.Linq;

namespace DevOpsDemoTest
{
    public class UnitTest1
    {
        [Fact]
        public void ThisWillPass()
        {
            var wfc = new WeatherForecastController();
            var wS = wfc.Get();

            Assert.Equal(5, wS.Count());
        }

        [Fact]
        public void ThisWillFail()
        {
            var wfc = new WeatherForecastController();
            var wS = wfc.Get();

            Assert.Equal(2, wS.Count());
        }
    }
}
