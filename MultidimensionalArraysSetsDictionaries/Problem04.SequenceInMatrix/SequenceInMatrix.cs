namespace Problem04.SequenceInMatrix
{
    using System;

    public class SequenceInMatrix
    {
        public static void Main()
        {
            Console.Write("N --> ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("M --> ");
            int m = int.Parse(Console.ReadLine());

            var matrix = new string[n, m];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("Element {0}, {1} --> ", row, col);
                    matrix[row, col] = Console.ReadLine();
                }
            }

            int maxCount = 0;
            int count = 1;
            string element = matrix[0, 0];

            CountElementsInRow(n, m, matrix, ref maxCount, ref count, ref element);
            CountElementsInCol(n, m, matrix, ref maxCount, ref count, ref element);
            CountElementsInDiagonal(n, m, matrix, ref maxCount, ref count, ref element);

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(element);
                if (i < maxCount - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }

        private static void CountElementsInDiagonal(int n, int m, string[,] matrix, ref int maxCount, ref int count, ref string element)
        {
            for (int row = 0; row < n - 1; row++)
            {
                for (int col = 0; col < m - 1; col++)
                {
                    if (matrix[row + 1, col + 1] == matrix[row, col])
                    {
                        count++;
                        if (count > maxCount)
                        {
                            maxCount = count;
                            element = matrix[row, col];
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
        }

        private static void CountElementsInCol(int n, int m, string[,] matrix, ref int maxCount, ref int count, ref string element)
        {
            for (int col = 0; col < m; col++)
            {
                for (int row = 0; row < n - 1; row++)
                {
                    if (matrix[row + 1, col] == matrix[row, col])
                    {
                        count++;
                        if (count > maxCount)
                        {
                            maxCount = count;
                            element = matrix[row, col];
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
        }

        private static void CountElementsInRow(int n, int m, string[,] matrix, ref int maxCount, ref int count, ref string element)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m - 1; col++)
                {
                    if (matrix[row, col + 1] == matrix[row, col])
                    {
                        count++;
                        if (count > maxCount)
                        {
                            maxCount = count;
                            element = matrix[row, col];
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
        }
    }
}
