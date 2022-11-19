using System;

namespace Part_1_Task_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weightInKg;

            Console.Write("Введите массу(кг): ");
            weightInKg = Convert.ToDouble(Console.ReadLine());
            double weightInT = weightInKg / 1000;

            Console.WriteLine("{0} Кг = {1} Т", weightInKg, weightInT);
            Console.ReadKey();
        }

    }
}
