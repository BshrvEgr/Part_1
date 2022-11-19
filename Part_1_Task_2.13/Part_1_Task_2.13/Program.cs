using System;
using System.Threading;

namespace Part_1_Task_2._13
{
    internal class Program
    {
        static void GetNewNumber()
        {
            try
            {
                int number = 0;

                Console.Write("Введите трехзначное число: ");
                number = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (number < 100 || number >= 1000)
                {
                    Console.WriteLine("Ошибка!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    GetNewNumber();
                }

                else
                {
                    int number_1 = number % 10;
                    int number_2 = (number / 10) % 10;
                    int number_3 = (number / 100) % 10;

                    Console.WriteLine("Старое число: {0}", number);
                    Console.WriteLine("Новое число: {0}{1}{2}", number_1, number_2, number_3);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Thread.Sleep(1000);
                GetNewNumber();
            }
        }

        static void Main(string[] args)
        {
            GetNewNumber();
            Console.ReadKey();
        }
    }
}
