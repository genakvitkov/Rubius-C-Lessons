using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHomework
{
    class Program

    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива (целое положительное число)");
            uint arrayLength = ValidateUserInput(Console.ReadLine());
            uint[] numbers = new uint[arrayLength];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Введите значение элемента массива (целое положительное число)");
                numbers[i] = ValidateUserInput(Console.ReadLine());
            }

            uint maxValue = numbers.Max();
            uint[] finalArray = new uint [numbers.Length];
            
            for (uint i = 0; i < numbers.Length; i++)
            {             
                if (numbers[i] != maxValue) 
                {
                    finalArray[i] = numbers[i];  
                }       
            }

            uint secondMaxValue = finalArray.Max();

            Console.WriteLine($"Второй максимальный элемент: {secondMaxValue}");
            Console.ReadLine();
            
        }

        static uint ValidateUserInput(string userInput)
        {
            while (!uint.TryParse(userInput, out uint garbage) || userInput == "0")
            {
                Console.WriteLine("Введите целое положительное число");
                userInput = Console.ReadLine();
            }

            uint inputNumber = uint.Parse(userInput);
            return inputNumber;
        }
    }
}









/*
uint arrayLength = ValidatedUserInput(Console.ReadLine());
uint[] numbers = new uint[arrayLength];
for (uint i = 0; i < numbers.Length; i++) 
{
    numbers[i] = uint.Parse(Console.ReadLine());
}
//Console.WriteLine(string.Join(" ", numbers));

uint j = 0;
uint maximumValue = 0;

while (j < numbers.Length)
{

    if (numbers[j] > numbers[j + 1])
    {
        maximumValue = numbers[j];
        if (maximumValue < numbers[j + 1]) 
        {
        maximumValue = numbers[j + 1];
        }

    }

    j++;

}

Console.WriteLine(maximumValue);*/


