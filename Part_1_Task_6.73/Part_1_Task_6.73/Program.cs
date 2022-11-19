using System;

namespace Part_1_Task_6._73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[15] { 1, 5, 3, 5, 6, 8, 9, 10, 22, 35, 68, 52, 46, 15, 66 };
            bool flg = true;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                    if (a[i] == a[j])
                    {
                        flg = false;
                        break;
                    }
                if (!flg) break;
            }
            if (flg)
                Console.WriteLine("Yes !");
            else
                Console.WriteLine("No !");

            Console.ReadKey();
        }
    }
}
