-- 1.
select count(p.ProductID)
from Production.Product p


-- 2.
select COUNT(p.ProductID)
from [Production].[Product] p
where p.ProductSubcategoryID is not null


-- 3.
select p.ProductSubcategoryID, COUNT(p.ProductID) as CountedProducts
from [Production].[Product] p
group by p.ProductSubcategoryID


-- 4.
select COUNT(*)
from [Production].[Product] p
where p.ProductSubcategoryID is null


-- 5.
select SUM(p.Quantity)
from [Production].[ProductInventory] p


-- 6.
select p.ProductID, SUM(p.Quantity) as TheSum
from Production.ProductInventory p
where p.LocationID = 40
group by p.ProductID
having SUM(p.Quantity) < 100


-- 7.
select p.Shelf, ProductID, SUM(p.Quantity) as TheSum
from Production.ProductInventory p
where p.LocationID = 40
group by p.Shelf, ProductID
having SUM(p.Quantity) < 100


-- 8.
select AVG(p.Quantity)
from Production.ProductInventory p
where p.LocationID = 10


-- 9.
select p.ProductID, p.Shelf, AVG(p.Quantity) as TheAvg
from Production.ProductInventory p
group by p.ProductID, p.Shelf


-- 10.
select p.ProductID, p.Shelf, AVG(p.Quantity) as TheAvg
from Production.ProductInventory p
where p.Shelf <> 'N/A'
group by p.ProductID, p.Shelf


-- 11.
select p.Color, p.Class, count(*) as TheCount, AVG(p.ListPrice) as AvgPrice
from [Production].[Product] p
where p.Color is not null and p.Class is not null
group by p.Color, p.Class


-- 12.
select c.Name as Country, s.Name as Province
from [Person].[CountryRegion] as c
inner join [Person].[StateProvince] as s
on c.CountryRegionCode = s.CountryRegionCode


-- 13.
select c.Name as Country, s.Name as Province
from [Person].[CountryRegion] as c
inner join [Person].[StateProvince] as s
on c.CountryRegionCode = s.CountryRegionCode
where c.Name = 'Germany' or c.Name = 'Canada'