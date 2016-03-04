using System;
using System.Text;
using System.Numerics;

namespace _03.Numerals
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int size = line.Length;
            var sb = new StringBuilder();
            for (int index = 0; index < size; index++)
            {
                if (line[index] == 'a')
                {
                    if (index + 1 < size)
                    {
                        if (line[index + 1] == 'a')
                        {
                            sb.Append("0");
                            index++;
                            continue;
                        }
                        else
                        {
                            sb.Append("1");
                            index += 2;
                            continue;
                        }
                    }
                }

                if (line[index] == 'b')
                {
                    sb.Append(2);
                    index += 2;
                    continue;
                }

                if (line[index] == 'c')
                {
                    if (index + 1 < size)
                    {
                        if (line[index + 1] == 'c')
                        {
                            sb.Append("3");
                            index++;
                            continue;
                        }
                        else
                        {
                            sb.Append("4");
                            index += 2;
                            continue;

                        }
                    }
                }

                if (index == size - 2)
                {
                    break;
                }
            }
            string numbers = sb.ToString();
            int len = numbers.Length;
            BigInteger sum = 0;
            for (int i = 0; i < len; i++)
            {
                int number = int.Parse(numbers[i].ToString());
                sum +=(BigInteger)number *BigInteger.Pow(5, len - 1 - i);
            }

            Console.WriteLine(sum);
        }
    }
}
