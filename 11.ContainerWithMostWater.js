//https://leetcode.com/problems/container-with-most-water/
/**
 * @param {number[]} height
 * @return {number}
 */
function maxArea(height) {
  let max = 0;
  let i = 0;
  let j = height.length - 1;

  while (j > i) {
    const a = height[i];
    const b = height[j];

    const area = Math.min(a, b) * (j - i);

    if (area > max) max = area;

    if (b > a) i++;
    else j--;
  }

  return max;
}
