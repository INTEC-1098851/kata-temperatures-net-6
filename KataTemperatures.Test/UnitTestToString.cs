namespace KataTemperatures.Test
{
    public class UnitTestToString
    {
        [Fact(DisplayName ="Should return 3.48 F if Temperature(5.48, Fahrenheit)")]
        public void Test_ToString_Fahrenheit()
        {

            var temp = new AppTemperature(3.48, TemperatureScale.Fahrenheit);
            var str = temp.ToString();
            Assert.Equal("3.48 F", temp.ToString());
        }

        [Fact(DisplayName = "Should return 22 C if Temperature(2, Celsius)")]
        public void Test_ToString_Celsius()
        {

            var temp = new AppTemperature(22.00, TemperatureScale.Celsius);
            var str = temp.ToString();
            Assert.Equal("22 C", temp.ToString());
        }

        [Fact(DisplayName = "Should return 50 K if Temperature(50, Kelvin)")]
        public void Test_ToString_Kelvin()
        {

            var temp = new AppTemperature(50, TemperatureScale.Kelvin);
            var str = temp.ToString();
            Assert.Equal("50 K", temp.ToString());
        }

    }
}