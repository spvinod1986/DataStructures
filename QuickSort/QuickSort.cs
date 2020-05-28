namespace QuickSort
{
    public class QuickSort
    {
        public void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }
        private void Sort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            var boundary = Partition(array, start, end);

            Sort(array, start, boundary - 1);
            Sort(array, boundary + 1, end);
        }

        private int Partition(int[] array, int start, int end)
        {
            var pivot = array[end];
            var boundary = start - 1;

            for (int i = start; i <= end; i++)
            {
                if (array[i] <= pivot)
                {
                    boundary++;

                    var temp = array[i];
                    array[i] = array[boundary];
                    array[boundary] = temp;
                }
            }
            return boundary;
        }
    }
}