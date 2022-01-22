using System;
//: Implement a method to perform basic string compression using the counts
//of repeated characters. For example, the string aabcccccaaa would become a2blc5a3. If the
//"compressed" string would not become smaller than the original string, your method should return
//the original string. You can assume the string has only uppercase and lowercase letters (a - z). 


namespace StringCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(compressString(text));
        }

        public static string compressString(string value)
        {
            String compressedStr = "";
            int countConsecutive = 0;
            for (int i = 0; i < value.Length; i++)
            {
                countConsecutive++;

                if (i + 1 >= value.Length || value[i] != value[i + 1])
                {
                    compressedStr += "" + value[i] + countConsecutive;
                    countConsecutive = 0;
                }
            }
            return compressedStr.Length < value.Length ? compressedStr : value;
        }
    }
}
