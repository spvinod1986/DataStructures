namespace BubbleSort
{
    public class BubbleSort
    {
        public void Sort(int[] array)
        {
            var isSorted = true;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length - i; j++)
                {
                    if (array[j] < array[j - 1])
                    {
                        var temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                        isSorted = false;
                    }
                    if (isSorted)
                    {
                        return;
                    }
                }
            }
        }
    }
}