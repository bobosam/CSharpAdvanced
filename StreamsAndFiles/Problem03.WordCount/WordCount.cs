namespace Problem03.WordCount
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WordCount
    {
        public static void Main()
        {
            StreamReader readerWord = new StreamReader("../../words.txt");
            StreamReader readerText = new StreamReader("../../text.txt");
            StreamWriter writer = new StreamWriter("../../result.txt");
            var db = new Dictionary<string, int>();
            using (readerText)
            {
                string text = readerText.ReadToEnd();
                using (readerWord)
                {
                    while (!readerWord.EndOfStream)
                    {
                        string word = readerWord.ReadLine();
                        string pattern = "\\b" + word + "\\b";
                        int count = Regex.Matches(text, pattern, RegexOptions.IgnoreCase).Count;
                        db.Add(word, count);
                    }
                }
            }

            using (writer)
            {
                var orderedDb = db.OrderByDescending(c => c.Value);
                foreach (var word in orderedDb)
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
