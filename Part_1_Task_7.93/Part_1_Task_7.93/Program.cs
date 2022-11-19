using System;

namespace Part_1_Task_7._93
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] items_1 = { 234, 352, 162, 124, 153, 775, 222, 444 };
            int[] items_2 = { 432, 643, 643, 111, 111, 111, 234, 124 };
            int sum_1 = 0;
            int sum_2 = 0;

            for (int i = 0; i < items_1.Length; i++)
            {
                sum_1 += items_1[i];
                sum_2 += items_2[i];
            }

            if (sum_1 > sum_2)
                Console.WriteLine($"Сумма 1-го набора больше: {sum_1} > {sum_2}");

            else if (sum_1 < sum_2)
                Console.WriteLine($"Сумма 2-го набора больше {sum_2} > {sum_1}");

            else
                Console.WriteLine($"Суммы 1 и 2 набора равны: {sum_1} = {sum_2}");
            Console.ReadKey();
        }
    }
}
