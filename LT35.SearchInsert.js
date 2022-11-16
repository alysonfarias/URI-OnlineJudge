//35. Search Insert Position
// https://leetcode.com/problems/search-insert-position/
/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */

//Runtime Complexity  O(log n)
var searchInsert = function(nums, target) {
    let start = 0, end = nums.length - 1;

    while(start <= end){
        let mid =  Math.floor((start + end)/2);
        if(nums[mid] == target)
            return mid
        else if(target > nums[mid])
            start = mid + 1;
        else
            end = mid - 1;
    }
    return end + 1;
};
