namespace Problem04.CopyBinaryFile
{
    using System.IO;

    public class CopyBinaryFile
    {
        private const int BufferSize = 4096;

        public static void Main()
        {
            FileStream reader = new FileStream("../../DSC00041.JPG", FileMode.Open);
            FileStream writer = new FileStream("../../photo.JPG", FileMode.Create);
            byte[] buffer = new byte[BufferSize];
            using (reader)
            {
                int position = 0;
                using (writer)
                {
                    while (true)
                    {
                        int readBytes = reader.Read(buffer, 0, BufferSize);
                        if (0 == readBytes)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, readBytes);
                        position += readBytes;
                    }
                }
            }
        }
    }
}
