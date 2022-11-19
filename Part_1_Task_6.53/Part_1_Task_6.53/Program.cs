using System;

namespace Part_1_Task_6._53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number;
            bool flag = true;

            Console.Write("Введите любое число: ");
            number = Console.ReadLine();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (i != 0)
                {
                    int number_1 = Convert.ToInt32(number[i]);
                    int number_2 = Convert.ToInt32(number[i - 1]);

                    if (number_1 > number_2)
                    {
                        flag = false;
                        break;
                    }
                }
            }

            if (flag)
                Console.WriteLine("Положительный");

            else
                Console.WriteLine("Отрицательный");

            Console.ReadKey();
        }
    }
}
