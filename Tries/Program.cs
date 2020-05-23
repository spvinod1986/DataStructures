using System;
using System.Linq;

namespace Tries
{
    class Program
    {
        static void Main(string[] args)
        {
            // var trie = new Trie();
            // trie.Insert("App");
            // trie.Insert("Apple");

            // System.Console.WriteLine($"Whether Apple Exists: {trie.Contains("Apple")}");
            // System.Console.WriteLine($"Whether App Exists: {trie.Contains("App")}");
            // System.Console.WriteLine($"Whether Mango Exists: {trie.Contains("Mango")}");

            // trie.PreOrderTraverse();
            // trie.PostOrderTraverse();

            // var trie2 = new Trie();
            // trie2.Insert("Car");
            // trie2.Insert("Care");

            // trie2.Remove("Care");
            // System.Console.WriteLine($"Whether Car Exists: {trie2.Contains("Car")}");
            // System.Console.WriteLine($"Whether Care Exists: {trie2.Contains("Care")}");

            var trie3 = new Trie();
            trie3.Insert("Car");
            trie3.Insert("Card");
            trie3.Insert("Care");
            trie3.Insert("Careful");
            trie3.Insert("Egg");
            var words = trie3.AutoComplete(null);
            if (words != null && words.Any())
            {
                foreach (var word in words)
                {
                    System.Console.WriteLine(word);
                }
            }
        }
    }
}
