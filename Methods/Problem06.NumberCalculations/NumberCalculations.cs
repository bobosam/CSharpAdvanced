namespace Problem06.NumberCalculations
{
    using System;

    public class NumberCalculations
    {
        public static void Main()
        {
            Console.WriteLine("Enter integer numbers on one line separated by a space:");
            string inputInteger = Console.ReadLine();
            string[] inputArrInteger = inputInteger.Split(' ');
            int[] numbersInteger = new int[inputArrInteger.Length];

            Console.WriteLine("Enter double numbers on one line separated by a space:");
            string inputDouble = Console.ReadLine();
            string[] inputArrDouble = inputDouble.Split(' ');
            double[] numbersDouble = new double[inputArrDouble.Length];

            Console.WriteLine("Enter decimal numbers on one line separated by a space:");
            string inputDecimla = Console.ReadLine();
            string[] inputArrDecimal = inputDecimla.Split(' ');
            decimal[] numbersDecimal = new decimal[inputArrDecimal.Length];

            for (int i = 0; i < numbersInteger.Length; i++)
            {
                numbersInteger[i] = int.Parse(inputArrInteger[i]);
            }

            for (int i = 0; i < numbersDouble.Length; i++)
            {
                numbersDouble[i] = double.Parse(inputArrDouble[i]);
            }

            for (int i = 0; i < numbersDecimal.Length; i++)
            {
                numbersDecimal[i] = decimal.Parse(inputArrDecimal[i]);
            }

            int minInteger = CalculationMinNumber(numbersInteger);
            double minDouble = CalculationMinNumber(numbersDouble);
            decimal minDecimal = CalculationMinNumber(numbersDecimal);

            int maxInteger = CalcilationMaxNumber(numbersInteger);
            double maxDouble = CalcilationMaxNumber(numbersDouble);
            decimal maxDecimal = CalcilationMaxNumber(numbersDecimal);

            int sumInteger = CalculationsSumNumber(numbersInteger);
            double sumDouble = CalculationsSumNumber(numbersDouble);
            decimal sumDecimal = CalculationsSumNumber(numbersDecimal);

            double avrgInteger = CalcilationsAvrgNumber(numbersInteger);
            double avrgDouble = CalcilationsAvrgNumber(numbersDouble);
            decimal avrgDecimal = CalcilationsAvrgNumber(numbersDecimal);

            int productInteger = CalculationsProductNumbers(numbersInteger);
            double productDouble = CalculationsProductNumbers(numbersDouble);
            decimal productDecimal = CalculationsProductNumbers(numbersDecimal);

            Console.WriteLine("Min number of the integer numbers is {0}.", minInteger);
            Console.WriteLine("Min number of the double numbers is {0}.", minDouble);
            Console.WriteLine("Min number of the decimal numbers is {0}.", minDecimal);

            Console.WriteLine("Max number of the integer numbers is {0}.", maxInteger);
            Console.WriteLine("Max number of the double numbers is {0}.", maxDouble);
            Console.WriteLine("Max number of the decimal numbers is {0}.", maxDecimal);

            Console.WriteLine("The sum of the integer numbers is {0}.", sumInteger);
            Console.WriteLine("The sum of the double numbers is {0}.", sumDouble);
            Console.WriteLine("The sum of the decimal numbers is {0:0.###}.", sumDecimal);

            Console.WriteLine("Average of integer numbers is {0}.", avrgInteger);
            Console.WriteLine("Average of double numbers is {0}.", avrgDouble);
            Console.WriteLine("Average of decimal numbers is {0:0.###}.", avrgDecimal);

            Console.WriteLine("Product of the integer numbers is {0}.", productInteger);
            Console.WriteLine("Product of the double numbers is {0}.", productDouble);
            Console.WriteLine("Product of the decimal numbers is {0:0.###}.", productDecimal);
        }

        private static int CalculationMinNumber(int[] num)
        {
            int minNumber = int.MaxValue;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < minNumber)
                {
                    minNumber = num[i];
                }
            }

            return minNumber;
        }

        private static double CalculationMinNumber(double[] num)
        {
            double minNumber = double.MaxValue;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < minNumber)
                {
                    minNumber = num[i];
                }
            }

            return minNumber;
        }

        private static decimal CalculationMinNumber(decimal[] num)
        {
            decimal minNumber = decimal.MaxValue;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < minNumber)
                {
                    minNumber = num[i];
                }
            }

            return minNumber;
        }

        private static int CalcilationMaxNumber(int[] num)
        {
            int maxNumber = int.MinValue;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > maxNumber)
                {
                    maxNumber = num[i];
                }
            }

            return maxNumber;
        }

        private static double CalcilationMaxNumber(double[] num)
        {
            double maxNumber = double.MinValue;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > maxNumber)
                {
                    maxNumber = num[i];
                }
            }

            return maxNumber;
        }

        private static decimal CalcilationMaxNumber(decimal[] num)
        {
            decimal maxNumber = decimal.MinValue;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > maxNumber)
                {
                    maxNumber = num[i];
                }
            }

            return maxNumber;
        }

        private static int CalculationsSumNumber(int[] num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }

            return sum;
        }

        private static double CalculationsSumNumber(double[] num)
        {
            double sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }

            return sum;
        }

        private static decimal CalculationsSumNumber(decimal[] num)
        {
            decimal sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }

            return sum;
        }

        private static double CalcilationsAvrgNumber(int[] num)
        {
            int sum = CalculationsSumNumber(num);
            double avrg = (double)sum / num.Length;
            return avrg;
        }

        private static double CalcilationsAvrgNumber(double[] num)
        {
            double sum = CalculationsSumNumber(num);
            double avrg = sum / num.Length;
            return avrg;
        }

        private static decimal CalcilationsAvrgNumber(decimal[] num)
        {
            decimal sum = CalculationsSumNumber(num);
            decimal avrg = sum / num.Length;
            return avrg;
        }

        private static int CalculationsProductNumbers(int[] num)
        {
            int product = 1;
            for (int i = 0; i < num.Length; i++)
            {
                product *= num[i];
            }

            return product;
        }

        private static double CalculationsProductNumbers(double[] num)
        {
            double product = 1;
            for (int i = 0; i < num.Length; i++)
            {
                product *= num[i];
            }

            return product;
        }

        private static decimal CalculationsProductNumbers(decimal[] num)
        {
            decimal product = 1;
            for (int i = 0; i < num.Length; i++)
            {
                product *= num[i];
            }

            return product;
        }
    }
}
