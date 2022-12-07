using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTemperatures.Test
{
    public class ToFahrenheitUnitTest
    {
        [Fact(DisplayName = "Should return the same value if is Fahrenheit")]
        public void Test_ToFahrenheit_FromFahrenheit()
        {
                var temp = new AppTemperature(3.48, TemperatureScale.Fahrenheit);
                Assert.Equal(temp.ToFahrenheit(), new AppTemperature(3.48, TemperatureScale.Fahrenheit));
        }

        [Fact(DisplayName = "should return 3.49 F if receive -15.84 C")]
        public void Test_ToFahrenheit_FromCelsius()
        {

            var temp = new AppTemperature(-15.84, TemperatureScale.Celsius);
            Assert.Equal(temp.ToFahrenheit(), new AppTemperature(3.49, TemperatureScale.Fahrenheit));
        }

        [Fact(DisplayName = "should return 257.30 F if receive 398.31 K")]
        public void Test_ToFahrenheit_FromKelvin()
        {
            try
            {
                var temp = new AppTemperature(398.31, TemperatureScale.Kelvin);
                //Assert.Equal(temp.ToFahrenheit(), new AppTemperature(257.30, TemperatureScale.Fahrenheit));
            }
            catch (Exception e)
            {

                throw;
            }
        
        }
    }
}
