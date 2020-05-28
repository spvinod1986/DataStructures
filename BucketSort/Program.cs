using System;

namespace BucketSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 3, 1, 5, 2 };
            var sorter = new BucketSort();
            sorter.Sort(numbers, 3);

            foreach (var item in numbers)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
