using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTemperatures
{
    public class AppTemperature
    {
        public double Value { get; set; }
        public TemperatureScale Scale { get; set; }
        public AppTemperature()
        {

        }
        public override string ToString()
           => $"{Value} {(char)Scale}";
        //=> $"{nameof(Value)}: {Value}; {nameof(Scale)}: {Scale}";
        public override bool Equals(object obj)
        {
            if (obj is AppTemperature other)
                return Value.Equals(other.Value) && Scale.Equals(other.Scale);
            else
                return false;
        }
        public AppTemperature(double Value, TemperatureScale temperatureScale)
        {
            if (Value <= 0 && temperatureScale == TemperatureScale.Kelvin)
                throw new Exception("Kelvin can't be zero or less");
            this.Value = Value;
            this.Scale = temperatureScale;
        }

        public double Round(double num)
        {
            return Math.Round(num,2);
        }

        public AppTemperature Add(AppTemperature other)
        {
            if (this.Scale == other.Scale)
                return new AppTemperature(Round(this.Value + other.Value), this.Scale);

            if (this.Scale == TemperatureScale.Celsius)
                return new AppTemperature(Round(this.Value + other.ToCelsius().Value), this.Scale);

            if (this.Scale == TemperatureScale.Fahrenheit)
                return new AppTemperature(Round(this.Value + other.ToFahrenheit().Value), this.Scale);

            return new AppTemperature(Round(this.Value + other.ToKelvin().Value), this.Scale);
        }
        public AppTemperature Substract(AppTemperature other) {
            if (this.Scale== other.Scale)
                return new AppTemperature(Round(this.Value - other.Value), this.Scale);

            if (this.Scale == TemperatureScale.Celsius)
                return new AppTemperature(Round(this.Value - other.ToCelsius().Value), this.Scale);

            if (this.Scale == TemperatureScale.Fahrenheit)
                return new AppTemperature(Round(this.Value - other.ToFahrenheit().Value), this.Scale);

            return new AppTemperature(Round(this.Value - other.ToKelvin().Value), this.Scale);
        }

        public AppTemperature MultiplyBy(AppTemperature other) {
            if (this.Scale == other.Scale)
                return new AppTemperature(Round(this.Value * other.Value), this.Scale);

            if (this.Scale == TemperatureScale.Celsius)
                return new AppTemperature(Round(this.Value * other.ToCelsius().Value), this.Scale);

            if (this.Scale == TemperatureScale.Fahrenheit)
                return new AppTemperature(Round(this.Value * other.ToFahrenheit().Value), this.Scale);

            return new AppTemperature(Round(this.Value * other.ToKelvin().Value), this.Scale);
        }

    public AppTemperature DivideBy(AppTemperature other) {
    if (this.Scale == other.Scale)
      return new AppTemperature(Round(this.Value / other.Value), this.Scale);

    if (this.Scale == TemperatureScale.Celsius)
      return new AppTemperature(Round(this.Value / other.ToCelsius().Value), this.Scale);

    if (this.Scale == TemperatureScale.Fahrenheit)
      return new AppTemperature(Round(this.Value / other.ToFahrenheit().Value), this.Scale);

    return new AppTemperature(Round(this.Value / other.ToKelvin().Value), this.Scale);
    }

    public AppTemperature ToFahrenheit() {
    if (this.Scale == TemperatureScale.Celsius) {
                double fahrenheit = Round((this.Value * (double)9 / 5) + 32);
        return new AppTemperature(fahrenheit, TemperatureScale.Fahrenheit);
    }

    if (this.Scale == TemperatureScale.Kelvin) {
                double fahrenheit = Round((this.Value - 273.15) * (double)(9 / 5) + 32);
        return new AppTemperature(fahrenheit, TemperatureScale.Fahrenheit);
    }

    return this;
    }

    public AppTemperature ToCelsius() {
    if (this.Scale == TemperatureScale.Fahrenheit) {
                double celsius = Round((this.Value - 32) * (double)5 / 9);
        return new AppTemperature(celsius, TemperatureScale.Celsius);
    }

    if (this.Scale == TemperatureScale.Kelvin) {
                double celsius = Round(this.Value - 273.15);
        return new AppTemperature(celsius, TemperatureScale.Celsius);
    }

    return this;
    }

    public AppTemperature ToKelvin() {
    if (this.Scale == TemperatureScale.Celsius) {
                double kelvin = Round(this.Value + 273.15);
        return new AppTemperature(kelvin, TemperatureScale.Kelvin);
    }

    if (this.Scale == TemperatureScale.Fahrenheit) {
                double kelvin = Round(((this.Value - 32) * ((double)5 / 9)) + 273.15);
        return new AppTemperature(kelvin, TemperatureScale.Kelvin);
    }

    return this;
    }



   

    //public decimal RoundTemperature(decimal num)
    //{
    //    return Math.Round(+(num+("e+2"))+"e-2");
    //}
}
    public enum TemperatureScale
    {
        Fahrenheit = 'F',
        Celsius = 'C',
        Kelvin = 'K'
    }
    

}
