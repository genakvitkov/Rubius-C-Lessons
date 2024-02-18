using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework
{
    class Stack<T>
    {
        public static List<T> Items = new List<T>();
     
        public void Push(T item) 
        {
            Items.Add(item);
        }

        public T Pop() 
        {
            var result = Items.Last();
            Items.Remove(result);
            return result;
        }

        public T Peek() 
        {
            return Items.Last();
        }

        public bool IsEmpty()
        {
            return Items.Count == 0;
        }

        public void Clear()
        {
            Items.Clear();
        }
    }
}
