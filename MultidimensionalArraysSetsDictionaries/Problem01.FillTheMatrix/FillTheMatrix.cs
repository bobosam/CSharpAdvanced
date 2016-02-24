namespace Problem01.FillTheMatrix
{
    using System;

    public class FillTheMatrix
    {
        public static void Main()
        {
            Console.Write("Input size --> ");
            int size;
            bool isNumber = int.TryParse(Console.ReadLine(), out size);
            if (isNumber == false)
            {
                throw new ArgumentException("\nNot a number!");
            }

            var matrix = new int[size, size];

            FillMatrixPaternA(size, matrix);
            PrintMatrix(size, matrix);
            Console.WriteLine();

            FillMatrixPaternB(size, matrix);
            PrintMatrix(size, matrix);
        }

        private static void FillMatrixPaternA(int size, int[,] matrix)
        {
            int counter = 1;
            for (int col = 0; col < size; col++)
            {
                for (int row = 0; row < size; row++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
        }

        private static void FillMatrixPaternB(int size, int[,] matrix)
        {
            int counter = 1;
            for (int col = 0; col < size; col++)
            {
                for (int row = 0; row < size; row++)
                {
                    if (col % 2 != 0)
                    {
                        matrix[size - row - 1, col] = counter;
                    }
                    else
                    {
                        matrix[row, col] = counter;
                    }

                    counter++;
                }
            }
        }

        private static void PrintMatrix(int size, int[,] matrix)
        {
            for (int rol = 0; rol < size; rol++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[rol, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
