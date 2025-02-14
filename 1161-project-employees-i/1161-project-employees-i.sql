/* Write your T-SQL query statement below */
select P.project_id,ROUND(AVG(E.experience_years*1.00), 2) as average_years
from Project P
 JOIN Employee E
on P.employee_id=E.employee_id
group by P.project_id