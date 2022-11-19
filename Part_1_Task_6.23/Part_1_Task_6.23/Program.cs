using System;

namespace Part_1_Task_6._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a
            int number = 23453;
            string copyNum = number.ToString();

            int a = int.Parse(Console.ReadLine());
            int countA = 0;
            int countMultiplesZ = 0;

            for (int i = 0; i < copyNum.Length; i++)
            {
                if (a.ToString() == copyNum[i].ToString())
                {
                    countA++;
                }
            }

            Console.WriteLine("Число a встречается {0} раз", countA);

            //b
            int z = int.Parse(Console.ReadLine());

            for (int i = 0; i < copyNum.Length; i++)
            {
                int num = Convert.ToInt32(copyNum[i].ToString());
                if (z % num == 0)
                {
                    countMultiplesZ++;
                }
            }

            Console.WriteLine("Количество цифр кратных z: {0}", countMultiplesZ);

            Console.ReadKey();
        }
    }
}
