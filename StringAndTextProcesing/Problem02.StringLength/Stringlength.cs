namespace Problem02.StringLength
{
    using System;

    public class Stringlength
    {
        public static void Main()
        {
            Console.Write("Text line --> ");
            string inputString = Console.ReadLine();
            int size = inputString.Length;
            string resultString;

            if (size < 20)
            {
                string addString = new string('*', 20 - size);
                resultString = inputString + addString;
            }
            else
            {
                resultString = inputString.Substring(0, 20);
            }

            Console.WriteLine(resultString);
        }
    }
}
