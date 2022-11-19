using System;

namespace Part_1_Task_6._63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int student = 0;

            Console.Write("Введите кол-воо учеников в группе: ");
            student = Convert.ToInt32(Console.ReadLine());

            int[] marks = new int[student];

            for (int i = 0; i < student; i++)
            {
                Console.Write($"Введите оценку {i + 1} ученика: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }

            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] == 2)
                {
                    Console.WriteLine("Среди учеников есть двойки!");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
