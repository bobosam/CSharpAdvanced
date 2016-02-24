namespace Problem07.Phonebook
{
    using System;
    using System.Collections.Generic;

    public class Phonebook
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();
            var phonebook = new Dictionary<string, List<string>>();

            while (inputLine != "search")
            {
                string[] inputArr = inputLine.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                string name = inputArr[0];
                string contacts = inputArr[1];

                if (!phonebook.ContainsKey(name))
                {
                    phonebook.Add(name, new List<string>());
                }

                phonebook[name].Add(contacts);

                inputLine = Console.ReadLine();
            }

            string inputSearch = Console.ReadLine();
            while (!string.IsNullOrEmpty(inputSearch))
            {
                if (phonebook.ContainsKey(inputSearch))
                {
                    Console.WriteLine("{0} --> {1}", inputSearch, string.Join("; ", phonebook[inputSearch]));
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", inputSearch);
                }

                inputSearch = Console.ReadLine();
            }
        }
    }
}
