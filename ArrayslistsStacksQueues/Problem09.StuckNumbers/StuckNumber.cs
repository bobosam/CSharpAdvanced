namespace Problem09.StuckNumbers
{
    using System;

    public class StuckNumber
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            string[] numbers = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            bool isStuck = false;

            for (int indexA = 0; indexA < n; indexA++)
            {
                for (int indexB = 0; indexB < n; indexB++)
                {
                    if (indexB == indexA)
                    {
                        continue;
                    }

                    string firstNumber = string.Concat(numbers[indexA], numbers[indexB]);

                    for (int indexC = 0; indexC < n; indexC++)
                    {
                        if (indexC == indexB || indexC == indexA)
                        {
                            continue;
                        }

                        for (int indexD = 0; indexD < n; indexD++)
                        {
                            if (indexD == indexA || indexD == indexB || indexD == indexC)
                            {
                                continue;
                            }

                            string secondNumber = string.Concat(numbers[indexC], numbers[indexD]);

                            if (firstNumber == secondNumber)
                            {
                                Console.WriteLine(
                                                    "{0}|{1}=={2}|{3}",
                                                    numbers[indexA],
                                                    numbers[indexB],
                                                    numbers[indexC],
                                                    numbers[indexD]);
                                isStuck = true;
                            }
                        }
                    }
                }
            }

            if (isStuck == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
