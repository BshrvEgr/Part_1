using System;

namespace Part_1_Task_1._53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceMonitor, priceSystemBlock, priceKeyBoard, priceMouse;
            int countComputers;

            Console.Write("Введите цену монитора: ");
            priceMonitor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите цену системного блока: ");
            priceSystemBlock = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите цену клавиатуры: ");
            priceKeyBoard = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите цену мышки: ");
            priceMouse = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество компьютеров, которых вы хотите собрать: ");
            countComputers = Convert.ToInt32(Console.ReadLine());

            double result = (priceMonitor + priceSystemBlock + priceKeyBoard + priceMouse) * countComputers;
            Console.WriteLine("Цена собранных компьютеров({0}): {1}", countComputers, result);
            Console.ReadKey();
        }
    }
}
