namespace Problem02.SortArrayUsingSelectionSort
{
    using System;

    public class SelectionSortArray
    {
        public static void Main()
        {
            Console.Write("Enter input line --> ");
            string inputString = Console.ReadLine();

            string[] stringArray = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int size = stringArray.Length;
            var intArray = new int[size];
            ParseInput(stringArray, size, intArray);
            SelectionSort(size, intArray);
            Console.WriteLine(string.Join(" ", intArray));
        }

        private static void SelectionSort(int size, int[] intArray)
        {
            for (int index = 0; index < size - 1; index++)
            {
                int indexMinNumber = index;
                for (int i = index + 1; i < size; i++)
                {
                    if (intArray[indexMinNumber] > intArray[i])
                    {
                        indexMinNumber = i;
                    }
                }

                if (indexMinNumber != index)
                {
                    Swap(intArray, index, indexMinNumber);
                }
            }
        }

        private static void Swap(int[] intArray, int index, int indexMinNumber)
        {
            int oldValue = intArray[index];
            intArray[index] = intArray[indexMinNumber];
            intArray[indexMinNumber] = oldValue;
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
