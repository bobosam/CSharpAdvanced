namespace CollectTheCoins
{
    using System;

    public class CollectTheCoins
    {
        public static void Main()
        {
            var rezArr = new char[4][];

            for (int rows = 0; rows < 4; rows++)
            {
                string input = Console.ReadLine();
                rezArr[rows] = new char[input.Length];
                for (int cols = 0; cols < input.Length; cols++)
                {
                    rezArr[rows][cols] = input[cols];
                }
            }

            int row = 0;
            int col = 0;
            int coins = 0;
            int walls = 0;

            string commands = Console.ReadLine();
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == 'V')
                {
                    if (row < 3 && col < rezArr[row + 1].Length)
                    {
                        row++;
                        if (rezArr[row][col] == '$')
                        {
                            coins++;
                        }
                    }
                    else
                    {
                        walls++;
                    }
                }

                if (commands[i] == '^')
                {
                    if (row > 0 && col < rezArr[row - 1].Length)
                    {
                        row--;
                        if (rezArr[row][col] == '$')
                        {
                            coins++;
                        }
                    }
                    else
                    {
                        walls++;
                    }
                }

                if (commands[i] == '>')
                {
                    if (col < rezArr[row].Length - 1)
                    {
                        col++;
                        if (rezArr[row][col] == '$')
                        {
                            coins++;
                        }
                    }
                    else
                    {
                        walls++;
                    }
                }

                if (commands[i] == '<')
                {
                    if (col > 0)
                    {
                        col--;
                        if (rezArr[row][col] == '$')
                        {
                            coins++;
                        }
                    }
                    else
                    {
                        walls++;
                    }
                }
            }

            Console.WriteLine("Coins collected: {0}", coins);
            Console.WriteLine("Walls hit: {0}", walls);
        }
    }
}
