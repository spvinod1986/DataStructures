using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 3, 1, 5, 2 };
            var sorter = new QuickSort();
            sorter.Sort(numbers);

            foreach (var item in numbers)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
