/* Write your T-SQL query statement below */
select (
    select salary as SecondHighestSalary 
    from Employee 
    group by salary
    order by salary desc  offset 1 rows fetch next 1 rows only
) as SecondHighestSalary