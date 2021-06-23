create database restaurant

use restaurant
go

create table course 
(
	name varchar(20) primary key,
	description varchar(50),
	photo varchar(20),
	price decimal not null
)

alter table course
add catagory varchar(20) not null

create table catagory
(
	name varchar(20) primary key,
	description varchar(50),
	incharge varchar(50)
)

alter table course
add foreign key (catagory) references catagory(name)


create table recipe
(
	ingredient varchar(20) primary key,
	amount decimal,
	unit decimal,
	currentamount decimal
)