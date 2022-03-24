/*
https://leetcode.com/problems/pascals-triangle/
Given an integer numRows, return the first numRows of Pascal's triangle.

In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:

Example 1:

Input: numRows = 5
Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
Example 2:

Input: numRows = 1
Output: [[1]]
*/

public class Solution {
    public IList<IList<int>> Generate(int numRows) {
            IList<IList<int>> result = new List<IList<int>>();
            if (numRows == 0)
            {
                return result;
            }
            List<int> row = new List<int>();
            row.Add(1);
            result.Add(row);
            if (numRows == 1)
            {
                return result;
            }

            for (int i = 1; i < numRows; i++)
            {
                var prevRow = result[i - 1];
                row = new List<int>();
                row.Add(1);
                for (int j = 0; j < prevRow.Count - 1; j++)
                {
                    row.Add(prevRow[j] + prevRow[j + 1]);
                }
                row.Add(1);
                result.Add(row);
            }
            return result;
    }
}
