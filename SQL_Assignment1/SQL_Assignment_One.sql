-- 1.
select p.ProductID, p.Name, p.Color, p.ListPrice
from Production.Product p

-- 2.
select p.ProductID, p.Name, p.Color, p.ListPrice
from Production.Product p
where p.ListPrice = 0

-- 3.
select p.ProductID, p.Name, p.Color, p.ListPrice
from Production.Product p
where p.Color is null

-- 4.
select p.ProductID, p.Name, p.Color, p.ListPrice
from Production.Product p
where p.Color is not null

-- 5.
select p.ProductID, p.Name, p.Color, p.ListPrice
from Production.Product p
where p.Color is not null and p.ListPrice > 0

-- 6.
select p.Name, p.Color
from Production.Product p
where p.Color is not null

-- 7.
select p.Name, p.Color
from Production.Product p
where p.Color = 'Black' or p.Color = 'Silver'

-- 8.
select p.ProductID, p.Name
from Production.Product p
where p.ProductID between 400 and 500

-- 9.
select p.ProductID, p.Name, p.Color
from Production.Product p
where p.Color = 'Black' or P.Color = 'Blue'

-- 10.
select *
from Production.Product p
where p.Name like 's%'

-- 11.
select p.Name, p.ListPrice
from Production.Product p
order by p.Name

-- 12.
select p.Name, p.ListPrice
from Production.Product p
where p.Name like 'A%' or p.Name like 'S%'
order by p.Name

-- 13.
select p.Name, p.ListPrice
from Production.Product p
where p.Name like 'SPO%' and p.Name not like '___K%'
order by p.Name

-- 14.
select distinct p.Color
from Production.Product p
where p.Color is not null
order by p.Color desc

-- 15.
select distinct p.ProductSubcategoryID, p.Color
from Production.Product p
where p.ProductSubcategoryID is not null
and p.Color is not null

-- 16.
SELECT ProductSubCategoryID
      , LEFT([Name],35) AS [Name]
      , Color, ListPrice 
FROM Production.Product
WHERE ProductSubCategoryID = 1 and (Color not IN ('Red','Black') 
      OR ListPrice BETWEEN 1000 AND 2000)
ORDER BY ProductID

-- 17.
select distinct p.ProductSubcategoryID, p.Name, p.Color, p.ListPrice
from Production.Product p
where p.color in ('Black', 'Red', 'Silver', 'Yellow')
and p.ProductSubcategoryID <= 14
order by p.ProductSubcategoryID desc, p.ListPrice desc