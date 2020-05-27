using System;

namespace JumpSearch
{
    public class JumpSearch
    {
        public int Search(int[] array, int target)
        {
            var blockSize = (int)Math.Sqrt(array.Length);
            int start = 0;
            int next = blockSize;

            while (start < array.Length && array[next - 1] < target)
            {
                start = next;
                next = next + blockSize;
                if (next > array.Length)
                {
                    next = array.Length;
                }
            }

            for (int i = start; i < next; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}