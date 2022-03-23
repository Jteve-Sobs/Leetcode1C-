-- Combine Two Tables
-- Difficulty: Easy

-- Runtime: 471 ms, faster than 25.34% of MySQL online submissions for Combine Two Tables.
-- Memory Usage: 0B, less than 100.00% of MySQL online submissions for Combine Two Tables.


select firstName, lastName, city, state
from person p
left join address a on a.personId = p.personID