create database employee;
use employee;
drop table student;
create table empdetails(
	eid int primary key,
	ename varchar (20),
	eaddress varchar(20),
	contacts bigint unique
);

insert into empdetails values(1,'Prashansa','ktm',1234567890);
insert into empdetails values(2,'rohan','ktm',9234567890);
insert into empdetails values(3,'sohan','ktm',9234567810);
insert into empdetails values(4,'hacker','ktm',9234567210);

create table student(
	sid int primary key identity(1,1),
	sname varchar (20),
	saddress varchar(20),
	contacts bigint 
);
insert into student values(1,'Prashansa','ktm',9999999999);
insert into student values(2,'rohan','ktm',9888888888);
insert into student values(3,'kushal','ktm',9777777777);
insert into student values(4,'hacker','ktm',9666666666);


select* from student;