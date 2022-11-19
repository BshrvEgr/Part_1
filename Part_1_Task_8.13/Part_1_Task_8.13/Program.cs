using System;

namespace Part_1_Task_8._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 18;
            int cols = 3;
            int[,] mass = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Введите оценку {i + 1} ученика по {j + 1} предмету: ");
                    mass[i, j] = Convert.ToInt32(Console.ReadLine());
                    //Console.Clear();
                }
            }

            //a
            int countFive = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (mass[i, j] == 5)
                    {
                        countFive++;
                    }
                }
            }

            Console.WriteLine($"Общее количество пятерок в группе: {countFive}");

            //b
            for (int i = 0; i < rows; i++)
            {
                int countThree = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (mass[i, j] == 3)
                        countThree++;
                }
                Console.WriteLine($"Кол-во троек у {i + 1} ученика: {countThree}");
            }

            //c
            for (int i = 0; i < cols; i++)
            {
                int countTwo = 0;

                for (int j = 0; j < rows; j++)
                {
                    countTwo++;
                }

                Console.WriteLine($"Кол-во двоек по {i + 1} предмету: {countTwo}");
            }

            Console.ReadKey();
        }
    }
}
