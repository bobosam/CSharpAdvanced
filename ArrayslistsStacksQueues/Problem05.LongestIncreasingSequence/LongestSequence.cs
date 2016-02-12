namespace Problem05.LongestIncreasingSequence
{
    using System;

    public class LongestSequence
    {
        public static void Main()
        {
            Console.Write("Input line --> ");
            string inputString = Console.ReadLine();
            string[] stringArray = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int sizeArray = stringArray.Length;
            var intArray = new int[sizeArray];
            ParseInput(stringArray, sizeArray, intArray);
            int longestIndex = 0;
            int longestCount = 1;
            int count = 1;
            Console.Write(intArray[0] + " ");
            for (int index = 1; index < sizeArray; index++)
            {
                if (intArray[index] > intArray[index - 1])
                {
                    Console.Write(intArray[index] + " ");
                    count++;
                    if (count > longestCount)
                    {
                        longestCount = count;
                        longestIndex = index - count + 1;
                    }
                }
                else
                {
                    Console.Write(Environment.NewLine + intArray[index] + " ");
                    count = 1;
                }
            }

            Console.Write(Environment.NewLine + "Longest: ");
            for (int i = 0; i < longestCount; i++)
            {
                Console.Write(intArray[longestIndex + i] + " ");
            }

            Console.WriteLine();
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
