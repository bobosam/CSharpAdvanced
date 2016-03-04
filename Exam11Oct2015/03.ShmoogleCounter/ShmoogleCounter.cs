using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.ShmoogleCounter
{
    public class ShmoogleCounter
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            string pattern = @"(int|double)\s([a-z][a-zA-Z]*)";
            var doubles = new List<string>();
            var ints = new List<string>();

            while (line != "//END_OF_CODE")
            {
                MatchCollection matches = Regex.Matches(line, pattern);
                foreach (Match match in matches)
                {
                    string tipe = match.Groups[1].ToString();
                    string values = match.Groups[2].ToString();

                    if (tipe == "int")
                    {
                        ints.Add(values);
                    }
                    else
                    {
                        doubles.Add(values);
                    }
                }

                line = Console.ReadLine();
            }

            doubles.Sort();
            ints.Sort();

            if (doubles.Count > 0)
            {
                Console.WriteLine("Doubles: {0}", string.Join(", ", doubles));
            }
            else
            {
                Console.WriteLine("Doubles: None");
            }


            if (ints.Count > 0)
            {
                Console.WriteLine("Ints: {0}", string.Join(", ", ints));
            }
            else
            {
                Console.WriteLine("Ints: None");
            }
        }
    }
}
