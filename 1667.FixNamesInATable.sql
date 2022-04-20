# https://leetcode.com/problems/fix-names-in-a-table/
SELECT user_id, 
    concat(upper(LEFT(name,1)),lower(substring(name,2))) AS name
FROM Users 
ORDER BY user_id
