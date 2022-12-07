using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTemperatures.Test
{
    public class DivideTemperatureByUnitTest
    {
        [Fact(DisplayName = "should return 1.5 C if divide 2 C by 3 C")]
        public void DivideByCelsius()
        {
            var temp1 = new AppTemperature(3, TemperatureScale.Celsius);
            var temp2 = new AppTemperature(2, TemperatureScale.Celsius);

            Assert.Equal(temp1.DivideBy(temp2), new AppTemperature(1.5, TemperatureScale.Celsius));

        }

        [Fact(DisplayName = "should return 0.5C if divide 5C by 50F")]
        public void DivideByCelsius_Fahrenheit()
        {
            var temp1 = new AppTemperature(5, TemperatureScale.Celsius);
            var temp2 = new AppTemperature(50, TemperatureScale.Fahrenheit);

            Assert.Equal(temp1.DivideBy(temp2), new AppTemperature(0.5, TemperatureScale.Celsius));

        }

        [Fact(DisplayName = "should return 0.05 F if divide 2 F by 5 C")]
        public void DivideByFahrenheit_Celsius()
        {
            var temp1 = new AppTemperature(5, TemperatureScale.Celsius);
            var temp2 = new AppTemperature(2, TemperatureScale.Fahrenheit);

            Assert.Equal(temp2.DivideBy(temp1), new AppTemperature(0.05, TemperatureScale.Fahrenheit));

        }

        [Fact(DisplayName = "should return 1 K if divide 1 K by -272.15 C")]
        public void DivideByKelvin_Celsius()
        {
            var temp1 = new AppTemperature(-272.15, TemperatureScale.Celsius);
            var temp2 = new AppTemperature(1, TemperatureScale.Kelvin);

            Assert.Equal(temp2.DivideBy(temp1), new AppTemperature(1, TemperatureScale.Kelvin));

        }
    }
}
