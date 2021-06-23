create database lending

use lending
go

create table lender
(
	id int primary key identity(1,1),
	name varchar(50),
	balance decimal
)
alter table lender
add borrowerId int

alter table lender
add foreign key(borrowerId) references borrower(id)

create table borrower
(
	id int primary key identity(1,1),
	name varchar(50),
	risk decimal
)


create table loan
(
	code int primary key,
	amount decimal,
	deadline date,
	interest decimal,
	purpose varchar(50)

)
