using System;

class Program
{
    delegate void TemperatureConverter(double celsius);

    static void CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("Fahrenheit = " + fahrenheit);
    }

    static void CelsiusToKelvin(double celsius)
    {
        double kelvin = celsius + 273.15;
        Console.WriteLine("Kelvin = " + kelvin);
    }

    static void Main()
    {
        TemperatureConverter obj = CelsiusToFahrenheit;
        obj += CelsiusToKelvin;

        obj(25);
    }
}