use sql1week1;
go 

select sc.FirstName, sc.LastName, sa.AddressLine1, sa.City 
from SalesLt.Customer as sc 
inner join SalesLT.CustomerAddress as sca on sca.CustomerID = sc.CustomerID
inner join SalesLT.Address as sa on sa.AddressID = sca.AddressID 
where sc.FirstName = 'katherine';

select sc.FirstName, sc.LastName, sa.AddressLine1, sa.City 
from SalesLt.Customer as sc 
left join SalesLT.CustomerAddress as sca on sca.CustomerID = sc.CustomerID
inner join SalesLT.Address as sa on sa.AddressID = sca.AddressID 
where sc.FirstName = 'katherine';

select sc.FirstName, sc.LastName, sa.AddressLine1, sa.City 
from SalesLt.Customer as sc 
left join SalesLT.CustomerAddress as sca on sca.CustomerID = sc.CustomerID
left join SalesLT.Address as sa on sa.AddressID = sca.AddressID 
where sc.FirstName = 'katherine';

select *
from SalesLT.Customer
where FirstName = 'katherine';

select FirstName
from SalesLT.Customer
union 
select Name 
from SalesLt.Product;

select distinct FirstName
from SalesLT.Customer
union all
select Name 
from SalesLt.Product;

select FirstName
from SalesLT.Customer
intersect
select LastName
from SalesLT.Customer

select FirstName
from SalesLT.Customer
except
select LastName
from SalesLT.Customer
intersect 
select LastName
from SalesLT.Customer

select sc.FirstName, sc.LastName, ssoh.AccountNumber, sp.Name, ssod.SalesOrderQty
from SalesLT.Customer as sc 
inner join SalesLT.SalesOrderHeader as ssoh on ssoh.CustomerID = sc.CustomerID
left join SalesLT.SalesOrderDetail as ssod on ssod.SalesOrderID = ssoh.SalesOrderID
left join SalesLT.Product as sp on sp.ProductID = ssod.ProductID;
where ssod.OrderQty > 5 and sp.Name like '%mountain%';

select sc.FirstName, sc.LastName, ssoh.AccountNumber, sp.Name, ssod.OrderID
from SalesLT.Customer as sc 
inner join (
  select CustomerID, AccountNumber 
  from SalesLT.SalesOrderHeader
) as ssoh on ssoh.CustomerID = sc.CustomerID
left join (
  select SalesOrderID, OrderQty, ProductID 
  from SalesLT.SalesOrderDetail 
  where OrderQty > 5
) as ssod on ssod.SalesOrderID = ssoh.SalesOrderID
left join (
  select ProductID, Name
  from SalesLT.Product
  where Name like '%mountain%'
) as sp on sp.ProductID = ssod.ProductID;

