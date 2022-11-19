using System;

namespace Part_1_Task_7._33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            Console.Write("Введите кол-во цифр: ");
            n = Convert.ToInt32(Console.ReadLine());
            double[] numbers = new double[n];

            Console.Clear();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите {i + 1} число: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            }

            int countPlus = 0;
            int countMinus = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                    countPlus++;

                else
                    countMinus++;
            }

            Console.WriteLine($"Количество отрицательных цифр: {countMinus}\n" +
                $"Количество положительных цифр {countPlus}");

            Console.ReadKey();
        }
    }
}
