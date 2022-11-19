using System;

namespace Part_1_Task_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            bool c = false;

            Console.WriteLine("a){0}", !(a && b));
            Console.WriteLine("b){0}", a || (!b));
            Console.WriteLine("c){0}", (a && b) || c);
            Console.ReadKey();
        }
    }
}
