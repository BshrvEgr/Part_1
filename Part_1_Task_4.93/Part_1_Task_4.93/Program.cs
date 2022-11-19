using System;

namespace Part_1_Task_4._93
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float point = 3f;

            if (point < 2.5 && point > 0)
                Console.WriteLine("Точка попадает в 3 область");

            else if (point >= 2.5 && point < 5)
                Console.WriteLine("Точка попадает во 2 область");

            else
                Console.WriteLine("Точка попадает в 1 область");

            Console.ReadKey();
        }
    }
}
