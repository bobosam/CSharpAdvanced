namespace Problem04.SequencesOfEqualStrings
{
    using System;

    public class EqualStrings
    {
        public static void Main()
        {
            Console.Write("Enter input line --> ");
            string inputLine = Console.ReadLine();
            string[] stringArray = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int sizeArray = stringArray.Length;
            Console.Write(stringArray[0] + " ");
            if (sizeArray > 1)
            {
                for (int index = 1; index < sizeArray; index++)
                {
                    if (stringArray[index] != stringArray[index - 1])
                    {
                        Console.Write(Environment.NewLine + stringArray[index] + " ");
                    }
                    else
                    {
                        Console.Write(stringArray[index] + " ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
