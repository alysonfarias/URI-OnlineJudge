/*
https://leetcode.com/problems/word-pattern/
Given a pattern and a string s, find if s follows the same pattern.
Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.


Example 1:
Input: pattern = "abba", s = "dog cat cat dog"
Output: true

Example 2:
Input: pattern = "abba", s = "dog cat cat fish"
Output: false

Example 3:
Input: pattern = "aaaa", s = "dog cat cat dog"
Output: false
*/

public class Solution {
    public bool WordPattern(string pattern, string s) {
    string[] strArr = new string[s.Length];
    
    strArr = s.Split(' ');
    
    Dictionary<char,string> dict = new Dictionary<char,string>();
            
    int i=0;
    
    if(pattern.Length!=strArr.Length) return false;
    
    foreach(char c in pattern)
    {
        if(!dict.ContainsKey(c) && !dict.ContainsValue(strArr[i]))
        {
            dict.Add(c,strArr[i]);
        }
        i++;
    }
    
    StringBuilder sp = new StringBuilder();
    
    foreach(char c in pattern)
    {
        if(dict.ContainsKey(c))
        {
             sp.Append(dict[c]);
             sp.Append(" ");
        }
    }
    string newPattern = sp.ToString();
    
    return (newPattern.Trim() == s);
    }
}
