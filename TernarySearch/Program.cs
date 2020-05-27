using System;

namespace TernarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 6, 7 };
            var searcher = new TernarySearch();

            System.Console.WriteLine($"Recursive Search Result is : {searcher.Search(numbers, 5)}");
        }
    }
}
