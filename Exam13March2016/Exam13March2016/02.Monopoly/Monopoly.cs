namespace _02.Monopoly
{
    using System;

    public class Monopoly
    {
        public static void Main()
        {
            string sizeLine = Console.ReadLine();
            string[] sizeArr = sizeLine.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(sizeArr[0]);
            int cols = int.Parse(sizeArr[1]);
            int money = 50;
            int countHotels = 0;
            var matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            int turn = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int pos;
                    if (row % 2 == 0)
                    {
                        pos = col;
                    }
                    else
                    {
                        pos = cols - col - 1;
                    }

                    char command = matrix[row, pos];

                    switch (command)
                    {
                        case 'H':
                            countHotels++;
                            Console.WriteLine("Bought a hotel for {0}. Total hotels: {1}.", money, countHotels);
                            money = 0;
                            turn++;
                            money += countHotels * 10;
                            break;
                        case 'J':
                            Console.WriteLine("Gone to jail at turn {0}.", turn);
                            turn += 3;
                            money += countHotels * 30;
                            break;
                        case 'F':
                            money += countHotels * 10;
                            turn++;
                            break;
                        case 'S':
                            int spend = (row + 1) * (pos + 1);

                            if (money < spend)
                            {
                                spend = money;
                            }

                            Console.WriteLine("Spent {0} money at the shop.", spend);
                            money -= spend;
                            money += countHotels * 10;
                            turn++;
                            break;
                        default:
                            break;
                    }
                }
            }

            Console.WriteLine("Turns {0}", turn);
            Console.WriteLine("Money {0}", money);
        }
    }
}
