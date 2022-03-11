create database employee;
use employee;

create table empdetails(
	eid int primary key,
	ename varchar (20),
	eaddress varchar(20),
	contacts int
);

insert into empdetails values(2,'Prashansa','ktm',1234567890);

select* from empdetails;