# https://leetcode.com/problems/bank-account-summary-ii/
SELECT name, balance
FROM (SELECT account, SUM(amount) AS balance
    FROM Transactions
    GROUP BY account
    HAVING SUM(amount) > 10000) t
JOIN Users u
ON u.account = t.account;
