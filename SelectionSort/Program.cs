using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 3, 1, 5, 2 };
            var sorter = new SelectionSort();
            sorter.Sort(numbers);

            foreach (var item in numbers)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
