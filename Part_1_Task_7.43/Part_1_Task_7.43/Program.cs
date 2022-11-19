using System;

namespace Part_1_Task_7._43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 35, 23, 53, 23, 4, 5, 6, 14 };
            double middleArifmetic = 0;
            double numbersGreaterThanTen = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 10)
                {
                    middleArifmetic += numbers[i];
                    numbersGreaterThanTen++;
                }
            }

            Console.WriteLine($"MiddleArifmetic: {middleArifmetic / numbersGreaterThanTen}");

            Console.ReadKey();
        }
    }
}
