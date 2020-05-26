using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 3, 1, 4, 6, 2, 3 };
            var sorter = new BubbleSort();
            sorter.Sort(numbers);
            foreach (var item in numbers)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
