using System;

namespace Part_1_Task_9._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string surname = "";

            Console.Write("Enter name: ");
            name = Console.ReadLine();

            Console.Write("Enter surname: ");
            surname = Console.ReadLine();

            string result = name + " " + surname;

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
