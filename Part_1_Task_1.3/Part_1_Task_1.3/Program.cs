using System;
using System.Threading;

namespace Part_1_Task_1._3
{
    internal class Program
    {
        static void PrintNumber()
        {
            try
            {
                Console.Write("Введите число: ");
                double number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Вы ввели число: {0}", number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Thread.Sleep(1000);
                Console.Clear();
                PrintNumber();
            }
        }

        static void Main(string[] args)
        {
            PrintNumber();
            Console.ReadKey();
        }

    }
}
