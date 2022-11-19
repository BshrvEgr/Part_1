using System;

namespace Part_1_Task_8._33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 50; i < 71; i++)
            {
                int sum = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        sum += j;
                }

                Console.WriteLine($"Сумма делителей числа {i}: {sum}");
            }

            Console.ReadKey();
        }
    }
}
