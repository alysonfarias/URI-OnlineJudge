using System;
//Given two strings, write a method to decide if one is a permutation of the
//other.
namespace CheckPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assuming case sensitive and whitespace is relevant
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            Console.WriteLine(checkPermutation(str1, str2));
        }

        public static bool checkPermutation(string value, string secondValue)
        {
            if (value.Length != secondValue.Length) return false;

            return sort(value).Equals(sort(secondValue));
        }

        public static string sort(string sort)
        {
            char[] characters = sort.ToCharArray();
            Array.Sort(characters);
            return new string(characters);
        }


    }
}
