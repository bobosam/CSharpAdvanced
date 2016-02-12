namespace Problem01.SortArray
{
    using System;

    public class ArreyOfNumbers
    {
        public static void Main()
        {
            Console.Write("Enter input line --> ");
            string inputString = Console.ReadLine();

            string[] stringArray = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int size = stringArray.Length;

            var intArray = new int[size];
            ParseInput(stringArray, size, intArray);
            Array.Sort(intArray);

            Console.WriteLine(string.Join(" ", intArray));
        }

        private static void ParseInput(string[] stringArray, int size, int[] intArray)
        {
            int number;
            bool isNumber;
            for (int index = 0; index < size; index++)
            {
                isNumber = int.TryParse(stringArray[index], out number);
                if (isNumber == false)
                {
                    Console.WriteLine("Not a number!");
                    Environment.Exit(1);
                }

                intArray[index] = number;
            }
        }
    }
}
