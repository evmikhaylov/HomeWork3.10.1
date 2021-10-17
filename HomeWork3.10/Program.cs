using System;

namespace HomeWork3._10._1
{
    class Program
    {
        static void Main(string[] args)
        
        {
                Console.WriteLine("Введите число");
                var num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} чётное");
                }
                else
                {
                    Console.WriteLine($"{num} не чётное");
                }
        }
    }
}
