use TLArevDB1;
go 

select 'Hello sql';
select 1+1;

select *
from SalesLT.Product;

select Name, ProductNumber, Color 
from SalesLT.Product;

select [Name] ProductId, ProductNumber as [Product Number], Color as [Product Color]
from SalesLT.Product;

select Name, ProductNumber, Color
from SalesLT.Product
where ProductID > 700 and (ProductID < 750 or Color = 'red');

select FirstName, MiddleName, LastName
from SalesLT.Customer 
where MiddleName is not null;

select FirstName, MiddleName, LastName
from SalesLT.Customer
where FirstName > 'K';

select FirstName, MiddleName, LastName
from SalesLT.Customer
where FirstName like 'k__[h-p]%';

select FirstName, count(*) as Count
from SalesLT.Customer
where FirstName like 'k%'
group by FirstName;

select FirstName, count(*) as Count
from SalesLT.Customer
where FirstName like 'k%'
group by FirstName
having count(*) > 2 and FirstName like '%i%';

select FirstName, count(*) as Count
from SalesLT.Customer
where FirstName like 'k%'
group by FirstName, LastName
having count(*) > 1 and FirstName like '%i%'
order by FirstName desc, Count asc;

--method of execution
----------------------
--FROM
--WHERE
--GROUP BY
--HAVING
--SELECT
--ORDER BY

--LINQ