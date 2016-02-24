namespace Problem01.ReverseString
{
    using System;

    public class ReverseString
    {
        public static void Main()
        {
            Console.Write("Input string --> ");
            string inputString = Console.ReadLine();

            char[] arr = inputString.ToCharArray();
            Array.Reverse(arr);
            string reverseString = new string(arr);

            Console.Write("Reverse --> ");
            Console.WriteLine(reverseString);
        }
    }
}
