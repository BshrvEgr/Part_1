using System;
using System.Threading;

namespace Part_1_Task_4._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a, b, c;

                Console.Write("Введите a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите c: ");
                c = Convert.ToDouble(Console.ReadLine());

                double isKor = Math.Pow(b, 2) - 4 * a * c;

                if (isKor > 0)
                    Console.WriteLine("2 корня (D > 0)");
                else if (isKor == 0)
                    Console.WriteLine("1 корень (D = 0)");
                else
                    Console.WriteLine("Корней не существует! (D < 0)");
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
