using System;

namespace Part_1_Task_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 7, 5, 2, 5, 5, 5 };

            int sum = 0;
            int i = 0;

            while (array[i] % 2 != 0)
            {
                sum = sum + array[i];
                i++;
            }

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
