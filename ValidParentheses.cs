/*
https://www.c-sharpcorner.com/article/valid-parentheses/
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
 

Example 1:

Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false
 

*/
public class Solution {
    public bool IsValid(string str) {
    int n;
    do
    {
        n = str.Length;
        str = str.Replace("()", "");
        str = str.Replace("{}", "");
        str = str.Replace("[]", "");
    } while (str.Length != n);
    
    if (str.Length == 0)
        return true;
    else
        return false;
    }
}
