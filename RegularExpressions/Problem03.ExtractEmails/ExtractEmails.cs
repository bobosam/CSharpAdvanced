namespace Problem03.ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@[a-z]+\-?[a-z]+(?:\.[a-z]+)+)\b";
            Regex regex = new Regex(pattern);
            MatchCollection mails = regex.Matches(text);
            foreach (Match mail in mails)
            {
                Console.WriteLine(mail.Groups[0]);
            }
        }
    }
}
