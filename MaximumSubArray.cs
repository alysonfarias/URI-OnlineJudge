/*
https://leetcode.com/problems/maximum-subarray/


Given an integer array nums, find the contiguous subarray 
(containing at least one number) which has the largest sum and return its sum.
A subarray is a contiguous part of an array.

Example 1:
Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6
Explanation: [4,-1,2,1] has the largest sum = 6.

Example 2:
Input: nums = [1]
Output: 1
Example 3:
Input: nums = [5,4,-1,7,8]
Output: 23

It can be solved with Kadane Algorithm \/
https://medium.com/@rsinghal757/kadanes-algorithm-dynamic-programming-how-and-why-does-it-work-3fd8849ed73d
*/

public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = int.MinValue;
        int currentSum = 0;
        int size = nums.Length;
        
        for(int i=0; i<size;i++){
            currentSum += nums[i];
            if(maxSum < currentSum)
                maxSum = currentSum;
            if(currentSum < 0) 
                currentSum = 0;
        }
        return maxSum;
    }
}
