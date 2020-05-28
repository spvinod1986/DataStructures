using System;

namespace CountingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 1, 7, 2, 6, 4 };
            var sorter = new CountingSort();
            sorter.Sort(numbers, 7);

            foreach (var item in numbers)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
