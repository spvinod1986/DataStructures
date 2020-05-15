using System.Collections.Generic;

namespace HashTables
{
    public class CharFinder
    {
        public char FindFirstNonRepeatingCharacter(string input)
        {
            var dictionary = new Dictionary<char, int>();

            foreach (var c in input)
            {
                if (dictionary.ContainsKey(c))
                {
                    var count = dictionary.GetValueOrDefault(c);
                    dictionary[c] = ++count;
                }
                else
                    dictionary.Add(c, 1);
            }

            foreach (var c in input)
            {
                if (dictionary.GetValueOrDefault(c) == 1)
                    return c;
            }

            return char.MinValue;
        }

        public char FindFirstRepeatedCharacter(string input)
        {
            var set = new HashSet<char>();

            foreach (var c in input)
            {
                if (set.Contains(c))
                    return c;

                set.Add(c);
            }

            return char.MinValue;
        }
    }
}