create database ProductDB;
go

create table Products (
  ID int primary KEY
  ,Name1 nchar(20) NULL
  ,Price int null
);

create table Orders (
  ID int primary KEY
  ,ProductID int NULL
  ,CustomerID int NULL
);

create table Customers (
  ID int primary KEY
  ,FirstName nchar(20) NULL
  ,LastName nchar(20) NULL
  ,CardNumber int(16) NULL
);
GO

insert into Products(ID, Name1, Price)
values(1, 'Hat', 20)
,(2, 'Car', 20000)
,(3, 'Computer', 1000);

insert into Orders(ID, ProductID, CustomerID)
values(1, 1, 4)
,(201, 2, 24)
,(332, 3, 33);

insert into Customers(ID, FirstName, LastName, CardNumber)
values(4, 'Aaron', 'Shelton', 121234345656)
,(24, 'Abby', 'Howard', 4444555566667777)
,(33, 'Kira', 'Alfrey', 7777666544432221);
GO



select * from Products;
select * from Orders;
select * from Customers;

insert into Products(ID, Name1, Price)
values(11, 'iPhone', 200);

insert into Customers(ID, FirstName, LastName, CardNumber)
values(55, 'Tina', 'Smith', 7676898945453232);