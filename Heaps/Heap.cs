using System;

namespace Heaps
{
    public class Heap
    {
        private int[] items;
        private int size;
        public Heap(int capacity)
        {
            items = new int[capacity];
        }

        public void Insert(int value)
        {
            if (size == items.Length)
            {
                throw new InvalidOperationException("Heap is full");
            }

            items[size] = value;
            size++;

            BubbleUp();
        }

        // We always remove root node
        public int Remove()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Heap is Empty");
            }
            var root = items[0];
            items[0] = items[size - 1];
            size--;

            BubbleDown();
            return root;
        }
        private void BubbleDown()
        {
            var index = 0;
            while (index <= size && !IsValidParent(index))
            {
                var largerChildIndex = LargerChildIndex(index);

                Swap(index, largerChildIndex);
                index = largerChildIndex;
            }
        }
        private bool IsValidParent(int index)
        {
            if (!HasLeftChild(index))
                return true;

            if (!HasRightChild(index))
                return items[index] <= LeftChild(index);

            return items[index] >= items[LeftChildIndex(index)]
                    && items[index] >= items[RightChildIndex(index)];
        }
        private int LeftChild(int index)
        {
            return items[LeftChildIndex(index)];
        }
        private int RightChild(int index)
        {
            return items[RightChildIndex(index)];
        }
        private int LargerChildIndex(int index)
        {
            if (!HasLeftChild(index))
                return index;

            if (!HasRightChild(index))
                return LeftChildIndex(index);

            return LeftChild(index) > RightChild(index) ?
                                        LeftChildIndex(index) : RightChildIndex(index);
        }
        private int LeftChildIndex(int index)
        {
            return (index * 2) + 1;
        }
        private int RightChildIndex(int index)
        {
            return (index * 2) + 2;
        }
        private bool HasLeftChild(int index)
        {
            return LeftChildIndex(index) <= size;
        }
        private bool HasRightChild(int index)
        {
            return RightChildIndex(index) <= size;
        }
        private void BubbleUp()
        {
            var index = size - 1;

            while (index > 0 && items[index] > items[ParentIndex(index)])
            {
                Swap(index, ParentIndex(index));
                index = ParentIndex(index);
            }
        }

        private int ParentIndex(int index)
        {
            return (index - 1) / 2;
        }
        private void Swap(int firstIndex, int secondIndex)
        {
            var temp = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = temp;
        }

        public int Max()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Heap is Empty");
            }
            return items[0];
        }
        public void Print()
        {
            for (int i = 0; i < size; i++)
            {
                System.Console.WriteLine(items[i]);
            }
        }
    }
}