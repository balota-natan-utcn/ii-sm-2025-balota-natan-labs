using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Stack
    {
        private List<int> elements;

        public Stack()
        {
            elements = new List<int>();
        }

        public void Push(int item)
        {
            elements.Add(item);
        }

        public int Pop()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            int top = elements[^1]; //Get the last element
            elements.RemoveAt(elements.Count - 1);
            return top;
        }

        public int elementsNr()
        {
            return elements.Count;
        }

        public void PrintStack()
        {
            Console.WriteLine("Stack elements: " + string.Join(", ", elements));
        }
    }
}
