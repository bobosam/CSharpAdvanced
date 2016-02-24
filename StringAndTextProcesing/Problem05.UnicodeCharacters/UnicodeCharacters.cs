namespace Problem05.UnicodeCharacters
{
    using System;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            Console.Write("Text --> ");
            string text = Console.ReadLine();
            foreach (char ch in text)
            {
                string hex = string.Format(@"\u{0:X4}", (int)ch).ToLower();
                Console.Write(hex);
            }

            Console.WriteLine();
        }
    }
}
