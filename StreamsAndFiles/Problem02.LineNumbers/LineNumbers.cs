namespace Problem02.LineNumbers
{
    using System.IO;

    public class LineNumbers
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader("../../LineNumbers.cs");
            StreamWriter writer = new StreamWriter("../../LineNumbers.txt");
            using (reader)
            {
                using (writer)
                {
                    int numberLine = 1;
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        writer.WriteLine(string.Format("{0}.{1}", numberLine, line));
                        numberLine++;
                    }
                }
            }
        }
    }
}
