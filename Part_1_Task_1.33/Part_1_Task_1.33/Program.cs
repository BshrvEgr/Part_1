using System;

namespace Part_1_Task_1._33
{
    internal class Program
    {
        static double GetDensity(int countPeople, double area) => countPeople / area;

        static void Main(string[] args)
        {
            Console.Write("Введите кол-во людей проживающих в вашей стране: ");
            int countPeople = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите площадь вашей страны: ");
            double area = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nПлотность населения: {0}", GetDensity(countPeople, area));
            Console.ReadKey();
        }

    }
}
