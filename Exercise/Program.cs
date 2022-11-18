using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            if (hour >= 0 || hour <= 23)
            {
                if (min >= 0 || min <= 59)
                {
                    int minTotal = (min + 15);
                    int totalHourInMinutes = hour * 60;
                    int totalHour = totalHourInMinutes + minTotal;
                    TimeSpan spWorkMin = TimeSpan.FromMinutes(totalHour);
                    Console.WriteLine(string.Format("{0:00}", spWorkMin.Hours.ToString()) + ":" + string.Format("{00:00}", spWorkMin.Minutes.ToString()));
                }
            }
        }   
    }
}
