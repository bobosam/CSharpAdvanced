using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CommandIterpreteter
{
    public class CommandInterpreteter
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            string[] elements = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string commandLine = Console.ReadLine();
            int start;
            int count;
            var result = new string[elements.Length];
            while (commandLine != "end")
            {
                string[] command = commandLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "reverse":
                        start = int.Parse(command[2]);
                        count = int.Parse(command[4]);
                        if (count < 0 || start < 0 || start > elements.Length - 1 || start + count > elements.Length)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            elements = Reverse(elements, start, count);
                        }
                       
                        break;
                    case "sort":
                        start = int.Parse(command[2]);
                        count = int.Parse(command[4]);
                        if (count < 0 || start < 0 || start > elements.Length - 1 || start + count > elements.Length)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            elements = SortString(elements, start, count);
                        }
                        
                        break;
                    case "rollLeft":
                        count = int.Parse(command[1]);
                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            elements = RollLeft(elements, count);
                        }
                       
                        break;
                    case "rollRight":
                        count = int.Parse(command[1]);
                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            elements = RollRight(elements, count);
                        }
                        
                        break;
                    default:
                        break;
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", elements));
        }

        private static string[] RollRight(string[] elements, int count)
        {
            count = count % elements.Length;
            string[] result = elements;
            for (int i = 0; i < count; i++)
            {
                string[] first = result.Take(result.Length - 1).ToArray();
                string[] second = result.Skip(result.Length - 1).Take(1).ToArray();
                result = second.Concat(first).ToArray();
            }

            return result;
        }

        private static string[] RollLeft(string[] elements, int count)
        {
            count = count % elements.Length;
            string[] result = elements;
            for (int i = 0; i < count; i++)
            {
                string[] first = result.Take(1).ToArray();
                string[] second = result.Skip(1).Take(elements.Length - 1).ToArray();
                result = second.Concat(first).ToArray();
            }

            return result;
        }

        private static string[] SortString(string[] elements, int start, int count)
        {
            string[] result;
            string[] first = elements.Take(start).ToArray();
            string[] second = elements.Skip(start).Take(count).ToArray();
            Array.Sort(second);
            string[] last = elements.Skip(start + count).Take(elements.Length - count - start).ToArray();
            result = first.Concat(second.Concat(last)).ToArray();

            return result;
        }

        private static string[] Reverse(string[] elements, int start, int count)
        {
            string[] result;
            string[] first = elements.Take(start).ToArray();
            string[] second = elements.Skip(start).Take(count).Reverse().ToArray();
            string[] last = elements.Skip(start + count).Take(elements.Length - count - start).ToArray();
            result = first.Concat(second.Concat(last)).ToArray();

            return result;
        }
    }
}
