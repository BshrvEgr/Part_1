using System;
using System.Threading;

namespace Part_1_Task_2._33
{
    internal class Program
    {
        static void GetNewNubmer()
        {
            try
            {
                int number = 0;
                int firstNum, secondNum, threeNum = 0;

                Console.Write("Введите 3-х значное число: ");
                number = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (number < 100 || number > 999)
                {
                    Console.WriteLine("Введенное вами число не 3-х значное. Попробуйте снова!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    GetNewNubmer();
                }

                else
                {
                    threeNum = number % 10;
                    secondNum = (number / 10) % 10;
                    firstNum = (number / 100) % 10;

                    Console.WriteLine("Старое число: {0}", number);
                    Console.WriteLine("Новое число: {0}{1}{2}", threeNum, secondNum, firstNum);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Thread.Sleep(1000);
                Console.Clear();
                GetNewNubmer();
            }
        }

        static void Main(string[] args)
        {
            GetNewNubmer();
            Console.ReadKey();
        }
    }
}
