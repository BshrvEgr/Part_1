using System;

namespace Part_1_Task_6._83
{
    internal class Program
    {
        static int GetMaxNumber(int number)
        {
            string copyNum = number.ToString();
            string maxNum = copyNum[0].ToString();

            for (int i = 0; i < copyNum.Length; i++)
            {
                int nextNum = Convert.ToInt32(copyNum[i].ToString());
                if (Convert.ToInt32(maxNum) < nextNum)
                    maxNum = copyNum[i].ToString();
            }

            return Convert.ToInt32(maxNum);
        }

        static int GetMinNumber(int number)
        {
            string copyNum = number.ToString();
            string minNum = copyNum[0].ToString();

            for (int i = 0; i < copyNum.Length; i++)
            {
                int nextNum = Convert.ToInt32(copyNum[i].ToString());
                if (Convert.ToInt32(minNum) > nextNum)
                    minNum = copyNum[i].ToString();
            }

            return Convert.ToInt32(minNum);
        }

        static void Main(string[] args)
        {
            int number = 3552;
            int a = 0;

            Console.Write("Введите число a: ");
            a = Convert.ToInt32(Console.ReadLine());

            int minNumber = GetMinNumber(number);
            int maxNumber = GetMaxNumber(number);

            if (a % (minNumber + maxNumber) == 0)
                Console.WriteLine("Является кратной");

            else
                Console.WriteLine("Не является кратной");

            Console.ReadKey();
        }
    }
}
