namespace Problem02.ReplaceATag
{
    using System;
    using System.Text.RegularExpressions;

    public class ReplaceATag
    {
        public static void Main()
        {
            string firstText = "<ul><li><a href=\"http://softuni.bg\">SoftUni</a></li></ul>";
            string secondText = "<ul><li><a href=\'http://softuni.bg\'>SoftUni</a></li></ul>";
            string pattern = @"<a.*href=((?:.|\n)*?(?=>))>((?:.|\n)*?(?=<))<\/a>";
            string replace = @"[URL href=http://$1]$2[/URL]";
            string replaced = Regex.Replace(firstText, pattern, replace);
            Console.WriteLine(replaced);
            replaced = Regex.Replace(secondText, pattern, replace);
            Console.WriteLine(replaced);
        }
    }
}
