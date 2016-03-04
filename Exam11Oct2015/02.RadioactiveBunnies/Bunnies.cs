using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RadioactiveBunnies
{
    public class Bunnies
    {
        public static void Main()
        {
            string sizeLine = Console.ReadLine();
            string[] size = sizeLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(size[0]);
            int cols = int.Parse(size[1]);
            int rowPos = -1;
            int colPos = -1;

            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                char[] lineArr = Console.ReadLine().Trim().ToCharArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = lineArr[col];
                    if (matrix[row, col] == 'P')
                    {
                        rowPos = row;
                        colPos = col;
                    }
                }
            }

            bool isWon = false;
            bool isDead = false;
            char[] commands = Console.ReadLine().Trim().ToCharArray();
            int countCommands = commands.Length;
            for (int index = 0; index < countCommands; index++)
            {
                char[,] copyMatrix = new char[rows, cols];
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        copyMatrix[row, col] = matrix[row, col];
                    }
                }

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (matrix[row, col] == 'B')
                        {
                            if (row > 0)
                            {
                                copyMatrix[row - 1, col] = 'B';
                            }

                            if (row < rows - 1)
                            {
                                copyMatrix[row + 1, col] = 'B';
                            }

                            if (col > 0)
                            {
                                copyMatrix[row, col - 1] = 'B';
                            }

                            if (col < cols - 1)
                            {
                                copyMatrix[row, col + 1] = 'B';
                            }
                        }
                    }
                }

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (copyMatrix[row, col] == 'B')
                        {
                            if (matrix[row, col] == 'P')
                            {
                                isDead = true;
                            }

                            matrix[row, col] = 'B';
                        }
                    }
                }

                if (isDead)
                {
                    break;
                }

                if (commands[index] == 'L')
                {
                    matrix[rowPos, colPos] = '.';
                    colPos--;
                    if (colPos < 0)
                    {
                        isWon = true;
                        colPos++;
                        break;
                    }

                    if (matrix[rowPos, colPos] == 'B')
                    {
                        isDead = true;
                        break;
                    }

                    matrix[rowPos, colPos] = 'P';
                }

                if (commands[index] == 'R')
                {
                    matrix[rowPos, colPos] = '.';
                    colPos++;
                    if (colPos >= cols)
                    {
                        isWon = true;
                        colPos--;
                        break;
                    }

                    if (matrix[rowPos, colPos] == 'B')
                    {
                        isDead = true;
                        break;
                    }

                    matrix[rowPos, colPos] = 'P';
                }

                if (commands[index] == 'U')
                {
                    matrix[rowPos, colPos] = '.';
                    rowPos--;
                    if (rowPos < 0)
                    {
                        isWon = true;
                        rowPos++;
                        break;
                    }

                    if (matrix[rowPos, colPos] == 'B')
                    {
                        isDead = true;
                        break;
                    }

                    matrix[rowPos, colPos] = 'P';
                }

                if (commands[index] == 'D')
                {
                    matrix[rowPos, colPos] = '.';
                    rowPos++;
                    if (rowPos >= rows)
                    {
                        isWon = true;
                        rowPos--;
                        break;
                    }

                    if (matrix[rowPos, colPos] == 'B')
                    {
                        isDead = true;
                        break;
                    }

                    matrix[rowPos, colPos] = 'P';
                }

            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }

            if (isWon)
            {
                Console.WriteLine("won: {0} {1}", rowPos, colPos);
            }

            if (isDead)
            {
                Console.WriteLine("dead: {0} {1}", rowPos, colPos);
            }
        }
    }
}
