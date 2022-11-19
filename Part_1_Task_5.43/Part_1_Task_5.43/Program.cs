using System;

namespace Part_1_Task_5._43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pay = { 23000, 14500, 14000, 12200, 35499, 35123 };
            int sum = 0;

            for (int i = 0; i < pay.Length; i++)
            {
                sum += pay[i];
            }

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
