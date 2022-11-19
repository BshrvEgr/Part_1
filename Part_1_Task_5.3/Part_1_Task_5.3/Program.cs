using System;

namespace Part_1_Task_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a
            for (int i = 20; i < 36; i++)
            {
                Console.WriteLine(i);
            }

            //b
            Console.WriteLine("Введите значение b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = 10; i <= b; i++)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }

            //c
            Console.WriteLine("Введите значение a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= 50; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }

            //d
            Console.WriteLine("Введите первое число: ");
            int num_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int num_2 = Convert.ToInt32(Console.ReadLine());

            for (int i = num_1; i <= num_2; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
