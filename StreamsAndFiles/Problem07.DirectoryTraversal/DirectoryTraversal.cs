namespace Problem07.DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class DirectoryTraversal
    {
        public static void Main()
        {
            string[] filenames = Directory.GetFiles("../../").ToArray();
            var db = new SortedDictionary<string, List<string>>();

            foreach (var filename in filenames)
            {
                FileInfo name = new FileInfo(filename);
                if (db.ContainsKey(name.Extension))
                {
                    db[name.Extension].Add(string.Format("{0}.{1} - {2}kb", name.Name, name.Extension, name.Length));
                }
                else
                {
                    db.Add(name.Extension, new List<string> { string.Format("{0}.{1} - {2}kb", name.Name, name.Extension, name.Length) });
                }
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (StreamWriter writer = new StreamWriter(path + "/results.txt"))
            {
                foreach (var list in db.OrderByDescending(s => s.Value.Count))
                {
                    writer.WriteLine(list.Key);
                    foreach (var str in list.Value)
                    {
                        writer.WriteLine("--" + str);
                    }
                }
            }
        }
    }
}
