using System;
using System.Globalization;

namespace CantileverConverterFromRadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radian = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double degrees;
            degrees = radian * 180 / Math.PI;
            Console.WriteLine(degrees);
        }
    }
}
