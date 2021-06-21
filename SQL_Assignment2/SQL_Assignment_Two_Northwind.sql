-- 14.
select distinct p.ProductName
from [dbo].[Products] as p
inner join [dbo].[Order Details] as d
on d.ProductID = p.ProductID
inner join [dbo].[Orders] o
on d.OrderID = o.OrderID
where o.OrderDate between '1975-01-01' and '2000-01-01'


-- 15.
select top 5 o.ShipPostalCode
from [dbo].[Orders] o
group by o.ShipPostalCode
order by COUNT(o.ShipPostalCode) desc


-- 16.
select top 5 o.ShipPostalCode
from [dbo].[Orders] o
where o.OrderDate between '1980-01-01' and '2000-01-01'
group by o.ShipPostalCode
order by COUNT(o.ShipPostalCode) 


-- 17.
select c.City, COUNT(c.CustomerID) as NumberOfCustomers
from [dbo].[Customers] c
group by c.City


-- 18.
select c.City, COUNT(c.CustomerID) as NumberOfCustomers
from [dbo].[Customers] c
group by c.City
having COUNT(c.CustomerID) > 10


-- 19.
select distinct c.ContactName
from [dbo].[Orders] as o
inner join [dbo].[Customers] as c
on o.CustomerID = c.CustomerID
where o.OrderDate > '1998-01-01'


-- 20.
select  c.ContactName
from [dbo].[Orders] as o
inner join [dbo].[Customers] as c
on o.CustomerID = c.CustomerID
order by o.OrderDate desc


-- 21.
select c.ContactName, COUNT(o.OrderID) as CountOfProduct
from [dbo].[Customers] as c
inner join [dbo].[Orders] as o
on c.CustomerID = o.CustomerID
group by c.ContactName


-- 22.
select c.ContactName, COUNT(o.OrderID) as CountOfProduct
from [dbo].[Customers] as c
inner join [dbo].[Orders] as o
on c.CustomerID = o.CustomerID
group by c.ContactName
having COUNT(o.OrderID) > 100


-- 23.
select su.CompanyName as 'Supplier Comapny Name', sh.CompanyName as 'Shipping Company Name'
from [dbo].[Shippers] as sh, [dbo].[Suppliers] as su


-- 24.
select o.OrderDate, p.ProductName
from [dbo].[Orders] as o
inner join [dbo].[Order Details] as d
on o.OrderID = d.OrderID
inner join [dbo].[Products] as p
on d.ProductID = p.ProductID


-- 25.
select e1.EmployeeID, e2.EmployeeID
from [dbo].[Employees] as e1, [dbo].[Employees] as e2
where e1.EmployeeID <> e2.EmployeeID and e1.Title = e2.Title












