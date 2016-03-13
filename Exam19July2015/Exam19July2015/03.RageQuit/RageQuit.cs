namespace _03.RageQuit
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class RageQuit
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string pattern = @"([^0-9]+)([0-9]+)";
            
            MatchCollection matches = Regex.Matches(inputLine, pattern);
            var sb = new StringBuilder();

            foreach (Match match in matches)
            {
                string text = match.Groups[1].Value.ToUpper();                              
                int count = int.Parse(match.Groups[2].Value);
                
                for (int i = 0; i < count; i++)
                {
                    sb.Append(text);
                }
            }

            Console.WriteLine("Unique symbols used: {0}", sb.ToString().Distinct().Count());
            Console.WriteLine(sb);
        }
    }
}
