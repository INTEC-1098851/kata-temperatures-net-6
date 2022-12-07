using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTemperatures.Test
{
    public class AddTemperatureUnitTest
    {
        [Fact(DisplayName = "should return 5 C if add 2 C and 3 C")]
        public void AddCelsius()
        {
                var temp1 = new AppTemperature(3, TemperatureScale.Celsius);
                var temp2 = new AppTemperature(2, TemperatureScale.Celsius);

                Assert.Equal(temp1.Add(temp2), new AppTemperature(5, TemperatureScale.Celsius));

        }

        [Fact(DisplayName = "should return 15C if add 5C and 50F")]
        public void AddCelsius_Fahrenheit()
        {
            var temp1 = new AppTemperature(5, TemperatureScale.Celsius);
            var temp2 = new AppTemperature(50, TemperatureScale.Fahrenheit);

            Assert.Equal(temp1.Add(temp2), new AppTemperature(15, TemperatureScale.Celsius));

        }

        [Fact(DisplayName = "should return 91F if add 50F and 5C")]
        public void AddFahrenheit_Celsius()
        {
            var temp1 = new AppTemperature(5, TemperatureScale.Celsius);
            var temp2 = new AppTemperature(50, TemperatureScale.Fahrenheit);

            Assert.Equal(temp2.Add(temp1), new AppTemperature(91, TemperatureScale.Fahrenheit));

        }

        [Fact(DisplayName = "should return 91F if add 50F and 5C")]
        public void AddKelvin_Celsius()
        {
            var temp1 = new AppTemperature(1, TemperatureScale.Celsius);
            var temp2 = new AppTemperature(1, TemperatureScale.Kelvin);

            Assert.Equal(temp2.Add(temp1), new AppTemperature(275.15, TemperatureScale.Kelvin));

        }

    }
}
