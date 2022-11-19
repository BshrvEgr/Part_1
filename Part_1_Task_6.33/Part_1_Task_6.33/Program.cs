using System;

namespace Part_1_Task_6._33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a
            int a = 1;
            do
            {
                a++;
                if (a % 13 == 0)
                    Console.WriteLine(a);
            } while (a <= 100);

            //b
            for (int i = 1; i <= 100; i++)
                if (i % 13 == 0)
                    Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
