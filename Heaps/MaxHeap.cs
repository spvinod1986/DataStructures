using System;
namespace Heaps
{
    public class MaxHeap
    {
        public static void Heapify(int[] array)
        {
            var lastParentIndex = array.Length / 2 - 1;
            for (int i = lastParentIndex; i >= 0; i--)
            {
                Heapify(array, i);
            }
        }

        private static void Heapify(int[] array, int index)
        {
            var largerIndex = index;

            var leftIndex = index * 2 + 1;
            if (leftIndex < array.Length && array[leftIndex] > array[largerIndex])
                largerIndex = leftIndex;

            var rightIndex = index * 2 + 2;
            if (rightIndex < array.Length && array[rightIndex] > array[largerIndex])
                largerIndex = rightIndex;

            if (index == largerIndex)
                return;

            Swap(array, index, largerIndex);
            Heapify(array, largerIndex);
        }

        private static void Swap(int[] array, int index1, int index2)
        {
            var temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        public static int GetKthLargest(int[] array, int k)
        {
            if (k < 1 || k > array.Length)
            {
                throw new ArgumentException("Value for k is not valid");
            }
            var heap = new Heap(10);
            foreach (var item in array)
            {
                heap.Insert(item);
            }

            for (int i = 0; i < k - 1; i++)
            {
                heap.Remove();
            }
            return heap.Max();
        }
    }
}