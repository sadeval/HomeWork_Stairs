using System;

namespace Stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int step = 0;
            string floor = "***";
            string wall = "*";

            while (true)
            {
                Console.Write("Введите количество ступенек: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out step) && step > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите целое положительное число.");
                }
            }

            Console.WriteLine(floor);
            string space = "";
            for (int i = 1; i <= step; i++)
            {
                space += "  ";
                Console.WriteLine("{0}{1}\n{0}{2}", space, wall, floor);
                Thread.Sleep(1000);
            }
        }
    }
}
