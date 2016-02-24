namespace Problem05.SlicingFile
{
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Compression;

    public class SlicingFile
    {
        private const int BufferSize = 4096;

        private static List<string> fileNames = new List<string>();

        public static void Main()
        {
            SliceFile("../../DSC00041.JPG", 5);
            AssembleFiles(fileNames, "Assemble Fail.jpg");
        }

        private static void SliceFile(string fileName, int parts)
        {
            byte[] buffer = new byte[BufferSize];
            string name = fileName.Substring(0, fileName.LastIndexOf('.'));
            string extension = fileName.Substring(fileName.LastIndexOf('.'));

            FileStream reader = new FileStream(fileName, FileMode.Open);

            using (reader)
            {
                long partSize = reader.Length / parts;
                for (int part = 1; part <= parts; part++)
                {
                    string destination = name + "-Part-" + part + ".gz";
                    FileStream writer = new FileStream(destination, FileMode.Create);
                    if (part == parts)
                    {
                        partSize = reader.Length;
                    }

                    using (writer)
                    {
                        GZipStream gz = new GZipStream(writer, CompressionMode.Compress, true);
                        using (gz)
                        {
                            int size = 0;
                            int difference = 0;
                            while (true)
                            {
                                if ((size + BufferSize) > partSize)
                                {
                                    difference = size + BufferSize - (int)partSize;
                                }

                                if (size == partSize)
                                {
                                    break;
                                }

                                int readBytes = reader.Read(buffer, 0, BufferSize - difference);
                                if (0 == readBytes)
                                {
                                    break;
                                }

                                writer.Write(buffer, 0, readBytes);
                                size += BufferSize - difference;
                            }
                        }
                    }

                    fileNames.Add(destination);
                }
            }
        }

        private static void AssembleFiles(List<string> fileNames, string filename)
        {
            FileStream write = new FileStream("../../" + filename, FileMode.Append);

            byte[] buffer = new byte[BufferSize];
            using (write)
            {
                for (int i = 0; i < fileNames.Count; i++)
                {
                    FileStream reader = new FileStream(fileNames[i], FileMode.Open);
                    using (reader)
                    {
                        GZipStream gz = new GZipStream(reader, CompressionMode.Decompress, false);
                        using (gz)
                        {
                            while (true)
                            {
                                int readBytes = reader.Read(buffer, 0, BufferSize);
                                if (readBytes == 0)
                                {
                                    break;
                                }

                                write.Write(buffer, 0, readBytes);
                            }
                        }
                    }
                }
            }
        }
    }
}
