using System;

namespace Part_1_Task_7._103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, -3, -2, -1, 0, 0, 2, -11, 12 };
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                    count++;
            }

            bool flag = count < 5;

            if (flag)
                Console.WriteLine("Верно");

            else
                Console.WriteLine("Неверно");

            Console.ReadKey();
        }
    }
}
