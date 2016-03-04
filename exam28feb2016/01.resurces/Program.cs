using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.resurces
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] res = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int size = res.Length;
            var check = new int[size];
            long maxCount = 0;
            long count = 0;

            int numbeLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbeLines; i++)
            {
                string path = Console.ReadLine();
                string[] paths = path.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int start = int.Parse(paths[0]);
                int step = int.Parse(paths[1]);
                int pos = start;
                while (true)
                {
                    string[] curenntRes = res[pos % size].Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
                    if (curenntRes[0] != "stone" &&
                        curenntRes[0] != "gold" &&
                        curenntRes[0] != "wood" &&
                        curenntRes[0] != "food")
                    {
                        pos += step;
                        continue;
                    }
                    if (check[pos%size] == 1)
                    {
                        if (maxCount < count)
                        {
                            maxCount = count;
                            
                        }

                        break;
                    }

                    check[pos % size] = 1;
                    int curCount = 0;
                    if (curenntRes.Length == 1)
                    {
                        curCount = 1;
                    }
                    else
                    {
                        curCount = int.Parse(curenntRes[1]);
                    }

                    count += curCount;
                    pos += step;
                }

                count = 0;
            }

            Console.WriteLine(maxCount);
        }
    }
}
