using System;
using System.Collections.Generic;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            var reverser = new QueueReverser();
            var input = new Queue<int>();
            input.Enqueue(10);
            input.Enqueue(20);
            input.Enqueue(30);
            reverser.Reverse(input);
            reverser.Print(input);

            var arrayQueue = new ArrayQueue(5);
            arrayQueue.Enqueue(100);
            arrayQueue.Enqueue(200);
            arrayQueue.Enqueue(300);
            arrayQueue.Dequeue();
            arrayQueue.Enqueue(400);
            arrayQueue.Enqueue(500);
            arrayQueue.Enqueue(600);
            arrayQueue.Print();

            var stackQueue = new StackQueue();
            stackQueue.Enqueue(10);
            stackQueue.Enqueue(20);
            System.Console.WriteLine(stackQueue.Dequeue());
            System.Console.WriteLine(stackQueue.Dequeue());

            var priorityQueue = new PriorityQueue(5);
            priorityQueue.Enqueue(2);
            priorityQueue.Enqueue(5);
            priorityQueue.Enqueue(1);
            priorityQueue.Enqueue(3);
            priorityQueue.Enqueue(5);
            priorityQueue.Print();
            System.Console.WriteLine($"The first one to dequeue is {priorityQueue.Dequeue()}");
            System.Console.WriteLine($"The second one to dequeue is {priorityQueue.Dequeue()}");

        }
    }
}
