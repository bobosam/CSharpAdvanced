namespace Problem04.TextFilter
{
    using System;

    public class TextFilter
    {
        public static void Main(string[] args)
        {
            Console.Write("banned words --> ");
            string bannedWords = Console.ReadLine();
            Console.Write("text --> ");
            string text = Console.ReadLine();

            string[] wordsArr = bannedWords.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int size = wordsArr.Length;

            for (int index = 0; index < size; index++)
            {
                string bannedWord = wordsArr[index];
                string replaceStr = new string('*', bannedWord.Length);
                int position = text.IndexOf(bannedWord);
                while (position >= 0)
                {
                    text = text.Replace(bannedWord, replaceStr);
                    position = text.IndexOf(bannedWord);
                }
            }

            Console.WriteLine(text);
        }
    }
}
