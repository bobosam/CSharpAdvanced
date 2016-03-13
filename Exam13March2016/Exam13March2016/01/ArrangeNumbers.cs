namespace _01.ArrangeNumbers
{
    using System;
    using System.Text;

    public class ArrangeNumbers
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            string[] strNum = line.Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int size = strNum.Length;
            var nums = new int[size];
            var words = new string[size];

            for (int i = 0; i < size; i++)
            {
                nums[i] = int.Parse(strNum[i]);
                string word = NumberToWords(nums[i]);
                words[i] = word;
            }

            string[] unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            Array.Sort(words);
            string[] result = new string[size];

            for (int i = 0; i < size; i++)
            {
                string[] nn = words[i].Split('-');
                int sizenn = nn.Length;
                var sb = new StringBuilder();
                for (int j = 0; j < sizenn; j++)
                {
                    int number = Array.IndexOf(unitsMap, nn[j]);
                    sb.Append(number);
                }

                result[i] = sb.ToString();
            }

            Console.WriteLine(string.Join(", ", result));
        }

        public static string NumberToWords(int number)
        {
            string[] unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

            string strnum = number.ToString();
            int size = strnum.Length;
            var sb = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                int pos = int.Parse(strnum[i].ToString());
                sb.Append(unitsMap[pos] + "-");
            }

            string words = sb.ToString().TrimEnd('-');

            return words;
        }
    }
}
