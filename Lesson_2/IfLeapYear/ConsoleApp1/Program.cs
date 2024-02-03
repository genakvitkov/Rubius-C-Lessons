using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давайте определим, является ли год високосным");
            Console.WriteLine("Введите номер года!");
            string userString = Console.ReadLine();

            while (!uint.TryParse(userString, out uint result)) 
                { 
                Console.WriteLine("Не похоже на номер года...");
                Console.WriteLine("Введите номер года!");
                userString = Console.ReadLine();
                }

            uint yearNumber = uint.Parse(userString);

            if ((yearNumber % 4 == 0 && yearNumber % 100 != 0) || yearNumber % 400 == 0)
            {
                Console.WriteLine($"{yearNumber} год является високосным");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"{yearNumber} год не является високосным");
                Console.ReadLine();
            }
        }
    }
}
