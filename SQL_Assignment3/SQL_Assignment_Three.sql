-- 1.
select distinct e.city
from [dbo].[Employees] as e
inner join [dbo].[Customers] as c
on e.City = c.City


-- 2.a
select c.city
from [dbo].[Customers] as c
where c.City not in 
					(select e.city
					from [dbo].[Employees] as e
					where e.City is not null)


-- 2.b
select c.city
from [dbo].[Customers] as c
left join [dbo].[Employees]  as e
on c.City = e.City
where e.City is null




-- 3.
select p.ProductName, sum(o.Quantity) as 'total order quantities'
from [dbo].[Products] as p
inner join [dbo].[Order Details] as o
on p.ProductID = o.ProductID
group by p.ProductName


-- 4.
select c.City, count(d.ProductID) as 'total products'
from [dbo].[Customers] as c
inner join [dbo].[Orders] as o
on c.CustomerID = o.CustomerID
inner join [dbo].[Order Details] as d
on o.OrderID = d.OrderID
group by c.city
order by c.City


-- 5.
select distinct c.City
from [dbo].[Customers] as c
where c.City in (
						select c.City
						from [dbo].[Customers] as c
						group by c.City
						having COUNT(c.CustomerID) >= 2
					)



-- 6.
select c.City, count(distinct d.ProductID) as 'total products'
from [dbo].[Customers] as c
inner join [dbo].[Orders] as o
on c.CustomerID = o.CustomerID
inner join [dbo].[Order Details] as d
on o.OrderID = d.OrderID
group by c.city
having count(distinct d.ProductID) > 2
order by c.City


-- 7.
select distinct c.ContactName
from [dbo].[Customers] as c
inner join [dbo].[Orders] as o
on c.CustomerID = o.CustomerID
where c.City <> o.ShipCity


-- 8.
select top 5 p.ProductName, AVG(p.UnitPrice) as 'Average Price', c.City
from [dbo].[Products] as p
join [dbo].[Order Details] as d
on p.ProductID = d.ProductID
join [dbo].[Orders] as o
on d.OrderID = o.OrderID
join [dbo].[Customers] as c
on o.CustomerID = c.CustomerID
group by p.ProductName, c.City
order by COUNT(d.Quantity) desc


-- 9.
select e.City
from [dbo].[Employees] as e
where e.City not in (
					select c.City
					from [dbo].[Customers] as c
					left join [dbo].[Orders] as o
					on c.CustomerID = o.CustomerID
					where o.OrderID is null
				)


-- 11.
-- first locate the duplicate rows using group by
-- then remove those rows using delete


-- 13.
select d.deptname, count(e.empid) rank()
from employee as e
join dept as d
on e.deptid = d.deptid


-- 14.
select top 3 d.deptname, e.empid, e.salary
from employee as e
join dept as d
on e.deptid = d.deptid
group by d.depname
order by e.salary











