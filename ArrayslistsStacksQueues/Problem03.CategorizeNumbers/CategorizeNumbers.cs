namespace Problem03.CategorizeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CategorizeNumbers
    {
        public const string FormatString = "[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:0.00}";

        public static void Main()
        {
            Console.Write("Enter line numbers --> ");
            string inputLine = Console.ReadLine();
            string[] stringArray = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int size = stringArray.Length;
            var roundNumbers = new List<int>();
            var floatNumbers = new List<double>();
            for (int index = 0; index < size; index++)
            {
                double number = ParseInput(stringArray, index);

                if (number % 1 == 0)
                {
                    roundNumbers.Add((int)number);
                }
                else
                {
                    floatNumbers.Add(number);
                }
            }

            Console.WriteLine();
            Console.WriteLine(
                                FormatString,
                                string.Join(", ", floatNumbers),
                                floatNumbers.Min(),
                                floatNumbers.Max(),
                                floatNumbers.Sum(),
                                floatNumbers.Average());
            Console.WriteLine();
            Console.WriteLine(
                                FormatString,
                                string.Join(", ", roundNumbers),
                                roundNumbers.Min(),
                                roundNumbers.Max(),
                                roundNumbers.Sum(),
                                roundNumbers.Average());
            Console.WriteLine();
        }

        private static double ParseInput(string[] stringArray, int index)
        {
            double number;
            bool isNumber = double.TryParse(stringArray[index], out number);
            if (isNumber == false)
            {
                Console.WriteLine("Not a number!");
                Environment.Exit(1);
            }

            return number;
        }
    }
}
