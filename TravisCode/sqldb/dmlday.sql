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

use sqlweek1;
go 

select *
from SalesLT.Address;

--simple
insert into SalesLT.Address
values('123 main st.', null, 'Tampa', 'Fl', 'USA', '33559', '268af621-76d7-4c78-9441-144fd139821b', '2017-08-30');

--correct
insert into SalesLT.Address(AddressLine1, City, StateProvince, CountryRegion, PostalCode, rowguid, ModifiedDate)
values('1234 main st.', null, 'Tampa', 'Fl', 'USA', '33559', '268af621-76d7-4c78-9441-144fd139821b', '2017-08-29'), 
('123 Plain st.', null, 'Dallas', 'Tx', 'USA', '76203', '268af621-76d7-4c78-9441-144fd139821b', '2017-08-30'), 
('123 Bain st.', null, 'Place', 'Tx', 'USA', '75454', '268af621-76d7-4c78-9441-144fd139821b', '2017-08-30');

--multi Records
insert into SalesLT.Address(AddressLine1, City, StateProvince, CountryRegion, PostalCode, rowguid, ModifiedDate)
select AddressLine1, City, StateProvince, CountryRegion, PostalCode, rowguid, ModifiedDate
from SalesLT.Address
where AddressID >= 11384;

--data file
bulk insert SalesLT.Address from 'data.csv' with (rowterminator = '\n', fieldterminator = ',')

-- extended
update a 
set a.AddressLine1 = '789 main st.'
from SalesLT.Address as a
where a.AddressID = 11384;

-- simple
--delete 