/* Write your T-SQL query statement below */
select email as email
from Person
group by email
having count(*)>1