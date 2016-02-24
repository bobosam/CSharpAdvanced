namespace Problem05.ReverseNumber
{
    using System;
    using System.Collections.Generic;

    public class ReverseNumber
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine(GetRevursedNumber(number));
        }

        private static double GetRevursedNumber(double number)
        {
            List<string> reversedNum = new List<string>();
            string num = number.ToString();

            for (int i = num.Length - 1; i >= 0; i--)
            {
                reversedNum.Add(num[i].ToString());
            }

            string newNum = string.Join(string.Empty, reversedNum);
            double reversedNumbers = double.Parse(newNum);

            return reversedNumbers;
        }
    }
}
