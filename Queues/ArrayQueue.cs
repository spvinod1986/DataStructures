using System;

namespace Queues
{
    public class ArrayQueue
    {
        private int[] items;
        private int count;
        private int rear;
        private int front;

        public ArrayQueue(int capacity)
        {
            items = new int[capacity];
        }
        public void Enqueue(int item)
        {
            if (items.Length == count)
                throw new InvalidOperationException("Queue is full");

            items[rear] = item;
            //rear++; -> This will lead to IndexOutOfRangeException. Use Circular arrays instead
            rear = (rear + 1) % items.Length;
            count++;
        }

        public int Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException("Queue is Empty");

            var frontItem = items[front];
            items[front] = 0;
            //front++;  -> This will lead to IndexOutOfRangeException. Use Circular arrays instead
            front = (front + 1) % items.Length;
            count--;
            return frontItem;
        }

        public void Print()
        {
            Array.ForEach(items, System.Console.WriteLine);
        }
    }
}