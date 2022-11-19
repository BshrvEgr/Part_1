using System;
using System.Threading;

namespace Part_1_Task_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double x, y;

                Console.Write("x = ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("y = ");
                y = Convert.ToDouble(Console.ReadLine());
                Console.Clear();

                if (x < 0 && y > 0)
                    Console.WriteLine("1");

                if (x > 0 && y > 0)
                    Console.WriteLine("2");

                if (x < 0 && y < 0)
                    Console.WriteLine("3");

                if (x > 0 && y < 0)
                    Console.WriteLine("4");

                if (x == 0 && y == 0)
                    Console.WriteLine("Нулевые координаты");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Thread.Sleep(1000);
                Console.Clear();
            }

            Console.ReadLine();
        }
    }
}
