/* 
https://leetcode.com/problems/single-number/
Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

You must implement a solution with a linear runtime complexity and use only constant extra space.
Example 1:

Input: nums = [2,2,1]
Output: 1
*/
public class Solution {
    public int SingleNumber(int[] array) {
        // I need to see this solution with more attention
        // Do XOR of all elements and return
        int res = array[0];
        for (int i = 1; i < array.Length; i++)
            res = res ^ array[i];
     
        return res;
    }
}
