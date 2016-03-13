namespace _04.Champions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Champions
    {
        public static void Main()
        {
            var db = new Dictionary<string, Dictionary<string, int>>();

            string line = Console.ReadLine();

            while (line != "stop")
            {
                string[] data = line.Split('|');
                string first = data[0].Trim();
                string second = data[1].Trim();
                string[] firstStrGoals = data[2].Split(':');
                string[] secondStrGoals = data[3].Split(':');

                int firstHGoals = int.Parse(firstStrGoals[0]);
                int secondHGoals = int.Parse(secondStrGoals[1]);
                int firstVGoals = int.Parse(firstStrGoals[1]);
                int secondVGoals = int.Parse(secondStrGoals[0]);
                int indexH = 0;
                int indexV = 0;

                if ((firstHGoals + secondHGoals) > (firstVGoals + secondVGoals))
                {
                    indexH = 1;
                    indexV = 0;
                }

                if ((firstHGoals + secondHGoals) < (firstVGoals + secondVGoals))
                {
                    indexH = 0;
                    indexV = 1;
                }

                if ((firstHGoals + secondHGoals) == (firstVGoals + secondVGoals))
                {
                    if (firstVGoals > secondHGoals)
                    {
                        indexV = 1;
                        indexH = 0;
                    }
                    else
                    {
                        indexV = 0;
                        indexH = 1;
                    }
                }

                if (!db.ContainsKey(first))
                {
                    db.Add(first, new Dictionary<string, int>());
                }

                if (!db.ContainsKey(second))
                {
                    db.Add(second, new Dictionary<string, int>());
                }

                db[first].Add(second, indexH);
                db[second].Add(first, indexV);

                line = Console.ReadLine();
            }

            var sortTeams = db
                                .OrderByDescending(x => x.Value.Sum(y => y.Value))
                                .ThenBy(x => x.Key);

            foreach (var team in sortTeams)
            {
                Console.WriteLine(team.Key);
                int wins = team.Value.Sum(x => x.Value);
                Console.WriteLine("- Wins: {0}", wins);
                var oponents = new List<string>();
                foreach (var op in team.Value.Keys)
                {
                    oponents.Add(op);
                }

                oponents.Sort();
                Console.WriteLine("- Opponents: {0}", string.Join(", ", oponents));
            }
        }
    }
}
