namespace Problem08.NightLife
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NightLife
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();
            var nightLife = new Dictionary<string, Dictionary<string, List<string>>>();

            while (inputLine != "END")
            {
                string[] inputSplit = inputLine.Split(';');
                string city = inputSplit[0];
                string venue = inputSplit[1];
                string performer = inputSplit[2];

                if (!nightLife.ContainsKey(city))
                {
                    nightLife.Add(city, new Dictionary<string, List<string>>());
                }

                if (!nightLife[city].ContainsKey(venue))
                {
                    nightLife[city].Add(venue, new List<string>());
                }

                nightLife[city][venue].Add(performer);

                inputLine = Console.ReadLine();
            }

            foreach (var elem in nightLife)
            {
                Console.WriteLine("{0}", elem.Key);
                var elems = elem.Value.OrderBy(x => x.Key);
                foreach (var l in elems)
                {
                    Console.WriteLine("->{0}: {1}", l.Key, string.Join(", ", l.Value.Distinct().OrderBy(x => x)));
                }
            }
        }
    }
}
