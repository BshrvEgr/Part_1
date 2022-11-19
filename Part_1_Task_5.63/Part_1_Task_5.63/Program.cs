using System;

namespace Part_1_Task_5._63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p = 0;
            double[] gek = { 13, 14, 12, 12, 11, 8, 4, 4, 6, 23 };
            double[] ur = { 4.4, 4.7, 4.2, 4.2, 4, 3.3, 1.4, 1.4, 2, 7.3 };

            for (int i = 0; i < 10; i++)
            {
                p = p + gek[i] * ur[i];
            }

            double middleP = p / 10;

            Console.WriteLine("Урожайность: {0}", p);
            Console.WriteLine("Средняя урожайность {0}", middleP);

            Console.ReadKey();
        }
    }
}
