using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTemperatures.Test
{
    public class MultiplyTemperatureByUnitTest
    {
        [Fact(DisplayName = "should return 6 C if multiply 2 C by 3 C")]
        public void MultiplyByCelsius()
        {
            var temp1 = new AppTemperature(3, TemperatureScale.Celsius);
            var temp2 = new AppTemperature(2, TemperatureScale.Celsius);

            Assert.Equal(temp1.MultiplyBy(temp2), new AppTemperature(6, TemperatureScale.Celsius));

        }

        [Fact(DisplayName = "should return -50C if multiply 5C by 50F")]
        public void MultiplyByCelsius_Fahrenheit()
        {
            var temp1 = new AppTemperature(5, TemperatureScale.Celsius);
            var temp2 = new AppTemperature(50, TemperatureScale.Fahrenheit);

            Assert.Equal(temp1.MultiplyBy(temp2), new AppTemperature(50, TemperatureScale.Celsius));

        }

        [Fact(DisplayName = "should return 82 F if multiply 2 F by 5 C")]
        public void MultiplyByFahrenheit_Celsius()
        {
            var temp1 = new AppTemperature(5, TemperatureScale.Celsius);
            var temp2 = new AppTemperature(2, TemperatureScale.Fahrenheit);

            Assert.Equal(temp2.MultiplyBy(temp1), new AppTemperature(82, TemperatureScale.Fahrenheit));

        }

        [Fact(DisplayName = "should return 274.15 K if multiply 1 K by 1 C")]
        public void MultiplyByKelvin_Celsius()
        {
            var temp1 = new AppTemperature(1, TemperatureScale.Celsius);
            var temp2 = new AppTemperature(1, TemperatureScale.Kelvin);

            Assert.Equal(temp2.MultiplyBy(temp1), new AppTemperature(274.15, TemperatureScale.Kelvin));

        }
    }
}
