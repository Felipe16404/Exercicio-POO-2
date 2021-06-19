using System;

namespace VSProject
{
    public class Converter
    {
        public double toFahrenheit(double valor1)
        {
            return (valor1 * 9 / 5) + 32;
        }
        public double toCelsius(double valor1)
        {
            return (valor1 - 32) * 5 / 9;
        }
    }
}