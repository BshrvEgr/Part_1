using System;

namespace Part_1_Task_5._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int num = 7;

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{i} x {num} = {i * num}");
            }

            Console.ReadLine();
        }
    }
}
