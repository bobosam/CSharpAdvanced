namespace Problem08.LegoBlocks
{
    using System;
    using System.Linq;

    public class LegoBlocks
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var firstJugget = new int[n][];
            var secondJugget = new int[n][];

            InputJugget(n, firstJugget);
            InputJugget(n, secondJugget);

            for (int i = 0; i < n; i++)
            {
                secondJugget[i] = secondJugget[i].Reverse().ToArray();
            }

            var resultMatrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                resultMatrix[i] = firstJugget[i].Concat(secondJugget[i]).ToArray();
            }

            int sizeMatrixRow = resultMatrix[0].Length;
            bool isRectangular = true;
            for (int i = 0; i < n; i++)
            {
                if (resultMatrix[i].Length != sizeMatrixRow)
                {
                    isRectangular = false;
                    break;
                }
            }

            if (isRectangular == true)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"[{string.Join(", ", resultMatrix[i])}]");
                }
            }
            else
            {
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    count += resultMatrix[i].Length;
                }

                Console.WriteLine($"The total number of cells is: {count}");
            }
        }

        private static void InputJugget(int n, int[][] jugget)
        {
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] stringArray = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int size = stringArray.Length;
                jugget[i] = new int[size];
                for (int j = 0; j < size; j++)
                {
                    jugget[i][j] = int.Parse(stringArray[j]);
                }
            }
        }
    }
}
