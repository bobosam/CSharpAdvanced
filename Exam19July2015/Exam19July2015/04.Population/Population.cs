using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Population
{
    public class Population
    {
        public static void Main()
        {
            var popData = new Dictionary<string, Dictionary<string, long>>();
            string line = Console.ReadLine();

            while (line != "report")
            {
                string[] lineArr = line.Split('|');
                string city = lineArr[0];
                string country = lineArr[1];
                long population = long.Parse(lineArr[2]);

                if (!popData.ContainsKey(country))
                {
                    popData.Add(country, new Dictionary<string, long>());
                }

                popData[country].Add(city, population);
                line = Console.ReadLine();
            }

            var sortCountry = popData
                                .OrderByDescending(x => x.Value.Sum(y => y.Value));

            foreach (var country in sortCountry)
            {
                //Bulgaria(total population: 1000000)
                long totalPop = country.Value.Sum(x => x.Value);
                Console.WriteLine("{0} (total population: {1})", country.Key, totalPop);
                var sortedCity = country.Value
                    .OrderByDescending(x => x.Value);
                foreach (var city in sortedCity)
                {
                    Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                }
            }
        }
    }
}
