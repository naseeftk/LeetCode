/* Write your T-SQL query statement below */
/* Write your PL/SQL query statement below */
DELETE FROM PERSON 
WHERE ID NOT IN (SELECT MIN(ID) FROM PERSON GROUP BY EMAIL);