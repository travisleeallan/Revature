create database EmployeeDB;
go

create table Employee (
  ID int primary KEY
  ,FirstName nchar(20) NULL
  ,LastName nchar(20) NULL
  ,SocialSecurity nchar(11)
  ,DeptID int NULL
);


create table Department (
  ID int primary KEY
  ,Names nchar(50) NULL
  ,Locations nchar(100) NULL
);


create table EmpDetails (
  ID int primary KEY
  ,EmployeeID int NULL
  ,Salary int NULL
  ,Address1 nchar(100) NULL
  ,Address2 nchar(100) NULL
  ,City nchar(20) NULL
  ,StateProvence nchar(20) NULL
  ,Country nchar(100) NULL
);
GO

insert into Employee (ID, FirstName, LastName, SocialSecurity, DeptID)
values(1, 'Sharon', 'Denim', '555-55-5555', 201)
,(2, 'Steve', 'Rictor', '123-45-6789', 101)
,(3, 'Fred', 'Belotte', '987-65-4321', 555);

insert into Department (ID, Names, Locations)
values(101, 'The department of This&That', 'Montreal, QB')
,(201, 'Toys&Games', 'Salina, KS')
,(555, 'Revature-USF', 'Tampa, Fl');

insert into EmpDetails (ID, EmployeeID, Salary, Address1, Address2, City, StateProvence, Country)
values(1, 6335, 50000, '2212 Mulberry Ln', 'P.O. Box 7225', 'Montreal', 'Quebec', 'Canada')
,(2, 7632, 100000, '425 Fulton St.', '', 'Salina', 'Kansas', 'United States')
,(3, 999, 100000000, '2232 Network Pl.', '', 'Tampa', 'Florida', 'United States');
GO

select * from Employee;
select * from Department;
select * from EmpDetails;

insert into Employee (ID, FirstName, LastName, SocialSecurity, DeptID)
values(4412, 'Tina', 'Smith', '444-44-4444', 643);

insert into Department (ID, Names, Locations)
values(643, 'Marketing', 'Hollywood, CA');

select FirstName, LastName
from Employee
left join Department on Employee.DeptID = Department.ID
where Department.Names = 'Marketing';
GO

select SUM(EmpDetails.Salary)
from EmpDetails
left join Employee on EmpDetails.ID = Employee.ID
left join Department on Employee.DeptID = Department.ID
where Department.Names = 'Marketing';
GO

