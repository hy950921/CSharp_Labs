create database company

use company
go

create table HeadOffice
(
	name varchar(20) primary key,
	city varchar(20),
	country varchar(20),
	address varchar(50),
	phone int,
	director varchar(50)
)

create table Project
(
	code int primary key,
	title varchar(20),
	startingdate date,
	enddate date,
	budget decimal,
	incharge varchar(50),
)