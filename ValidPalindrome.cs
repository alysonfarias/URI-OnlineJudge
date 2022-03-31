/*
https://leetcode.com/problems/valid-palindrome/

A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters,
it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.
*/



public class Solution {
    public bool IsPalindrome(string s) {
            var list = new List<char>();
            s = s.ToLower();
            foreach(var c in s)
            {
                if (char.IsLetterOrDigit(c))
                    list.Add(c);                    
            }

            var len = list.Count;
            if (len == 0)
                return true;

            for (int i = 0; i <= len / 2 ; i++)
            {
                if (list[i] != list[len - 1 - i])
                    return false;
            }
            return true;
    }
}
