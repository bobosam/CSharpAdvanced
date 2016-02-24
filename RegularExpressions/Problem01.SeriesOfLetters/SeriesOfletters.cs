namespace Problem01.SeriesOfLetters
{
    using System;
    using System.Text.RegularExpressions;

    public class SeriesOfletters
    {
        public static void Main()
        {
            Console.Write("Text --> ");
            string text = Console.ReadLine();
            string pattern;
            string replace;
            Regex regexReplace;

            for (int index = 0; index < text.Length; index++)
            {
                pattern = string.Format(@"{0}+", text[index]);
                replace = string.Format(@"{0}", text[index]);
                regexReplace = new Regex(pattern);
                text = regexReplace.Replace(text, replace);
            }

            Console.WriteLine(text);
        }
    }
}
