using System;
using System.Threading;

namespace Part_1_Task_4._113
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mounths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int m, n;

            Console.WriteLine("Введите номер месяца: ");
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите день: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (m > 12)
            {
                Console.WriteLine("Неопределенная дата!");
                Thread.Sleep(1000);
                Console.Clear();
                Main(args);
            }

            else
            {
                if (n == 1)
                {
                    m -= 1;
                    n = mounths[m];

                    Console.WriteLine($"{n} - ое число, {m} - й месяц");
                }

                else
                {
                    n -= 1;
                    Console.WriteLine($"{n} - ое число, {m} - й месяц");
                }
            }

            Console.ReadKey();
        }
    }
}
