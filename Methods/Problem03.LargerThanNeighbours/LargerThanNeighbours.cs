namespace Problem03.LargerThanNeighbours
{
    using System;

    public class LargerThanNeighbours
    {
        public static void Main()
        {
            int[] numbersArr = { 1, 3, 4, 5, 1, 0, 5 };

            for (int index = 0; index < numbersArr.Length; index++)
            {
                Console.WriteLine(IsLargeThanNeighbours(numbersArr, index));
            }
        }

        private static bool IsLargeThanNeighbours(int[] number, int index)
        {
            bool isLarge = false;
            if (index == 0 || index == number.Length - 1)
            {
                if (index == 0)
                {
                    if (number[index] > number[index + 1])
                    {
                        isLarge = true;
                    }
                }
                else
                {
                    if (index == number.Length - 1)
                    {
                        if (number[index] > number[index - 1])
                        {
                            isLarge = true;
                        }
                    }
                }
            }
            else
            {
                if (number[index] > number[index - 1] && number[index] > number[index + 1])
                {
                    isLarge = true;
                }
            }

            return isLarge;
        }
    }
}
