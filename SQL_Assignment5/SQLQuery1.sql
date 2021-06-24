-- 1.
-- SQL objects are schemas, journals, catalogs, tables, aliases, views, indexes, constraints, triggers, masks, permissions, sequences, stored procedures, user-defined functions, user-defined types, global variables, and SQL packages.

-- 2.
-- a method to improve the querying performance, but may need more memoery

-- 3.
-- cluster and non cluster

-- 4.
-- no, with the primary key

-- 5.
-- no, only one cluster index

-- 6.
-- yes

-- 7.
--no

-- 8.
-- a way to reduce redundent data

-- 9.
-- anti-normalization

 -- 10. atomic data

 -- 11. unique, not null, check, priamry

 -- 12 unique + not null = primary

 -- 13. reference to primary key in aother table

 -- 14. yes

 -- 15. no , yes
 -- 16. no
 --17. explicit and inplicit transaction



-- 1.
select c.iname, sum(o.amount)
from customer as c
join order as o
on c.cust_id = o.cust_id
group by c.iname
where o.order_date between '2002-01-01' and '2002-12-31'



-- 2.
select*
from person as p
where p.lastname like 'A%'


-- 3.
select p1.name 
from person as p1
left join person as p2
on p1.manager_id = p2.person_id