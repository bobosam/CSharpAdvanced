using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TargetPractice
{
    public class TargetPractice
    {
        public static void Main()
        {
            string sizeLine = Console.ReadLine();
            string[] sizes = sizeLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(sizes[0]);
            int cols = int.Parse(sizes[1]);
            var matrix = new char[rows, cols];

            string text = Console.ReadLine();
            var sb = new StringBuilder();

            while (sb.Length < rows * cols)
            {
                sb.Append(text);
            }

            char[] snake = sb.ToString().ToArray();

            for (int i = 0; i < rows; i++)
            {
                char[] parts = snake.Skip(i * cols).Take(cols).ToArray();
                if (i % 2 != 0)
                {
                    Array.Reverse(parts);
                }

                int row = rows - i - 1;
                for (int j = 0; j < cols; j++)
                {
                    int col = cols - j - 1;
                    matrix[row, col] = parts[j];
                }
            }

            string bomb = Console.ReadLine();
            string[] bombArr = bomb.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int bombRow = int.Parse(bombArr[0]);
            int bombCol = int.Parse(bombArr[1]);
            int radius = int.Parse(bombArr[2]);
            matrix[bombRow, bombCol] = ' ';

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (IsInsideRadius(row, col, bombRow, bombCol, radius))
                    {
                        matrix[row, col] = ' ';
                    }
                }
            }

            bool isDown = true;
            while (isDown)
            {
                isDown = false;
                for (int row = 0; row < rows - 1; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (matrix[row + 1, col] == ' ' && matrix[row, col] != ' ')
                        {
                            matrix[row + 1, col] = matrix[row, col];
                            matrix[row, col] = ' ';
                            isDown = true;
                        }
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
        }

        private static bool IsInsideRadius(int checkRow, int checkCol, int impactRow, int impactCol, int shotRadius)
        {
            int deltaRow = checkRow - impactRow;
            int deltaCol = checkCol - impactCol;

            bool isInRadius = deltaRow * deltaRow + deltaCol * deltaCol <= shotRadius * shotRadius;

            return isInRadius;
        }
    }
}
