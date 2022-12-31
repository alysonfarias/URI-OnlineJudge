//https://leetcode.com/problems/sort-colors/

/**
 * @param {number[]} nums
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var sortColors = function(nums) {
  var m = 0;
  var n = 0;
  var k = nums.length;
  for (var i = 0; i < k; i++) {
    if (nums[i] === 0) {
      nums[i] = 2;
      nums[n++] = 1;
      nums[m++] = 0;
    } else if (nums[i] === 1) {
      nums[i] = 2;
      nums[n++] = 1;
    } else {
      nums[i] = 2;
    }
  }
};
