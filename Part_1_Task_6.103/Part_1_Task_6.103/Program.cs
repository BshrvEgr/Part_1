using System;

namespace Part_1_Task_6._103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 16;

            Console.WriteLine($"{a} / {b}");

            for (int i = 2; i <= a && i <= b; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    a /= i;
                    b /= i;
                }
            }

            Console.WriteLine($"{a} / {b}");

            Console.ReadKey();
        }
    }
}
