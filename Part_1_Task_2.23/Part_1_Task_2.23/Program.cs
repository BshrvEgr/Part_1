using System;
using System.Threading;

namespace Part_1_Task_2._23
{
    internal class Program
    {
        static void GetInfo()
        {
            try
            {
                int number = 0;
                Console.Write("Введите число > 999: ");
                number = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (number < 999)
                {
                    Console.WriteLine("Ваше число меньше 999, попробуйте снова.");
                    Thread.Sleep(1000);
                    GetInfo();
                }

                else
                {
                    Console.WriteLine("Число соток в числе {0}: {1}", number, number / 100);
                    Console.WriteLine("Число тысяч в числе {0}: {1}", number, number / 1000);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Thread.Sleep(1000);
                Console.Clear();
                GetInfo();
            }
        }

        static void Main(string[] args)
        {
            GetInfo();
            Console.ReadKey();
        }
    }
}
