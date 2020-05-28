using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(StringUtilities.CountVowels("Hello World"));
            System.Console.WriteLine(StringUtilities.Reverse("Hello World"));
            System.Console.WriteLine(StringUtilities.ReverseWords("This is out of the world"));
            System.Console.WriteLine(StringUtilities.ReverseWordsAnoterOption("This is out of the world"));
            System.Console.WriteLine(StringUtilities.AreRotations("ABCD", "CDBA"));
            System.Console.WriteLine(StringUtilities.AreRotations("ABCD", "CDAB"));
            System.Console.WriteLine(StringUtilities.RemoveDuplicates("Trees"));
            System.Console.WriteLine(StringUtilities.GetMostOccuringCharacter("Trees"));
            System.Console.WriteLine(StringUtilities.GetMostOccuringCharacterAnotherOption("Trees"));
            System.Console.WriteLine(StringUtilities.Capitalize("today is a beautiful day"));
            System.Console.WriteLine(StringUtilities.AreAnagrams("ABCD", "DBCA"));
            System.Console.WriteLine(StringUtilities.AreAnagrams("ABCD", "DECA"));
            System.Console.WriteLine(StringUtilities.AreAnagramsUsingHistogram("ABCD", "DBCA"));
            System.Console.WriteLine(StringUtilities.AreAnagramsUsingHistogram("ABCD", "DECA"));
            System.Console.WriteLine(StringUtilities.isPalindrome("Madam"));
            System.Console.WriteLine(StringUtilities.isPalindrome("Palindrome"));
            System.Console.WriteLine(StringUtilities.isPalindromeAnotherOption("Madam"));
            System.Console.WriteLine(StringUtilities.isPalindromeAnotherOption("Palindrome"));
        }
    }
}
