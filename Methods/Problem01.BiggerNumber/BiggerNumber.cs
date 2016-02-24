namespace Problem01.BiggerNumber
{
    using System;

    public class BiggerNumber
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int maxNumber = GetMax(firstNumber, secondNumber);
            Console.WriteLine(maxNumber);
        }

        private static int GetMax(int numberOne, int numberTwo)
        {
            if (numberOne > numberTwo)
            {
                return numberOne;
            }

            return numberTwo;
        }
    }
}
