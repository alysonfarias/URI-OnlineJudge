using System;
//  Is Unique: Implement an algorithm to determine if a string has all unique characters. What if you
// cannot use additional data structures ?

namespace IsUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assuming that I am just using ASCII and not UNICODE, one solution for this problem could be
            string x = Console.ReadLine();
            Console.WriteLine(isUnique(x)); 

        }

        public static bool isUnique(string value)
        {
            if (value.Length > 128) return false;

            bool[] char_set = new bool[128];
            for (int i = 0; i < value.Length; i++)
            {
                int val = value[i];
                if (char_set[val])
                {
                    return false;
                }
                char_set[val] = true;
            }
            return true;
        }
    }
}
