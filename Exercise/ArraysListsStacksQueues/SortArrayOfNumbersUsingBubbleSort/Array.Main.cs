namespace SortArrayOfNumbersUsingBubbleSort
{
    using System;

    public class ArrayMain
    {
        public static void Main()
        {
            string inputString = Console.ReadLine();
            string[] stringArray = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int arraySize = stringArray.Length;
            var intArray = new int[arraySize];

            for (int index = 0; index < arraySize; index++)
            {
                int number = 0;
                bool isNumber = int.TryParse(stringArray[index], out number);
                if (isNumber == false)
                {
                    Console.WriteLine("Not a number!");
                    Environment.Exit(1);
                }

                intArray[index] = number;
            }

            BubbleSort(arraySize, intArray);

            Console.WriteLine(string.Join(", ", intArray));
        }

        private static void BubbleSort(int arraySize, int[] intArray)
        {
            bool isSwaped = true;
            while (isSwaped == true)
            {
                isSwaped = false;
                for (int index = 0; index < arraySize - 1; index++)
                {
                    if (intArray[index] > intArray[index + 1])
                    {
                        Swap(intArray, index);
                        isSwaped = true;
                    }
                }
            }
        }

        private static void Swap(int[] intArray, int index)
        {
            int oldValue = intArray[index];
            intArray[index] = intArray[index + 1];
            intArray[index + 1] = oldValue;
        }
    }
}
