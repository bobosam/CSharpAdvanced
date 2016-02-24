namespace Problem04.FirstlargerThanNeighbours
{
    using System;

    public class FirstLargerThenNeighbours
    {
        public static void Main()
        {
            int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
            int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] sequenceThree = { 1, 1, 1 };

            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
        }

        private static int GetIndexOfFirstElementLargerThanNeighbours(int[] numbers)
        {
            bool isLarge = false;
            int result = 0;

            for (int index = 0; index < numbers.Length; index++)
            {
                if (index == 0 || index == numbers.Length - 1)
                {
                    if (index == 0)
                    {
                        if (numbers[index] > numbers[index + 1])
                        {
                            isLarge = true;
                            result = index;
                            break;
                        }
                    }
                    else
                    {
                        if (index == numbers.Length - 1)
                        {
                            if (numbers[index] > numbers[index - 1])
                            {
                                isLarge = true;
                                result = index;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    if (numbers[index] > numbers[index - 1] && numbers[index] > numbers[index + 1])
                    {
                        isLarge = true;
                        result = index;
                        break;
                    }
                }
            }

            if (isLarge == false)
            {
                result = -1;
            }

            return result;
        }
    }
}
