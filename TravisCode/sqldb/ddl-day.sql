use sqlweek1;
go 

--create
--alter
--
--truncate

create database sqlweek2;
go 

create schema book;
go 

create table book.contact
(
  contactId int not null
  ,photo varbinary(max) FILESTREAM NULL
  ,photoId UNIQUEIDENTIFIER not null ROWGUIDCOL
  ,firstname NVARCHAR(100) not NULL
  ,lastname nvarchar(200) not NULL
);

create table book.phone
(
  phoneId int primary key 
  ,contactId int null
  ,phonenumber nchar(14) NULL
  ,activeFlag bit not null default(1) 

);

create table book.email
(
  emailid int primary key clustered identity(1,2)
  ,contactId int not NULL
  ,address nvarchar(300) null 
  ,CreatedDate datetime2(7) not null
  ,ChangeDate as sysutcdatetime()
  ,activeFlag bit not null default(1)
);
GO

alter table book.contact
  add constraint PK_contact_contactId primary key clustered (contactId);

alter table book.contact
  add activeFlag bit not null default(1);

alter table book.email
  add constraint CK_email_address check(address like '%@%.%');

alter table book.email
  alter column address nvarchar(50) not null;

alter table book.contact
  drop column activeflag;

--alter table book.contact
  --alter COLUMN contactId int not null primary key;

--alter table book.contact
  --drop constraint PK_contact_contactId;

delete book.contact;
drop table book.email;
drop table book.phone;
drop table book.contact;

truncate book.contact; --drop and create
go
-----------------------------------------------------------------------------------------------------------

-- view: read only access to data
create view book.vw_CustomerAccount with schemabinding
as
select sc.FirstName, sc.LastName, ssoh.AccountNumber 
from SalesLT.Customer as sc 
left join SalesLT.SalesOrderHeader as ssoh on ssoh.CustomerID = sc.CustomerID; 
go 

select * 
from book.vw_CustomerAccount;

--function
create function book.fn_CustomerAccount(@id int)
  return NVARCHAR 
  as
  BEGIN 
    declare @result nvarchar(100);
    
    select @result = sc.FirstName, ' ' , sc.LastName, ' . ' , ssoh.AccountNumber 
    from SalesLT.Customer as sc 
    left join SalesLT.SalesOrderHeader as ssoh on ssoh.CustomerID = sc.CustomerID

    where @input = sc.CustomerID;

    return @result;
  END;
select * from SalesLT.Customer;
select book.fn_CustomerAccount(110);
go

alter FUNCTION book.fn_CustomerAccount2(@date datetime)
returns table 
AS
return 
  select sc.FirstName, sc.LastName, isnull(ssoh.AccountNumber, 'null') as AccountNumber
  from SalesLT.Customer as sc 
  left join SalesLT.SalesOrderHeader as ssoh on ssoh.CustomerID = sc.CustomerID
  where @date <= ssoh.ModifiedDate;
GO

select * from book.fn_CustomerAccount2('2013-01-01');
GO



create proc book.sp_CustomerAccount3
AS
BEGIN
  begin try
  select sc.FirstName, sc.LastName, ssoh.AccountNumber 
  from SalesLT.Customer as sc 
  left join SalesLT.SalesOrderHeader as ssoh on ssoh.CustomerID = sc.CustomerID; 
  throw  
end TRY

  begin CATCH
    print @error_msg
    print @error_level
    print @error_count
  end catch
end;

exec book.sp_CustomerAccount3;
