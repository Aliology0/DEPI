using System;

class Utility
{
    public static int CalculatePerimeter(int length, int width)
    {
        return 2 * (length + width);
    }

    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}