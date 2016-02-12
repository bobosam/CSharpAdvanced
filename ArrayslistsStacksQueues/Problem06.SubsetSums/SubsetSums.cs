namespace Problem06.SubsetSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SubsetSums
    {
        public static void Main()
        {
            int sum;
            bool isNumber;
            Console.Write("Input Sum --> ");
            isNumber = int.TryParse(Console.ReadLine(), out sum);
            if (isNumber == false)
            {
                throw new ArgumentException("\nNot a number!");
            }

            Console.Write("Input line --> ");
            string inputLine = Console.ReadLine();
            string[] stringArray = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int sizeArray = stringArray.Length;
            var intArray = new int[sizeArray];
            ParseInput(stringArray, sizeArray, intArray);
            intArray = intArray.Distinct().ToArray();
            int size = intArray.Length;
            int countOfSubset = (1 << size) - 1;
            var subsList = new List<List<int>>();

            for (int i = 1; i <= countOfSubset; i++)
            {
                int index = 0;
                int bit = i;
                var subs = new List<int>();

                while (bit > 0)
                {
                    if ((bit & 1) == 1)
                    {
                        subs.Add(intArray[index]);
                    }

                    bit = bit >> 1;
                    index++;
                }

                if (subs.Sum() == sum)
                {
                    subs.Sort();
                    subsList.Add(subs);
                }
            }

            if (subsList.Count == 0)
            {
                Console.WriteLine("No matching subsets.");
            }
            else
            {
                var sortedList = subsList
                                        .OrderBy(subs => subs.Count)
                                        .ThenBy(subs => subs.First())
                                        .ToList();
                foreach (var list in sortedList)
                {
                    Console.WriteLine($"{string.Join(" + ", list)} = {sum}");
                }
            }
        }

        private static void ParseInput(string[] stringArray, int sizeArray, int[] intArray)
        {
            int number;
            bool isNumber;
            for (int index = 0; index < sizeArray; index++)
            {
                isNumber = int.TryParse(stringArray[index], out number);
                if (isNumber == false)
                {
                    throw new ArgumentException("\nNot a number");
                }

                intArray[index] = number;
            }
        }
    }
}
