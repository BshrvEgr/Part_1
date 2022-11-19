using System;

namespace Part_1_Task_1._43
{
    internal class Program
    {
        static double GetMiddleArifmetic(double num1, double num2) => (num1 + num2) / 2;

        static double GetGeometricArifmetic(double num1, double num2) => Math.Sqrt(num1 * num2);

        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Среднее арифметическое: {0}", GetMiddleArifmetic(a, b));
            Console.WriteLine("Среднее геометрическое: {0}", GetGeometricArifmetic(a, b));
            Console.ReadKey();
        }

    }
}
