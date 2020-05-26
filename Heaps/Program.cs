using System;

namespace Heaps
{
    class Program
    {
        static void Main(string[] args)
        {
            var heap = new Heap(10);
            heap.Insert(10);
            heap.Insert(5);
            heap.Insert(17);
            heap.Insert(4);
            heap.Insert(22);
            heap.Remove();
            heap.Print();

            var priorityQueue = new PriorityQueue();
            priorityQueue.Enqueue(2);
            priorityQueue.Enqueue(5);
            priorityQueue.Enqueue(1);
            priorityQueue.Enqueue(3);
            priorityQueue.Enqueue(4);
            System.Console.WriteLine($"The first one to dequeue is {priorityQueue.Dequeue()}");
            System.Console.WriteLine($"The second one to dequeue is {priorityQueue.Dequeue()}");

            int[] numbers = { 5, 3, 8, 4, 1, 2 };
            MaxHeap.Heapify(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine(numbers[i]);
            }

            System.Console.WriteLine($"The 2nd largest number in array is : {MaxHeap.GetKthLargest(numbers,2)}");
            System.Console.WriteLine($"The 3rd largest number in array is : {MaxHeap.GetKthLargest(numbers,3)}");
        }
    }
}
