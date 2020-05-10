using System;

namespace BigO
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] moreNumbers = { 11, 2, 3, 2, 3, 4, 5, 6, 7, 8, 9, 6, 57, 4, 5, 6, 7, 4 };

            // O(1)
            System.Console.WriteLine("Output for O(1) example:");
            Constant(numbers);
            Constant(moreNumbers);

            // O(n)
            System.Console.WriteLine("Output for O(n) example:");
            Linear(numbers);
            Linear(moreNumbers);

            // O(n^2)
            System.Console.WriteLine("Output for O(n^2) example:");
            Quadratic(numbers);
        }

        // O(1)
        private static void Constant(int[] numbers)
        {
            // Algorithm to print first number in array of numbers
            System.Console.WriteLine(numbers[0]);
        }

        // O(n)
        private static void Linear(int[] numbers)
        {
            // Algorithm to print all number in array of numbers
            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }
        }

        // O(n^2)
        private static void Quadratic(int[] numbers)
        {
            // Algorithm to print all number in array of numbers
            foreach (var outernumber in numbers)
            {
                foreach (var innernumber in numbers)
                {
                    System.Console.WriteLine(outernumber + innernumber);
                }
            }
        }

        // O(log n)
        private static void Logarithmic()
        {
            throw new NotImplementedException();
        }

        // O(2^n)
        private static void Exponential()
        {
            throw new NotImplementedException();
        }
    }
}
