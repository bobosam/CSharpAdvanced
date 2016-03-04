using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayManipulation
{
    public class ArrayManipulation
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();
            string[] strArr = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int size = strArr.Length;
            var numbers = new int[size];
            for (int index = 0; index < size; index++)
            {
                numbers[index] = int.Parse(strArr[index]);
            }

            string command = Console.ReadLine();
            while ("end" != command)
            {
                string[] commandArr = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                switch (commandArr[0])
                {
                    case "exchange":
                        int position = int.Parse(commandArr[1]);
                        if (0 > position || position > size - 1)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }

                        numbers = Exchange(numbers, position + 1);
                        break;
                    case "max":
                        string paramMax = commandArr[1];
                        int maxIndex = Max(numbers, paramMax);
                        break;
                    case "min":
                        string paramMin = commandArr[1];
                        int minIndex = Min(numbers, paramMin);
                        break;
                    case "first":
                        int countFirst = int.Parse(commandArr[1]);
                        string paramFirst = commandArr[2];
                        PrintFirstElements(numbers, countFirst, paramFirst);
                        break;
                    case "last":
                        int count = int.Parse(commandArr[1]);
                        string param = commandArr[2];
                        PrintLastElements(numbers, count, param);
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }

        private static void PrintLastElements(int[] numbers, int count, string param)
        {
            int size = numbers.Length;
            var listNumbers = new List<int>();
            for (int index = 0; index < size; index++)
            {
                if (param == "even" && numbers[index] % 2 == 0)
                {
                    listNumbers.Add(numbers[index]);
                }

                if (param == "odd" && numbers[index] % 2 != 0)
                {
                    listNumbers.Add(numbers[index]);
                }
            }

            if (size < count)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            if (listNumbers.Count < count)
            {
                count = listNumbers.Count;
            }

            var sb = new StringBuilder();
            sb.Append("[");
            for (int i = 0; i < count; i++)
            {
                sb.Append(listNumbers[count - i - 1] + ", ");
            }

            string result = sb.ToString().TrimEnd(' ').TrimEnd(',') + "]";
            Console.WriteLine(result);
        }

        private static void PrintFirstElements(int[] numbers, int count, string param)
        {
            int size = numbers.Length;
            var listNumbers = new List<int>();
            for (int index = 0; index < size; index++)
            {
                if (param == "even" && numbers[index] % 2 == 0)
                {
                    listNumbers.Add(numbers[index]);
                }

                if (param == "odd" && numbers[index] % 2 != 0)
                {
                    listNumbers.Add(numbers[index]);
                }
            }

            if (size < count)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            if (listNumbers.Count < count)
            {
                count = listNumbers.Count;
            }

            var sb = new StringBuilder();
            sb.Append("[");
            for (int i = 0; i < count; i++)
            {
                sb.Append(listNumbers[i] + ", ");
            }

            string result = sb.ToString().TrimEnd(' ').TrimEnd(',') + "]";
            Console.WriteLine(result);
        }

        private static int Min(int[] numbers, string paramMin)
        {
            int size = numbers.Length;
            int minNumber = int.MaxValue;
            int minIndex = -1;
            for (int index = 0; index < size; index++)
            {
                if ((numbers[index] % 2 == 0) && paramMin == "even" && numbers[index] <= minNumber)
                {
                    minNumber = numbers[index];
                    minIndex = index;
                }

                if ((numbers[index] % 2 != 0) && paramMin == "odd" && numbers[index] <= minNumber)
                {
                    minNumber = numbers[index];
                    minIndex = index;
                }
            }

            if (minIndex == -1)
            {
                Console.WriteLine("No matches");
                return -1;
            }

            Console.WriteLine(minIndex);
            return minIndex;
        }

        private static int Max(int[] numbers, string param)
        {
            int size = numbers.Length;
            int maxNumber = int.MinValue;
            int maxIndex = -1;
            for (int index = 0; index < size; index++)
            {
                if ((numbers[index] % 2 == 0) && param == "even" && numbers[index] >= maxNumber)
                {
                    maxNumber = numbers[index];
                    maxIndex = index;
                }

                if ((numbers[index] % 2 != 0) && param == "odd" && numbers[index] >= maxNumber)
                {
                    maxNumber = numbers[index];
                    maxIndex = index;
                }
            }

            if (maxIndex == -1)
            {
                Console.WriteLine("No matches");
                return -1;
            }

            Console.WriteLine(maxIndex);
            return maxIndex;
        }

        private static int[] Exchange(int[] numbers, int position)
        {
            return numbers.Skip(position).Concat(numbers.Take(position)).ToArray();
        }
    }
}
