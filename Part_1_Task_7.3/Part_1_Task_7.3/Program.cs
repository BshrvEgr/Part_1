using System;

namespace Part_1_Task_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i < 50; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine("Сумма нечетных чисел: {0}", sum);

            Console.ReadKey();
        }
    }
}
