/**
https://leetcode.com/problems/duplicate-emails/
Write an SQL query to report all the duplicate emails.

Return the result table in any order.

The query result format is in the following example.

Example 1:

Input: 
Person table:
+----+---------+
| id | email   |
+----+---------+
| 1  | a@b.com |
| 2  | c@d.com |
| 3  | a@b.com |
+----+---------+
Output: 
+---------+
| Email   |
+---------+
| a@b.com |
+---------+
Explanation: a@b.com is repeated two times.
**/
# Write your MySQL query statement below
SELECT `email` FROM `Person` GROUP BY `email` HAVING COUNT(*)>1
