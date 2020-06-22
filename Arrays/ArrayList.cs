using System;

namespace Arrays
{
    public class ArrayList
    {
        private int[] items;
        private int count = 0;
        public ArrayList(int length)
        {
            items = new int[length];
        }

        public void Insert(int item) // O(n)
        {
            if (items.Length == count + 1)
            {
                int[] newItems = new int[count * 2];

                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }

                items = newItems;
            }
            items[count] = item;
            count++;
        }

        public void RemoveAt(int index) // O(n)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("The index is invalid");

            for (int i = index; i < count; i++)
            {
                items[i] = items[i + 1];
            }

            count--;
        }

        public int IndexOf(int item) // O(n)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i] == item)
                    return i;
            }

            return -1;
        }
        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                System.Console.WriteLine(items[i]);
            }
        }
    }
}