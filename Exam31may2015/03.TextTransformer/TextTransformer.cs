using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.TextTransformer
{
    public class TextTransformer
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            var sb = new StringBuilder();
            while (line != "burp")
            {
                sb = sb.Append(line);
                line = Console.ReadLine();
            }
            string inputText = sb.ToString();

            string spacePattern = @"\s{2,}";
            string text = Regex.Replace(inputText, spacePattern, " ");

            string textPatern = @"([$%&'])([^$%&']+)\1";
            MatchCollection matches = Regex.Matches(text, textPatern);
            foreach (Match match in matches)
            {
                string simbol = match.Groups[1].Value;
                string partText = match.Groups[2].Value;
                int weight = 0;
                if (simbol == "$")
                {
                    weight = 1;
                }

                if (simbol == "%")
                {
                    weight = 2;
                }

                if (simbol == "&")
                {
                    weight = 3;
                }

                if (simbol == "'")
                {
                    weight = 4;
                }

                char[] output = partText.ToCharArray();

                for (int index = 0; index < output.Length; index++)
                {
                    if (index % 2 == 0)
                    {
                        Console.Write((char)(output[index] + weight));
                    }
                    else
                    {
                        Console.Write((char)(output[index] - weight));
                    }
                }

                Console.Write(" ");
            }
        }
    }
}
