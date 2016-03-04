using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Events
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var cities = new SortedSet<string>();
            var dict = new Dictionary<string, SortedDictionary<string, List<DateTime>>>();
            string city;
            string name;
            for (int i = 0; i < count; i++)
            {
                string inputLine = Console.ReadLine();
                string pattern = @"^#([a-zA-z]+):\s*@([a-zA-z]+)\s*([0-9]+:[0-9]+)$";
                Regex regex = new Regex(pattern);
                Match match = regex.Match(inputLine);
                if (!match.Success)
                {
                    continue;
                }

                city = match.Groups[2].Value;
                name = match.Groups[1].Value;
                string time = match.Groups[3].Value;
                DateTime dateTime;
                if (!DateTime.TryParse(time, out dateTime))
                {
                    continue;
                }
                if (!dict.ContainsKey(city))
                {
                    dict.Add(city, new SortedDictionary<string, List<DateTime>>());
                }

                if (!dict[city].ContainsKey(name))
                {
                    dict[city].Add(name, new List<DateTime>());
                }

                dict[city][name].Add(dateTime);
            }

            string last = Console.ReadLine();
            string[] lastes = last.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var c in lastes)
            {
                cities.Add(c);
            }



            string format = "HH:mm";
            foreach (var c in cities)
            {
                Console.WriteLine("{0}:", c);
                int pos = 1;
                foreach (var p in dict[c].Keys)
                {
                    var listTimes = new List<DateTime>();
                    foreach (var t in dict[c][p])
                    {
                        listTimes.Add(t);
                    }

                    listTimes.Sort();
                    var sb = new StringBuilder();
                    foreach (var t in listTimes)
                    {
                        string tim = t.ToString(format);
                        sb.Append(tim + ", ");
                    }
                    string strTime = sb.ToString().TrimEnd().TrimEnd(',');
                    Console.Write("{0}. {1} -> {2}", pos, p, strTime);

                    pos++;
                    Console.WriteLine();
                }


            }
        }
    }
}
