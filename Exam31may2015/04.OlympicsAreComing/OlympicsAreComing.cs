using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.OlympicsAreComing
{
    public class OlympicsAreComing
    {
        public static void Main()
        {
            var countryData = new Dictionary<string, Dictionary<string, int>>();
            string line = Console.ReadLine();
            while (line != "report")
            {
                string[] data = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                string name = Regex.Replace(data[0].Trim(), @"\s+", " ");
                string country = Regex.Replace(data[1].Trim(), @"\s+", " ");
                

                if (!countryData.ContainsKey(country))
                {
                    countryData.Add(country, new Dictionary<string, int>());
                    countryData[country][name] = 0;
                }

                if (!countryData[country].ContainsKey(name))
                {
                    countryData[country].Add(name, 0);
                }

                countryData[country][name] += 1;

                line = Console.ReadLine();
            }

            var ordered = countryData.OrderByDescending(w => w.Value.Values.Sum());
                           

            foreach (var data in ordered)
            {
                string coun = data.Key;
                int pip = data.Value.Keys.Count;
                int win = data.Value.Values.Sum();
                Console.WriteLine("{0} ({1} participants): {2} wins", coun, pip, win);
            }
        }
    }
}
