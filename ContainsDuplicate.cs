/*
https://leetcode.com/problems/contains-duplicate

Given an integer array nums, return true if any value appears at least twice in the array, 
and return false if every element is distinct.

Example 1:
Input: nums = [1,2,3,1]
Output: true

Example 2:
Input: nums = [1,2,3,4]
Output: false
*/
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> hashSetValues = new HashSet<int>();
        
        for(int id=0; id<nums.Length; id++){
            if (hashSetValues.Contains(nums[id])){
                return true;
            }
            hashSetValues.Add(nums[id]);            
        }        
        return false;
    }
}

/*
One line with LINQ
public bool ContainsDuplicate(int[] nums)
{
    return nums.Count() > nums.Distinct().Count();
}
*/

