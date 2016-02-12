using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinLists
{
    public class Joinlists
    {
        public static void Main(string[] args)
        {
            string firstInputString = Console.ReadLine();
            string secondInputString = Console.ReadLine();

            string[] firstStringArray = SplitInput(firstInputString);
            string[] secondStringArray = SplitInput(secondInputString);

            int firstArraySize = firstStringArray.Length;
            var firstArray = new int[firstArraySize];
            ParseInput(firstStringArray, firstArraySize, firstArray);

            int secondArraySize = secondStringArray.Length;
            var secondArray = new int[secondArraySize];
            ParseInput(secondStringArray, secondArraySize, secondArray);

            var ressultArray = new List<int>();

            AddNumbers(firstArraySize, firstArray, ressultArray);
            AddNumbers(secondArraySize, secondArray, ressultArray);

            ressultArray.Sort();

            Console.WriteLine(string.Join(", ", ressultArray));
        }

        private static void AddNumbers(int size, int[] inputArray, List<int> ressultArray)
        {
            bool check = true;

            for (int index = 0; index < size; index++)
            {
                for (int i = 0; i < ressultArray.Count; i++)
                {
                    if (inputArray[index] == ressultArray[i])
                    {
                        check = false;
                        break;
                    }
                }

                if (check == true)
                {
                    ressultArray.Add(inputArray[index]);
                }

                check = true;
            }
        }

        private static void ParseInput(string[] firstStringArray, int size, int[] firstArray)
        {
            for (int index = 0; index < size; index++)
            {
                int number;
                bool isNumber = int.TryParse(firstStringArray[index], out number);
                if (isNumber == false)
                {
                    Console.WriteLine("Not a number!");
                    Environment.Exit(1);
                }

                firstArray[index] = number;
            }
        }

        private static string[] SplitInput(string inputString)
        {
            string[] stringArray = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return stringArray;
        }
    }
}