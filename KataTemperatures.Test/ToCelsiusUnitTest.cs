using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTemperatures.Test
{
    public class ToCelsiusUnitTest
    {
        [Fact(DisplayName = "Should return the same value if is Celsius")]
        public void Test_ToCelsius_FromCelsius()
        {
                var temp = new AppTemperature(3.48, TemperatureScale.Celsius);
                Assert.Equal(temp.ToCelsius(), new AppTemperature(3.48, TemperatureScale.Celsius));
        }

        [Fact(DisplayName = "should return -15.84 F if receive -26.58 C ")]
        public void Test_ToCelsius_FromFahrenheit()
        {

            var temp = new AppTemperature(-15.84, TemperatureScale.Fahrenheit);
            Assert.Equal(temp.ToCelsius(), new AppTemperature(-26.58, TemperatureScale.Celsius));
        }

        [Fact(DisplayName = "should return -272.15 C if receive 1 K")]
        public void Test_ToCelsius_FromKelvin()
        {

            var temp = new AppTemperature(1, TemperatureScale.Kelvin);
            Assert.Equal(temp.ToCelsius(), new AppTemperature(-272.15, TemperatureScale.Celsius));
        }
    }
}
