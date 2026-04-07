------ 1 => Create a table named "Employees" with columns for ID (integer), Name (varchar), and Salary (decimal)
create table Employees (
	ID int ,
	Name varchar(55),
	Salary decimal(18, 2)
);
-- drop table Employees;
------ 2 => Add a new column named "Department" to the "Employees" table with data type varchar(50).
alter table Employees
add Department varchar(50);

------ 3 => Remove the "Salary" column from the "Employees" table.
alter table Employees
drop column Salary;

------ 4 => Rename the "Department" column in the "Employees" table to "DeptName".
execute sp_rename 'Employees.Department' , 'DeptName' , 'column';

------ 5 => Create a new table called "Projects" with columns for ProjectID (integer) and ProjectName (varchar).
create table Projects (
	ProjectID int,
	ProjectName varchar(100)
);

------ 6 => Add a primary key constraint to the "Employees" table for the "ID" column
alter table Employees
alter column ID int not null; 
alter table Employees
add constraint PK_Employees_ID Primary key (ID);

------ 7 => Create a foreign key relationship between the "Employees" table (referencing "ID") and the "Projects" table (referencing "ProjectID").
alter table Projects
alter column ProjectID int not null; 
alter table Projects
add constraint PK_Projects_ProjectID Primary key (ProjectID);
alter table Employees
add ProjectID int;
alter table Employees
add constraint FK_Employees_Projects foreign key (ProjectID) references Projects(ProjectID);

------ 8 => Remove the foreign key relationship between "Employees" and "Projects."
alter table Employees
drop constraint FK_Employees_Projects;

------ 9 => Add a unique constraint to the "Name" column in the "Employees" table.
alter table Employees
add constraint UQ_Employees_Name unique (Name);

------ 10 => Create a table named "Customers" with columns for CustomerID (integer), FirstName (varchar), LastName (varchar), and Email (varchar), and Status (varchar).
create table Customers (
	CustomerID int,
	FirstName varchar(50),
	LastName varchar(50),
	Email varchar(100),
	Status varchar(20)
);
alter table Customers
alter column CustomerID int not null; 
alter table Customers
add constraint PK_Customers_CustomerID Primary key (CustomerID);
------ 11 => Add a unique constraint to the combination of "FirstName" and "LastName" columns in the "Customers" table.
alter table Customers
add constraint UQ_Customers_FirstName_LastName unique (FirstName, LastName);

------ 12 => Add a default value of 'Active' for the "Status" column in the "Customers" table, where the default value should be applied when a new record is inserted.
alter table Customers
add constraint DF_Customers_Status default 'Active' for Status;

------ 13 => Create a table named "Orders" with columns for OrderID (integer), CustomerID (integer), OrderDate (datetime), and TotalAmount (decimal).
create table Orders (
	OrderID int,
	CustomerID int,
	OrderDate datetime,
	TotalAmount decimal(18, 2)
);

alter table Orders
add constraint FK_Orders_Customers foreign key (CustomerID) references Customers(CustomerID);

------ 14 => Add a check constraint to the "TotalAmount" column in the "Orders" table to ensure that it is greater than zero.
alter table Orders
add constraint CK_Orders_TotalAmount check (TotalAmount > 0);

------ 15 => Create a schema named "Sales" and move the "Orders" table into this schema.
go
create schema Sales;
go
alter schema Sales transfer dbo.Orders;

------ 16 => Rename the "Orders" table to "SalesOrders."
execute sp_rename 'Sales.Orders' , 'SalesOrders'
