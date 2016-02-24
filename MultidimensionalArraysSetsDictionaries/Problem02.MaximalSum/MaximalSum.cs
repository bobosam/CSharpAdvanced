namespace Problem02.MaximalSum
{
    using System;

    public class MaximalSum
    {
        public static void Main()
        {
            string sizeMatrix = Console.ReadLine();
            string[] sizeArr = sizeMatrix.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(sizeArr[0]);
            int cols = int.Parse(sizeArr[1]);
            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string valuesline = Console.ReadLine();
                string[] values = valuesline.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(values[col]);
                }
            }

            int maxSum, rowIndex, colIndex;
            FindMaxSum(rows, cols, matrix, out maxSum, out rowIndex, out colIndex);
            PrintResult(matrix, maxSum, rowIndex, colIndex);
        }

        private static void PrintResult(int[,] matrix, int maxSum, int rowIndex, int colIndex)
        {
            Console.WriteLine("Sum = {0}", maxSum);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[rowIndex + i, colIndex + j] + " ");
                }

                Console.WriteLine();
            }
        }

        private static void FindMaxSum(int rows, int cols, int[,] matrix, out int maxSum, out int rowIndex, out int colIndex)
        {
            maxSum = int.MinValue;
            rowIndex = 0;
            colIndex = 0;
            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int sum = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            sum += matrix[row + i, col + j];
                        }
                    }

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }
        }
    }
}
