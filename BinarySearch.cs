/*
Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums.
If target exists, then return its index. Otherwise, return -1.
You must write an algorithm with O(log n) runtime complexity.
*/

public class Solution {
    public int Search(int[] nums, int target) {
        int min = 0;
        int max = nums.Length - 1;
        if (nums[0] > target || nums[max] < target) return -1;
        while(min <= max){
            int mid = (min + max) / 2;
            if(target == nums[mid]){
                return mid;
            }
            else if(target < nums[mid]){
                max = mid - 1;
            }
            else{
                min = mid + 1;
            }
        }
        return -1;
    }
}
