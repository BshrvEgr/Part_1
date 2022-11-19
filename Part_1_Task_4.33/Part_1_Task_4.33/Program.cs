using System;

namespace Part_1_Task_4._33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 423;

            if ((number % 10) % 2 == 0)
                Console.WriteLine("У числа {0} последняя цифра четная", number);

            else
                Console.WriteLine("У числа {0} последняя цифра нечетная", number);

            Console.ReadKey();
        }
    }
}
