using System;

namespace Part_1_Task_5._33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b = 3;
            double sum = 0;

            for (int i = 2; i <= 10; i++)
            {
                sum += i / b;
                b++;
            }

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
