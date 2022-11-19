using System;

namespace Part_1_Task_4._103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num_1 = 3.2f;
            float num_2 = 2.1f;
            float num_3 = 2.3f;

            //Пункт а

            if (num_1 > num_2 && num_1 > num_3)
                Console.WriteLine($"{num_1} наибольшее числоо");

            if (num_2 > num_1 && num_2 > num_3)
                Console.WriteLine($"{num_2} наибольшее число");

            if (num_3 > num_1 && num_3 > num_2)
                Console.WriteLine($"{num_3} наибольшее число");

            //Пункт б

            if (num_1 < num_2 && num_1 < num_3)
                Console.WriteLine($"{num_1} наименьшее число");

            if (num_2 < num_1 && num_2 < num_3)
                Console.WriteLine($"{num_2} наименьшее число");

            if (num_3 < num_2 && num_3 < num_1)
                Console.WriteLine($"{num_3} наименьшее число");

            Console.ReadKey();
        }
    }
}
