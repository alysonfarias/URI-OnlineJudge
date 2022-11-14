// 283. Move Zeroes
// https://leetcode.com/problems/move-zeroes/


/**
 * @param {number[]} nums
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var moveZeroes = function(nums) {
        if (nums.length == 0 || nums == null) return;
        let idx = 0;
        for (let i = 0; i < nums.length; i++) 
            if (nums[i] != 0) 
                nums[idx++] = nums[i];
            
        while (idx < nums.length)
            nums[idx++] = 0;
        
        return;
};
