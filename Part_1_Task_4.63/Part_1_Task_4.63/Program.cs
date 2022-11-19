using System;

namespace Part_1_Task_4._63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2342;
            bool flag = true;

            string convertNum = n.ToString();

            for (int i = 0; i < convertNum.Length; i++)
            {
                for (int j = 0; j < convertNum.Length; j++)
                {
                    if (i != j)
                    {
                        if (convertNum[i] == convertNum[j])
                            flag = false;
                    }
                }
            }

            if (flag)
                Console.WriteLine($"В числе {n} все цифры уникальны");

            else
                Console.WriteLine($"В числе {n} есть повторяющиеся цифры");

            Console.ReadKey();
        }
    }
}
