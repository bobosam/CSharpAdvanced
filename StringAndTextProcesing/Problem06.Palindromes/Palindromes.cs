namespace Problem06.Palindromes
{
    using System;
    using System.Collections.Generic;

    public class Palindromes
    {
        public static void Main()
        {
            Console.Write("Text --> ");
            string text = Console.ReadLine();
            string[] wordsArr = text.Split(
                new char[] { ' ', ',', '.', '?', '!' },
                StringSplitOptions.RemoveEmptyEntries);
            var palindromes = new SortedSet<string>();

            foreach (var word in wordsArr)
            {
                var charArr = word.ToCharArray();
                Array.Reverse(charArr);
                string reverseWord = new string(charArr);

                if (word == reverseWord)
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}
