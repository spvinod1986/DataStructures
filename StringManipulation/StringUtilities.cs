using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringManipulation
{
    public class StringUtilities
    {
        public static int CountVowels(string input)
        {
            if (input == null)
            {
                return 0;
            }
            var count = 0;
            var vowels = "aeiou";
            foreach (var ch in input.ToLowerInvariant())
            {
                if (vowels.Contains(ch))
                {
                    count++;
                }
            }
            return count;
        }

        public static string Reverse(string input)
        {
            if (input == null)
            {
                return string.Empty;
            }
            var reversed = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }

            return reversed.ToString();
        }

        public static string ReverseWords(string input)
        {
            if (input == null)
            {
                return string.Empty;
            }
            var words = input.Split(' ');

            var reversed = new StringBuilder();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversed.Append(words[i] + ' ');
            }
            return reversed.ToString().Trim();
        }

        public static string ReverseWordsAnoterOption(string input)
        {
            if (input == null)
            {
                return string.Empty;
            }

            var words = input.Trim().Split(' ');
            Array.Reverse(words);
            return string.Join(' ', words);
        }

        public static bool AreRotations(string input1, string input2)
        {
            if (input1 == null || input2 == null)
            {
                return false;
            }

            return (input1.Length == input2.Length && (input1 + input1).Contains(input2));
        }

        public static string RemoveDuplicates(string input)
        {
            if (input == null)
            {
                return string.Empty;
            }
            var output = new StringBuilder();
            var uniqueCharacters = new HashSet<char>();

            foreach (var character in input)
            {
                if (!uniqueCharacters.Contains(character))
                {
                    uniqueCharacters.Add(character);
                    output.Append(character);
                }
            }
            return output.ToString();
        }

        public static char GetMostOccuringCharacter(string input)
        {
            if (input == null)
            {
                return '\0';
            }
            var frequencies = new Dictionary<char, int>();

            foreach (var character in input)
            {
                if (frequencies.ContainsKey(character))
                {
                    frequencies[character]++;
                }
                else
                {
                    frequencies.Add(character, 1);
                }
            }
            return frequencies.Aggregate((f, s) => f.Value > s.Value ? f : s).Key;
        }

        public static char GetMostOccuringCharacterAnotherOption(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new InvalidOperationException("The input cannot be empty");
            }
            const int ASCII_SIZE = 256;
            var frequencies = new int[ASCII_SIZE];

            foreach (var character in input)
            {
                frequencies[character]++;
            }

            int max = 0;
            char result = '\0';
            for (int i = 0; i < frequencies.Length; i++)
            {
                if (frequencies[i] > max)
                {
                    max = frequencies[i];
                    result = (char)i;
                }
            }
            return result;
        }

        public static string Capitalize(string input)
        {
            if (string.IsNullOrEmpty(input.Trim()))
            {
                return string.Empty;
            }
            var words = input.Trim().Replace(" +", " ").Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Substring(0, 1).ToUpperInvariant() + words[i].Substring(1).ToLowerInvariant();
            }
            return string.Join(" ", words);
        }

        public static bool AreAnagrams(string input1, string input2)
        {
            if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2) || input1.Length != input2.Length)
            {
                return false;
            }
            var array1 = input1.ToLowerInvariant().ToArray();
            Array.Sort(array1);
            var array2 = input2.ToLowerInvariant().ToArray();
            Array.Sort(array2);
            return Enumerable.SequenceEqual(array1, array2);
        }

        public static bool AreAnagramsUsingHistogram(string input1, string input2)
        {
            if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2) || input1.Length != input2.Length)
            {
                return false;
            }

            const int ENGLISH_ALPHABET = 26;
            var frequencies = new int[ENGLISH_ALPHABET];

            for (int i = 0; i < input1.Length; i++)
            {
                frequencies[input1[i] - 64]++;
            }

            for (int i = 0; i < input2.Length; i++)
            {
                if (frequencies[input2[i] - 64] == 0)
                {
                    return false;
                }
                frequencies[input2[i] - 64]--;
            }

            return true;
        }

        public static bool isPalindrome(string input)
        {
            var reversed = input.Reverse();
            var reversedString = new String(reversed.ToArray());

            if (string.Equals(input.ToLowerInvariant(), reversedString.ToLowerInvariant()))
            {
                return true;
            }
            return false;
        }

        public static bool isPalindromeAnotherOption(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                if (char.ToLowerInvariant(input[left]) != char.ToLowerInvariant(input[right]))
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }
}