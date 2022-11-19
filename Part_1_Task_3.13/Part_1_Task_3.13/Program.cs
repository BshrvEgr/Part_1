using System;

namespace Part_1_Task_3._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;

            Console.WriteLine("1. Вариант: a = true; b = false");
            Console.WriteLine("1. {0}", !(a && b));
            Console.WriteLine("2. {0}", (!a) || b);
            Console.WriteLine("3. {0}\n", a || (!b));

            a = false;
            b = true;

            Console.WriteLine("2. Вариант: a = false; b = true");
            Console.WriteLine("1. {0}", !(a && b));
            Console.WriteLine("2. {0}", (!a) || b);
            Console.WriteLine("3. {0}\n", a || (!b));

            a = true;
            b = true;

            Console.WriteLine("3. Вариант: a = true; b = true");
            Console.WriteLine("1. {0}", !(a && b));
            Console.WriteLine("2. {0}", (!a) || b);
            Console.WriteLine("3. {0}\n", a || (!b));

            a = false;
            b = false;

            Console.WriteLine("4. Вариант: a = false; b = false");
            Console.WriteLine("1. {0}", !(a && b));
            Console.WriteLine("2. {0}", (!a) || b);
            Console.WriteLine("3. {0}\n", a || (!b));
            Console.ReadKey();
        }
    }
}
