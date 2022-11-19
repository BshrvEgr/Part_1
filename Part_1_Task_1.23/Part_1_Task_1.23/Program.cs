using System;

namespace Part_1_Task_1._23
{
    internal class Program
    {
        static double GetAnswer(double number) => (Math.Pow(number, 2) + 10) /
            Math.Sqrt(Math.Pow(number, 2) + 1);

        static void Main(string[] args)
        {
            double a;
            Console.Write("Введите число(a): ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ: {0}", GetAnswer(a));
            Console.ReadKey();
        }

    }
}
