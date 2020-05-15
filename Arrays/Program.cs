using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList(3);
            numbers.Insert(10);
            numbers.Insert(20);
            numbers.Insert(30);
            numbers.Print();
            numbers.RemoveAt(2);
            numbers.Print();
            System.Console.WriteLine($"Index of 10 is {numbers.IndexOf(10)}");

        }
    }
}
