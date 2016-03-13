namespace BunkerBuster
{
    using System;
    using System.Numerics;

    public class BunkerBuster
    {
        public static void Main()
        {
            string sizeLine = Console.ReadLine();
            string[] sizeArr = sizeLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(sizeArr[0]);
            int cols = int.Parse(sizeArr[1]);
            var matrix = new BigInteger[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string line = Console.ReadLine();
                string[] lineArr = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(lineArr[col]);
                }
            }

            string commandLine = Console.ReadLine();
            int count = 0;
            while (commandLine != "cease fire!")
            {
                string[] commandArr = commandLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(commandArr[0]);
                int col = int.Parse(commandArr[1]);
                int power =char.Parse( commandArr[2]) - char.Parse(commandArr[2])/2;
                for (int i = row - 1; i <= row + 1; i++)
                {
                    if (i < 0 || i >= rows)
                    {
                        continue;
                    }

                    for (int j = col -1; j <= col + 1; j++)
                    {
                        if (j < 0 || j >= cols)
                        {
                            continue;
                        }

                        matrix[i, j] -= power;
                    }
                }

                matrix[row, col] -= char.Parse(commandArr[2]) / 2;

                commandLine = Console.ReadLine();
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] <= 0)
                    {
                        count++;
                    }
                }
            }

            double percent =(100.00 * count) / (rows * cols);

            Console.WriteLine("Destroyed bunkers: {0}", count);
            Console.WriteLine("Damage done: {0:F1} %", percent);
        }
    }
}
