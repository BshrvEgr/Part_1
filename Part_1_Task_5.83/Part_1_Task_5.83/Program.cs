using System;

namespace Part_1_Task_5._83
{
    internal class Program
    {
        static double MathV2(double number, double step)
        {
            double result = number;

            for (int i = 1; i < step; i++)
            {
                result *= number;
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MathV2(5, 3));

            Console.ReadKey();
        }
    }
}
