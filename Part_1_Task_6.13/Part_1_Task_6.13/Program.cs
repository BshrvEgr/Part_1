using System;

namespace Part_1_Task_6._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double num = 0;

            for (double i = 2; i < n; i++)
            {
                num = 1 + 1 / i;

                if (num > 1 && num <= 1.5)
                {
                    Console.WriteLine(num);
                }
            }

            Console.ReadKey();
        }
    }
}
