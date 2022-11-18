using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare a single-dimensional array of 5 integers.
            string[] kolekciqZaKoli = new string[5];
            kolekciqZaKoli[0] = "BMW";
            kolekciqZaKoli[1] = "MERCEDES";
            kolekciqZaKoli[2] = "DJEEP";
            kolekciqZaKoli[3] = "MOSKVICH";
            kolekciqZaKoli[4] = "LADA";
            kolekciqZaKoli[5] = "gggggg";

            for (int i = 0; i < kolekciqZaKoli.Length; i++)
            {
                Console.WriteLine(i);
                string element = kolekciqZaKoli[i];
                if (element == "BMW")
                {
                    Console.WriteLine("BMW found");
                }
                else if (kolekciqZaKoli[i] == "LADA")
                {
                    Console.WriteLine("LADA");
                }
                else if (kolekciqZaKoli[i] == "MERCEDES")
                {
                    Console.WriteLine(kolekciqZaKoli[i]);
                }
            }
            // Exercise Lectute
            double greenPrice = double.Parse(Console.ReadLine());
            double discount;
            double finalPrice;
            greenPrice = greenPrice * 7.61;
            Console.WriteLine(greenPrice);
            discount = 0.18 * greenPrice;
            finalPrice = greenPrice - discount;
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
