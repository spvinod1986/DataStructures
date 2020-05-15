using System;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            var charFinder = new CharFinder();
            var nonRepeatChar = charFinder.FindFirstNonRepeatingCharacter("a apple product");
            var repeatChar = charFinder.FindFirstRepeatedCharacter("a apple product");
            System.Console.WriteLine($"The first non repeat character is {nonRepeatChar}");
            System.Console.WriteLine($"The first repeated character is {repeatChar}");

            var hashTable = new HashTable(5);
            hashTable.Put(1, "A");
            hashTable.Put(2, "B");
            hashTable.Put(6, "C");
            System.Console.WriteLine($"Get value for key 6: {hashTable.Get(6)}");
            hashTable.Put(6, "D");
            System.Console.WriteLine($"Get value for key 6 after Update: {hashTable.Get(6)}");
            hashTable.Remove(6);
            System.Console.WriteLine($"Get value for key 6 after Remove: {hashTable.Get(6)}");
        }
    }
}
