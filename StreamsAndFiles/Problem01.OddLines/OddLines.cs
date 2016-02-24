namespace Problem01.OddLines
{
    using System;
    using System.IO;

    public class OddLines
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader("../../OddLines.cs");

            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    if (lineNumber % 2 == 0)
                    {
                        Console.WriteLine(line);
                    }

                    line = reader.ReadLine();
                    lineNumber++;
                }
            }
        }
    }
}
