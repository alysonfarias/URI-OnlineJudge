# https://leetcode.com/problems/capital-gainloss/
SELECT stock_name, SUM(if(operation='sell', price,-price)) AS capital_gain_loss
FROM stocks
GROUP BY stock_name
