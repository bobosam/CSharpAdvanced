using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            string sizeLine = Console.ReadLine();
            string[] sizeArr = sizeLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(sizeArr[0]);
            int cols = int.Parse(sizeArr[1]);
            

            var matrix = new int[rows, cols];

            string line = Console.ReadLine();
            while (line != "stop")
            {
                int step = 0;
                string[] commands = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int start = int.Parse(commands[0]);
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);

                //if (col == 1)
                //{
                //    line = Console.ReadLine();
                //    continue;
                //}

                step += Math.Abs(row - start + 1);
                for (int i = 1; i < cols; i++)
                {
                    if (matrix[row, i] == 0)
                    {
                        matrix[row, i] = 1;
                        matrix[row, i - 1] = 0;
                        step++;
                    }
                    else
                    {
                        if (i == 1)
                        {
                            bool isFull = true;
                            for (int j = 1; j < cols; j++)
                            {
                                if (matrix[row, j] == 0)
                                {
                                    isFull = false;
                                }
                            }

                            if (isFull == true)
                            {
                                Console.WriteLine("Row {0} full", row);
                                Environment.Exit(1);
                            }
                            else
                            {
                                for (int k = 1; k < cols; k++)
                                {
                                    if (matrix[row, k] == 1)
                                    {
                                        step++;
                                    }
                                    else
                                    {
                                        step++;
                                        matrix[row, k] = 1;
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            break;
                        }

                    }
                }
                Console.WriteLine(step);
                line = Console.ReadLine();
            }
        }
    }
}
