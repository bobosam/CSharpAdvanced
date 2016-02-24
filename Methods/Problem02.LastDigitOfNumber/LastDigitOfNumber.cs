namespace Problem02.LastDigitOfNumber
{
    using System;

    public class LastDigitOfNumber
    {
        public static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());

            Console.WriteLine(GetLastDigitAsWord(numbers));
        }

        public static string GetLastDigitAsWord(int num)
        {
            int lastDigit = Math.Abs(num % 10);
            string lastDigitAsWord = null;
            switch (lastDigit)
            {
                case 0:
                    lastDigitAsWord = "zero";
                    break;
                case 1:
                    lastDigitAsWord = "one";
                    break;
                case 2:
                    lastDigitAsWord = "two";
                    break;
                case 3:
                    lastDigitAsWord = "three";
                    break;
                case 4:
                    lastDigitAsWord = "four";
                    break;
                case 5:
                    lastDigitAsWord = "five";
                    break;
                case 6:
                    lastDigitAsWord = "six";
                    break;
                case 7:
                    lastDigitAsWord = "seven";
                    break;
                case 8:
                    lastDigitAsWord = "eight";
                    break;
                case 9:
                    lastDigitAsWord = "nine";
                    break;
            }

            return lastDigitAsWord;
        }
    }
}
