using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 1, 3, 6, 5 };
            var searcher = new LinearSearch();
            var index = searcher.Search(numbers, 1);
            System.Console.WriteLine(index);
        }
    }
}
