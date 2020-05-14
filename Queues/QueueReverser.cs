using System.Collections.Generic;
using System.Text;
using System;

namespace Queues
{
    public class QueueReverser
    {
        public void Reverse(Queue<int> input)
        {
            if (input.Count == 0)
                throw new InvalidOperationException("Queue is Empty");

            var stack = new Stack<int>();

            while (input.Count != 0)
            {
                stack.Push(input.Dequeue());
            }

            while (stack.Count != 0)
            {
                input.Enqueue(stack.Pop());
            }
        }

        public void Print(Queue<int> input)
        {
            foreach (var item in input)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}