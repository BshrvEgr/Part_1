using System;

namespace Part_1_Task_4._123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sides = { 3, 2, 10 };

            int gepotinusa = sides[0];
            int side_1 = sides[0];
            int side_2 = sides[0];

            foreach (var number in sides)
            {
                if (gepotinusa < number)
                {
                    gepotinusa = number;
                }

                if (side_1 > number)
                {
                    side_1 = number;
                }
            }

            foreach (var number in sides)
            {
                if (number != gepotinusa && number != side_1)
                    side_2 = number;
            }

            if (Math.Pow(gepotinusa, 2) == Math.Pow(side_1, 2) + Math.Pow(side_2, 2))
            {
                Console.WriteLine("Прямоугольный");
            }

            else
                Console.WriteLine("Не прямоугольный");

            Console.ReadKey();
        }
    }
}
