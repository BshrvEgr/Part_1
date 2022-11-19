using System;

namespace Part_1_Task_7._53
{
    internal class Program
    {
        static int GetIndexMaxNumber(int[] array)
        {
            int maxValue = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (maxValue < array[i])
                    maxValue = array[i];
            }

            return Array.LastIndexOf(array, maxValue);
        }

        static int GetIndexMinNumber(int[] array)
        {
            int minValue = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (minValue < array[i])
                    minValue = array[i];
            }

            return Array.IndexOf(array, minValue);
        }

        static void Main(string[] args)
        {
            int n = 0;

            Console.Write("Введите количество целых чисел: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите {i + 1} число: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }

            Console.WriteLine($"Индекс последнего максимального элемента в массиве: {GetIndexMaxNumber(numbers)}\n" +
                $"Индекс первого минимального элемента в массиве: {GetIndexMinNumber(numbers)}");
            Console.ReadKey();
        }
    }
}
