using System;

namespace T03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int xvineyard = int.Parse(Console.ReadLine());
            double ygrapes = double.Parse(Console.ReadLine());
            int zlitersWine = int.Parse(Console.ReadLine());
            int numWorkers = int.Parse(Console.ReadLine());
            double totalWine = 0;

            double totalGrape = xvineyard * ygrapes;
            double wine = ((totalGrape * 0.40) / 2.5);

            if (wine > zlitersWine)
            {
                totalWine = wine - zlitersWine;
                Math.Ceiling(totalWine);
                Console.WriteLine($"Good harvest this year! Total wine: {totalWine} liters.");
            }
            else if (wine < zlitersWine)
            {
                totalWine = zlitersWine - wine;
                Math.Ceiling(totalWine);
                Console.WriteLine($"It will be a tough winter! More {totalWine} liters wine needed.");
            }
        }
    }
}
