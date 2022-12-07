using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTemperatures.Test
{
    public class SubstractTemperatureUnitTest
    {
        [Fact(DisplayName = "should return 1 C if substract 2 C and 3 C")]
        public void SubstractCelsius()
        {
            var temp1 = new AppTemperature(3, TemperatureScale.Celsius);
            var temp2 = new AppTemperature(2, TemperatureScale.Celsius);

            Assert.Equal(temp1.Substract(temp2), new AppTemperature(1, TemperatureScale.Celsius));

        }

        [Fact(DisplayName = "should return -5C if substract 5C and 50F")]
        public void SubstractCelsius_Fahrenheit()
        {
            var temp1 = new AppTemperature(5, TemperatureScale.Celsius);
            var temp2 = new AppTemperature(50, TemperatureScale.Fahrenheit);

            Assert.Equal(temp1.Substract(temp2), new AppTemperature(-5, TemperatureScale.Celsius));

        }

        [Fact(DisplayName = "should return 9F if substract 50F and 5C")]
        public void SubstractFahrenheit_Celsius()
        {
            var temp1 = new AppTemperature(5, TemperatureScale.Celsius);
            var temp2 = new AppTemperature(50, TemperatureScale.Fahrenheit);

            Assert.Equal(temp2.Substract(temp1), new AppTemperature(9, TemperatureScale.Fahrenheit));

        }

        [Fact(DisplayName = "should return 11.85K if substract 300 K and 15C")]
        public void SubstractKelvin_Celsius()
        {
            var temp1 = new AppTemperature(15, TemperatureScale.Celsius);
            var temp2 = new AppTemperature(300, TemperatureScale.Kelvin);

            Assert.Equal(temp2.Substract(temp1), new AppTemperature(11.85, TemperatureScale.Kelvin));

        }

    }
}
