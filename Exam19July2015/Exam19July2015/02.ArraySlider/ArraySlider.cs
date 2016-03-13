using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.ArraySlider
{
    public class ArraySlider
    {
        public static void Main()
        {
            string pattern = @"\s+";
            string inputLine = Console.ReadLine();
            string[] stringArr = inputLine.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int size = stringArr.Length;

            var numbers = new BigInteger[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = BigInteger.Parse(stringArr[i]);
            }

            int position = 0;
            string command = Console.ReadLine();
            while (command != "stop")
            {
                string[] commandArr = Regex.Split(command, pattern);
                int offset = int.Parse(commandArr[0]);
                int operand = int.Parse(commandArr[2]);
                string operation = commandArr[1];

                position += offset;

                if (position >= 0)
                {
                    position = position % size;
                }
                else
                {
                    int index = position % size;
                    if (index == 0)
                    {
                        position = 0;
                    }
                    else
                    {
                        position = size + index;
                    }
                }

                switch (operation)
                {
                    case "*":
                        numbers[position] *= operand;
                        break;
                    case "/":
                        numbers[position] /= operand;
                        break;
                    case "+":
                        numbers[position] += operand;
                        break;
                    case "-":
                        numbers[position] -= operand;
                        if (numbers[position] < 0)
                        {
                            numbers[position] = 0;
                        }
                        break;
                    case "&":
                        numbers[position] &= operand;
                        break;
                    case "|":
                        numbers[position] |= operand;
                        break;
                    case "^":
                        numbers[position] ^= operand;
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }
    }
}
