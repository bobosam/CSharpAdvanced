namespace MatrixShuffling
{
    using System;

    public class MatrixShuffling
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            var matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }

            string commandLine = Console.ReadLine();
            while (commandLine != "END")
            {
                string[] commandArr = commandLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (commandArr[0] != "swap")
                {
                    Console.WriteLine("Invalid input");
                    commandLine = Console.ReadLine();
                    continue;
                }

                int firstElementRow = int.Parse(commandArr[1]);
                int firstElementCol = int.Parse(commandArr[2]);
                int secondElementRow = int.Parse(commandArr[3]);
                int secondElementCol = int.Parse(commandArr[4]);

                if (
                    firstElementRow >= rows ||
                    secondElementRow >= rows ||
                    firstElementCol >= cols ||
                    secondElementCol >= cols)
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    Swap(matrix, firstElementRow, firstElementCol, secondElementRow, secondElementCol);
                    PrintMatrix(rows, cols, matrix);
                }
                
                commandLine = Console.ReadLine();
            }
        }

        private static void Swap(string[,] matrix, int firstElementRow, int firstElementCol, int secondElementRow, int secondElementCol)
        {
            string oldValue = matrix[firstElementRow, firstElementCol];
            matrix[firstElementRow, firstElementCol] = matrix[secondElementRow, secondElementCol];
            matrix[secondElementRow, secondElementCol] = oldValue;
        }

        private static void PrintMatrix(int rows, int cols, string[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
