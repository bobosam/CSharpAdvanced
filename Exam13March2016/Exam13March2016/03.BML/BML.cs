namespace _03.BML
{
    using System;

    public class BML
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int lineNumber = 1;
            string[] stopArr = input.Split(new char[] { '<', '/', '>', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            while (stopArr[0] != "stop")
            {
                string[] data = input.Split('\"');
                string[] firstPart = data[0].Split(new char[] { ' ', '\t', '<' }, StringSplitOptions.RemoveEmptyEntries);
                string command = firstPart[0];
                string content;
                switch (command)
                {
                    case "inverse":
                        content = data[1];
                        if (content == string.Empty)
                        {
                            break;
                        }

                        Console.Write("{0}. ", lineNumber);

                        for (int i = 0; i < content.Length; i++)
                        {
                            char current = content[i];
                            if (char.ToLower(current) == current)
                            {
                                Console.Write(char.ToUpper(current));
                            }
                            else
                            {
                                Console.Write(char.ToLower(current));
                            }
                        }

                        Console.WriteLine();
                        lineNumber++;
                        break;
                    case "reverse":
                        content = data[1];
                        if (content == string.Empty)
                        {
                            break;
                        }

                        Console.Write("{0}. ", lineNumber);
                        char[] arrContent = content.ToCharArray();
                        Array.Reverse(arrContent);
                        Console.WriteLine(string.Join(string.Empty, arrContent));
                        lineNumber++;
                        break;
                    case "repeat":
                        content = data[3];
                        if (content == string.Empty)
                        {
                            break;
                        }

                        string[] counter = data[1].Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        int count = int.Parse(counter[0]);

                        for (int i = 0; i < count; i++)
                        {
                            Console.Write("{0}. ", lineNumber);
                            Console.WriteLine(data[3]);
                            lineNumber++;
                        }

                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
                stopArr = input.Split(new char[] { '<', '/', '>', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
