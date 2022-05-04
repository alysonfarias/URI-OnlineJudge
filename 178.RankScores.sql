# https://leetcode.com/problems/rank-scores/
SELECT Score, dense_rank() over(ORDER BY Score DESC) AS 'Rank' FROM Scores
