Create database AdventureWorksLT
Go
USE AdventureWorksLT; 
GO
CREATE TABLE [dbo].[demoProduct]( [ProductID] [INT] NOT NULL PRIMARY KEY, [Name] [NVARCHAR](50) NOT NULL, [Color] [NVARCHAR](15) NULL, [StandardCost] [MONEY] NOT NULL, [ListPrice] [MONEY] NOT NULL, [Size] [NVARCHAR](5) NULL, [Weight] [DECIMAL](8, 2) NULL, );
Go
CREATE TABLE [dbo].[demoSalesOrderHeader](     [SalesOrderID] [INT] NOT NULL PRIMARY KEY,     [SalesID] [INT] NOT NULL IDENTITY,     [OrderDate] [DATETIME] NOT NULL,     [CustomerID] [INT] NOT NULL,     [SubTotal] [MONEY] NOT NULL,     [TaxAmt] [MONEY] NOT NULL,     [Freight] [MONEY] NOT NULL,    [DateEntered] [DATETIME],     [TotalDue]  AS (ISNULL(([SubTotal]+[TaxAmt])+[Freight],(0))),     [RV] ROWVERSION NOT NULL); 
GO
ALTER TABLE [dbo].[demoSalesOrderHeader] ADD CONSTRAINT [DF_demoSalesOrderHeader_DateEntered] DEFAULT (GETDATE()) FOR [DateEntered]; 
GO
CREATE TABLE [dbo].[demoAddress]( [AddressID] [INT] NOT NULL IDENTITY PRIMARY KEY, [AddressLine1] [NVARCHAR](60) NOT NULL, [AddressLine2] [NVARCHAR](60) NULL, [City] [NVARCHAR](30) NOT NULL, [StateProvince] [NVARCHAR](50) NOT NULL, [CountryRegion] [NVARCHAR](50) NOT NULL, [PostalCode] [NVARCHAR](15) NOT NULL );
GO


select *
from [dbo].[demoProduct]

select*
from [dbo].[demoSalesOrderHeader]


-- 1.
INSERT INTO dbo.demoProduct(ProductID, Name, Color, StandardCost, ListPrice, Size, Weight) VALUES (680,'HL Road Frame - Black,58', 'Black', 1059.31,1431.50,'58',1016.04);
INSERT INTO dbo.demoProduct(ProductID, Name, Color, StandardCost, ListPrice, Size, Weight) VALUES (706,'HL Road Frame - Red, 58','Red',1059.31, 1431.50,'58',1016.04); 
INSERT INTO dbo.demoProduct(ProductID, Name, Color, StandardCost, ListPrice, Size, Weight) VALUES (707,'Sport-100 Helmet, Red','Red',13.0863,34.99,NULL,NULL);
INSERT INTO dbo.demoProduct(ProductID, Name, Color, StandardCost, ListPrice, Size, Weight) VALUES (708,'Sport-100 Helmet, Black','Black',13.0863,34.99,NULL,NULL);
INSERT INTO dbo.demoProduct(ProductID, Name, Color, StandardCost, ListPrice, Size, Weight) VALUES (709,'Mountain Bike Socks, M','White',3.3963,9.50,'M',NULL);

-- 2.
INSERT INTO dbo.demoProduct(ProductID, Name, Color,StandardCost, ListPrice, Size, Weight) VALUES 
(711,'Sport-100 Helmet, Blue', 'Blue', 13.0863, 34.99, NULL, NULL),
(712, 'AWC Logo Cap', 'Multi', 6.9223, 8.99, NULL, NULL),
(713,'Long-Sleeve Logo Jersey,S', 'Multi', 38.4923, 49.99, 'S' ,NULL), 
(714, 'Long-Sleeve Logo Jersey,M', 'Multi', 38.4923, 49.99, 'M', NULL),
 (715, 'Long-Sleeve Logo Jersey,L', 'Multi', 38.4923, 49.99, 'L' ,NULL);


-- 3.
INSERT INTO dbo.demoSalesOrderHeader(SalesOrderID, OrderDate, CustomerID, SubTotal, TaxAmt, Freight) 
SELECT SalesOrderID, OrderDate, CustomerID, SubTotal, TaxAmt, Freight FROM AdventureWorksLT2012.SalesLT.SalesOrderHeader;


-- 4.
SELECT COUNT(ISNULL(SalesOrderID,0)) AS CountOfORders, c.CustomerID, SUM(TotalDue) AS TotalDue 
INTO dbo.tempCustomerSales 
FROM AdventureWorksLT2012.SalesLT.Customer AS c LEFT JOIN AdventureWorksLT2012.SalesLT.SalesOrderHeader AS soh ON c.CustomerID = soh.CustomerID GROUP BY c.CustomerID;


-- 5.
INSERT INTO dbo.demoProduct (ProductID, Name, Color, StandardCost, ListPrice, Size, Weight) SELECT p.ProductID, p.Name, p.Color, p.StandardCost, p.ListPrice,  p.Size, p.Weight FROM AdventureWorksLT2012.SalesLT.Product AS p LEFT OUTER JOIN dbo.demoProduct AS dp ON p.ProductID = dp.ProductID WHERE dp.ProductID IS NULL;

INSERT INTO dbo.demoProduct (ProductID, Name, Color, StandardCost, ListPrice, Size, Weight) SELECT ProductID, Name, Color, StandardCost, ListPrice, Size, Weight FROM AdventureWorksLT2012.SalesLT.Product WHERE ProductID NOT IN (SELECT ProductID FROM dbo.demoProduct WHERE ProductID IS NOT NULL);


-- 6.
SET IDENTITY_INSERT dbo.demoAddress ON;
INSERT INTO dbo.demoAddress(AddressID,AddressLine1,AddressLine2,City, StateProvince, CountryRegion, PostalCode) 
SELECT AddressID, AddressLine1, AddressLine2,City, StateProvince, CountryRegion, PostalCode FROM AdventureWorksLT2012.SalesLT.Address;
SET IDENTITY_INSERT dbo.demoAddress OFF;


select*
from dbo.demoAddress
-- 10.
UPDATE dbo.demoAddress SET AddressLine2 = 'N/A' WHERE AddressLine2 IS NULL;

-- 11.
UPDATE dbo.demoProduct SET ListPrice *= 1.1;

