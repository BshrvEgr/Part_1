using System;

namespace Part_1_Task_8._43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            double sum = 0;

            for (int i = 1; i < n; i++)
            {
                sum += Math.Pow(i, i);
            }

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
