# https://leetcode.com/problems/find-total-time-spent-by-each-employee/
SELECT event_day AS day, emp_id, SUM(out_time - in_time) AS total_time
FROM Employees
GROUP by day, emp_id
