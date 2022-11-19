using System;

namespace Part_1_Task_4._73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] numbers = { 3f, 2.2f, 4.2f, 1f };

            float maxNumber = numbers[0];
            float minNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (maxNumber < numbers[i])
                    maxNumber = numbers[i];

                if (minNumber > numbers[i])
                    minNumber = numbers[i];
            }

            Console.WriteLine($"Самое большое число {maxNumber}, а " +
                $"самое маленькое {minNumber}");

            Console.ReadKey();
        }
    }
}
