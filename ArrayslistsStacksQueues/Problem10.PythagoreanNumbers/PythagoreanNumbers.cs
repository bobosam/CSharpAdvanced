namespace Problem10.PythagoreanNumbers
{
    using System;

    public class PythagoreanNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new int[n];
            bool isPithagorean = false;
            for (int index = 0; index < n; index++)
            {
                numbers[index] = int.Parse(Console.ReadLine());
            }

            for (int indexA = 0; indexA < n; indexA++)
            {
                for (int indexB = 0; indexB < n; indexB++)
                {
                    if (numbers[indexB] < numbers[indexA])
                    {
                        continue;
                    }

                    for (int indexC = 0; indexC < n; indexC++)
                    {
                        if (
                            (numbers[indexA] * numbers[indexA]) +
                            (numbers[indexB] * numbers[indexB]) ==
                            numbers[indexC] * numbers[indexC])
                        {
                            Console.WriteLine(
                                "{0}*{0} + {1}*{1} = {2}*{2}",
                                numbers[indexA],
                                numbers[indexB],
                                numbers[indexC]);
                            isPithagorean = true;
                        }
                    }
                }
            }

            if (isPithagorean == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
