using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 6, 7 };
            var searcher = new BinarySearch();

            System.Console.WriteLine($"Recursive Search Result is : {searcher.SearchRecursive(numbers, 5)}");
            System.Console.WriteLine($"Iterative Search Result is : {searcher.SearchIterative(numbers, 5)}");
        }
    }
}
