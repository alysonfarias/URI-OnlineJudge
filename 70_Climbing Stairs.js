//https://leetcode.com/problems/climbing-stairs/description/

/**
 * @param {number} n
 * @return {number}
 */
var climbStairs = function(n) {
    if(n <= 3)
        return n

    let a = 3, b = 2;
    for(let i = 0; i < n-3; i++){
            a = a + b;
            b = a - b;
    }
    return a;
};
