create database task_db;
go
use task_db;
go
-- part 1
-- 1
create table employees (
	id int primary key,
	FirstName varchar(50),
	LastName varchar(50),
	Salary decimal(10, 2)
);

create procedure GetAllEmployees 
as
begin
	select * from employees;
end;
exec GetAllEmployees;
-- 2
create procedure GetHighSalaryEmployees (@MinSalary as decimal(10, 2))
as 
begin
	select * 
	from employees 
	where Salary > @MinSalary;
end;
exec GetHighSalaryEmployees @MinSalary = 50000.00;
-- 3
create procedure AddEmployeee (@FirstName as varchar(50), @LastName as varchar(50), @Salary as decimal(10, 2))
as
begin
	insert into employees (id ,FirstName, LastName, Salary)
	values (1,@FirstName, @LastName, @Salary);
end;
exec AddEmployeee @FirstName = 'John', @LastName = 'Doe', @Salary = 60000.00;
-- part 2
create table EmployeeLog(
	Id int primary key identity,
	EmployeeId int,
	Action varchar(50),
	ActionDate datetime default getdate()
);
go
create trigger trgAfterInsert ON employees
after insert
as
begin
	insert into EmployeeLog(EmployeeId, Action)
	values ((select id from inserted), 'Inserted');
end;
go
insert into employees (id, FirstName, LastName, Salary) values (2, 'Jane', 'Smith', 70000.00);