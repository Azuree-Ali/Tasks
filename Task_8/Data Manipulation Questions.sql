---- 1 => Select all columns from the "Employees" table.
select * 
from dbo.Employees;

---- 2 => Select only the "Name" and "Salary" columns from the "Employees" table.
select Name, Salary -- note : Salary column was dropped in a previous step, so this will cause an error
from dbo.Employees;

---- 3 => Select distinct values of the "DeptName" column from the "Employees" table.
select distinct DeptName
from dbo.Employees;

----4 => Select the top 5 records from the "Employees" table.
select top 5 *
from dbo.Employees;

----5 => Select all records from the "Employees" table, ordered by the "Salary" column in descending order.
select *
from dbo.Employees
order by Salary desc; -- note : Salary column was dropped in a previous step, so this will cause an error

---- 6 => Select the first 10 records from the "Employees" table, starting from the third record.
select *
from dbo.Employees
order by ID 
offset 2 rows
fetch next 10 rows only;

---- 7 => Select the average salary from the "Employees" table. (search on it)
select avg(Salary) as AverageSalary
from dbo.Employees; -- note : Salary column was dropped in a previous step, so this will cause an error

---- 8 => Select the maximum and minimum salaries from the "Employees" table. (search on it)
select max(Salary) as MaxSalary, min(Salary) as MinSalary
from dbo.Employees; -- note : Salary column was dropped in a previous step, so this will cause an error

---- 9 => Select the top 3 highest salaries from the "Employees" table.
select top 3 Salary
from dbo.Employees

---- 10 => Select all records from the "Employees" table, ordered by "Name" in ascending order.
select *
from dbo.Employees
order by Name asc;

---- 11 Select the first 5 records from the "Employees" table, starting from the second record, ordered by "Salary" in descending order.
select *
from dbo.Employees
order by Salary desc -- note : Salary column was dropped in a previous step, so this will cause an error
offset 1 rows
fetch next 5 rows only;

---- 12 => Select the sum of all salaries from the "Employees" table. (search on it)
select sum(Salary) as TotalSalaries
from dbo.Employees; -- note : Salary column was dropped in a previous step, so this will cause an error

---- 13 => Select records from the "Employees" table where the "Salary" is between 40000 and 60000, ordered by "Salary" in ascending order.
select *
from dbo.Employees
where Salary between 40000 and 60000 -- note : Salary column was dropped in a previous step, so this will cause an error

-- another solution
select *
from dbo.Employees
where Salary >= 40000 and Salary <= 60000 -- note : Salary column was dropped in a previous step, so this will cause an error