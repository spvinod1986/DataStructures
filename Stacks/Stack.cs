using System;

namespace Stacks
{
    public class Stack
    {
        private int[] items = new int[5];
        private int count;

        public void Push(int item) // O(1)
        {
            if (items.Length == count)
                throw new StackOverflowException("Stack is full");

            items[count] = item;
            count++;
        }

        public int Pop() // O(1)
        {
            if (count == 0)
                throw new InvalidOperationException("Stack is Empty");

            count--;
            return items[count];
        }

        public int Peek() // O(1)
        {
            if (count == 0)
                throw new InvalidOperationException("Stack is Empty");

            return items[count - 1];
        }

        public void Print()
        {
            int[] output = new int[count];
            Array.ConstrainedCopy(items, 0, output, 0, count);
            Array.ForEach(output, System.Console.WriteLine);
        }
    }
}