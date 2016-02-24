namespace Problem07.LettersChangeNumbers
{
    using System;

    public class LettersChangeNumbers
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();
            string[] lettersArr = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            foreach (var letter in lettersArr)
            {
                int size = letter.Length;
                string numberStr = letter.Substring(1, size - 2);
                int number = int.Parse(numberStr);

                if (letter[0] >= 'a' && letter[0] <= 'z')
                {
                    int firstElement = letter[0] - 'a' + 1;
                    sum += number * firstElement;
                }
                else
                {
                    int firstElement = letter[0] - 'A' + 1;
                    sum += (double)number / firstElement;
                }

                if (letter[size - 1] >= 'a' && letter[size - 1] <= 'z')
                {
                    int secondElement = letter[size - 1] - 'a' + 1;
                    sum += secondElement;
                }
                else
                {
                    int secondElement = letter[size - 1] - 'A' + 1;
                    sum -= secondElement;
                }
            }

            Console.WriteLine("{0:0.00}", sum);
        }
    }
}
