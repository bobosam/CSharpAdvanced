namespace Problem03.CountSubstringOccurrences
{
    using System;

    public class SubstringOccurences
    {
        public static void Main()
        {
            Console.Write("Text --> ");
            string inputString = Console.ReadLine();
            Console.Write("Substring --> ");
            string substr = Console.ReadLine();
            int size = inputString.Length;
            int counter = 0;
            int position = inputString.IndexOf(substr, 0, StringComparison.CurrentCultureIgnoreCase);

            while (position >= 0)
            {
                counter++;
                if (position >= size)
                {
                    break;
                }

                position = inputString.IndexOf(substr, position + 1, StringComparison.CurrentCultureIgnoreCase);
            }

            Console.WriteLine(counter);
        }
    }
}
