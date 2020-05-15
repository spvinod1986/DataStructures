using System;

namespace Queues
{
    public class PriorityQueue
    {
        private int[] items;
        private int count;
        public PriorityQueue(int capacity)
        {
            items = new int[capacity];
        }

        public void Enqueue(int item)
        {
            if (items.Length == count)
                throw new InvalidOperationException("Priority Queue is full");

            if (count == 0)
            {
                items[count] = item;
                count++;
                return;
            }

            for (int i = count - 1; i >= 0; i--)
            {
                if (item > items[i])
                {
                    items[i + 1] = item;
                    break;
                }

                items[i + 1] = items[i];
                items[i] = item;
            }
            count++;
        }

        public int Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException("Priority Queue is Empty");
            var item = items[count - 1];
            items[count - 1] = 0;
            count--;
            return item;
        }
        public void Print()
        {
            Array.ForEach(items, System.Console.WriteLine);
        }
    }
}