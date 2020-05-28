namespace BinarySearch
{
    public class BinarySearch
    {
        public int SearchRecursive(int[] array, int target)
        {
            return SearchRecursive(array, target, 0, array.Length - 1);
        }
        private int SearchRecursive(int[] array, int target, int left, int right)
        {
            if (right < left)
            {
                return -1;
            }
            var middleIndex = (left + right) / 2;

            if (array[middleIndex] == target)
            {
                return middleIndex;
            }

            if (target < array[middleIndex])
            {
                return SearchRecursive(array, target, left, middleIndex - 1);
            }

            return SearchRecursive(array, target, middleIndex + 1, right);
        }

        public int SearchIterative(int[] array, int target)
        {
            var left = 0;
            var right = array.Length - 1;

            while (left <= right)
            {
                var middleIndex = (left + right) / 2;

                if (array[middleIndex] == target)
                {
                    return middleIndex;
                }

                if (target < array[middleIndex])
                {
                    right = middleIndex - 1;
                }
                else
                {
                    left = middleIndex + 1;
                }
            }
            return -1;
        }
    }

}