using System;
using System.Collections.Generic;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new LinkedList();
            myList.AddFirst(10);
            myList.AddLast(20);
            myList.AddLast(30);
            myList.AddFirst(5);

            System.Console.WriteLine($"Index of 10 is {myList.IndexOf(10)}");
            System.Console.WriteLine($"Whether MyList Contains 100? {myList.Contains(100)}");
            System.Console.WriteLine($"What is the size MyList? {myList.Size()}");

            // myList.RemoveFirst();
            // myList.RemoveLast();

            myList.Reverse();
            System.Console.WriteLine("Printing the List");
            var myListArray = myList.ToArray();
            Array.ForEach(myListArray, System.Console.WriteLine);

            System.Console.WriteLine($"2nd value from end: {myList.GetKthFromTheEnd(2)}");
        }
    }
}
