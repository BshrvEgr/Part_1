using System;
using System.Threading;

namespace Part_1_Task_4._23
{
    internal class Program
    {
        static void GetInfoAboutNumber(int number)
        {
            if ((number % 10) > (number / 10) % 10)
                Console.WriteLine("Вторая цифра больше первой.");

            else if ((number % 10) < (number / 10) % 10)
                Console.WriteLine("Первая цифра больше второй.");

            else
                Console.WriteLine("Цифры равны.");
        }
        static void Main(string[] args)
        {
            int number = 0;
            try
            {
                Console.Write("Введите 2-х значное число: ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number < 10 || number > 99)
                {
                    Console.WriteLine("Введенное число не 2-х значное. Попробуйте снова!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Main(args);
                }

                else
                    GetInfoAboutNumber(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Thread.Sleep(1000);
                Console.Clear();
                Main(args);
            }
            Console.ReadLine();
        }
    }
}
