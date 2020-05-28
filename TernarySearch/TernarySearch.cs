namespace TernarySearch
{
    public class TernarySearch
    {
        public int Search(int[] array, int target)
        {
            return Search(array, target, 0, array.Length - 1);
        }
        private int Search(int[] array, int target, int left, int right)
        {
            if (right < left)
            {
                return -1;
            }

            var partitionSize = (right - left) / 3;
            var middleIndex1 = left + partitionSize;
            var middleIndex2 = right - partitionSize;

            if (array[middleIndex1] == target)
            {
                return middleIndex1;
            }

            if (array[middleIndex2] == target)
            {
                return middleIndex2;
            }

            if (target < array[middleIndex1])
            {
                return Search(array, target, left, middleIndex1 - 1);
            }

            if (target > array[middleIndex2])
            {
                return Search(array, target, middleIndex2 + 1, right);
            }

            return Search(array, target, middleIndex1 + 1, middleIndex2 - 1);
        }
    }
}