using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static string InputAndValidate(string userString)
        {
            while (!uint.TryParse(userString, out uint garbage))
            {
                Console.WriteLine("Не похоже на номер года...");
                Console.WriteLine("Введите номер года!");
                userString = Console.ReadLine();

            }

            return userString;
        }

        public static void IfLeapYear()
        {
            uint yearNumber = uint.Parse(InputAndValidate(Console.ReadLine()));

            if ((yearNumber % 4 == 0 && yearNumber % 100 != 0) || yearNumber % 400 == 0)
            {
                Console.WriteLine($"{yearNumber} год является високосным");
            }
            else
            {
                Console.WriteLine($"{yearNumber} год не является високосным");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Давайте определим, является ли год високосным!");
            Console.WriteLine("Введите номер года");
            while (true)
            {
                IfLeapYear();
            }
        }
    }
}

/* Я конечно немного перемудрил с программой, сделал много того, что не требовалось по заданию, и не уверен, что правильно это сделал,
 * но хотелось поиграться с правилами нового для меня языка, плюс я тестировал программу на своих друзьях и все сказали, что "чё за прикол, 
 * один раз можно год ввести, а с повторным вводом программа вылетает", поэтому я учёл пользовательские пожелания))) в следующий раз постараюсь
 * к заданиям более буквально подходить */