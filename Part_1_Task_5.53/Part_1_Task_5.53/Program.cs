using System;

namespace Part_1_Task_5._53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mark = { 2, 3, 3, 3, 4, 5, 3, 3, 3, 5 };
            double sum = 0;

            for (int i = 0; i < mark.Length; i++)
            {
                sum += mark[i];
            }

            Console.WriteLine($"{sum / mark.Length}");

            Console.ReadKey();
        }
    }
}
