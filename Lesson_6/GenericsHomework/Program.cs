using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Stack<int> Integers = new Stack<int>();
            Stack<double> Doubles = new Stack<double>();
            Stack<string> Strings = new Stack<string>();

            Integers.Push(1);
            Integers.Push(2);
            Integers.Push(3);

            if (Integers.IsEmpty()) 
            {
                throw new Exception("Стэк пуст");
            }

            Integers.Pop();
            Integers.Peek();
            Integers.Clear();

            if (Integers.IsEmpty()) 
            {
                Console.WriteLine("Всё получилось");
            }
            else
            {
                Console.WriteLine("Что-то пошло не так");
            }

            Doubles.Push(11.3);
            Doubles.Push(2.57);
            Doubles.Push(3.8);

            if (Doubles.IsEmpty())
            {
                throw new Exception("Стэк пуст");
            }

            Doubles.Pop();
            Doubles.Peek();
            Doubles.Clear();

            if (Doubles.IsEmpty())
            {
                Console.WriteLine("Всё получилось");
            }
            else
            {
                Console.WriteLine("Что-то пошло не так");
            }

            Strings.Push("Наследование");
            Strings.Push("Инкапсуляция");
            Strings.Push("Полиморфизм");

            if (Strings.IsEmpty())
            {
                throw new Exception("Стэк пуст");
            }

            Strings.Pop();
            Strings.Peek();
            Strings.Clear();

            if (Strings.IsEmpty())
            {
                Console.WriteLine("Всё получилось");
            }
            else
            {
                Console.WriteLine("Что-то пошло не так");
            }

            Console.ReadLine();
        }
    }
}

