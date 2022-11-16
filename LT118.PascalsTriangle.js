//https://leetcode.com/problems/pascals-triangle/

/**
 * @param {number} numRows
 * @return {number[][]}
 */
var generate = function(numRows) {
    let array = [];
    
    for(let i = 0; i < numRows; i++)
    {
        array[i] = [];
        array[i][0] = array[i][i] = 1;
        for(let j = 1; j < i; j++)
        {
               array[i][j] = array[i-1][j] + array[i-1][j-1]; 
        }
    }
    return array;
};
