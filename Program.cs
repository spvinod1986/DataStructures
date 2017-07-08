using System;
using LinkedList;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<int> mylist = new LinkedList<int>();
            mylist.AddFirst(1);
            mylist.AddFirst(2);
            mylist.AddLast(3);

            PrintItems<int>(mylist, "Initial List:");

            mylist.Remove(2);

            PrintItems<int>(mylist, "After removing 2:");

            mylist.RemoveFirst();
            PrintItems<int>(mylist, "After removing First Item:");

            mylist.RemoveLast();
            PrintItems<int>(mylist, "After removing Last item:");

        }

        public static void PrintItems<T>(LinkedList<T> myList, string message)
        {
            System.Console.WriteLine(message);
            foreach (T item in myList)
            {
                
                System.Console.WriteLine(item.ToString());
            }

        }

    }
}

