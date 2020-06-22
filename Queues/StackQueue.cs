using System.Collections.Generic;
using System;

namespace Queues
{
    public class StackQueue
    {
        private Stack<int> stack1 = new Stack<int>();
        private Stack<int> stack2 = new Stack<int>();

        public void Enqueue(int item) // O(1)
        {
            stack1.Push(item);
        }

        public int Dequeue() // O() ???
        {
            if (stack1.Count == 0 && stack2.Count == 0)
                throw new InvalidOperationException("Queue is Empty");

            if (stack2.Count != 0)
                return stack2.Pop();

            while (stack1.Count != 0)
            {
                stack2.Push(stack1.Pop());
            }
            return stack2.Pop();
        }
    }
}