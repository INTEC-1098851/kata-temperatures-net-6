using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTemperatures.Test
{
    public class ToKelvinUnitTest
    {
        [Fact(DisplayName = "Should return the same value if is Kelvin")]
        public void Test_ToKelvin_FromKelvin()
        {
            try
            {
                var temp = new AppTemperature(3.48, TemperatureScale.Kelvin);
                Assert.Equal(temp.ToKelvin(), new AppTemperature(3.48, TemperatureScale.Kelvin));
            }
            catch (Exception e)
            {

                throw;
            }


        }

        [Fact(DisplayName = "should return 246.57 K if receive -15.84 F")]
        public void Test_ToKelvin_FromFahrenheit()
        {

            var temp = new AppTemperature(-15.84, TemperatureScale.Fahrenheit);
            Assert.Equal(temp.ToKelvin(), new AppTemperature(246.57, TemperatureScale.Kelvin));
        }

        [Fact(DisplayName = "should return 530.45 K if receive 257.30 C")]
        public void Test_ToKelvin_FromCelsius()
        {

            var temp = new AppTemperature(257.30, TemperatureScale.Celsius);
            Assert.Equal(temp.ToKelvin(), new AppTemperature(530.45, TemperatureScale.Kelvin));
        }
    }
}
