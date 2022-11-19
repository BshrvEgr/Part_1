using System;

namespace Part_1_Task_4._43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 40;
            int b = 4;

            if (a % b == 0)
                Console.WriteLine("Да, число {0} является делителем", a);

            else if (b % a == 0)
                Console.WriteLine("Да, число {0} является делителем", b);

            else
                Console.WriteLine("Нет, ни одно из чисел не является делителем другого");

            Console.ReadKey();
        }
    }
}
