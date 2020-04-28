use incedo
select * from incedo.dbo.toiler;
select * from toiler;

create table department(
depid int primary key ,
depname varchar(200) not null,
toilerid int foreign key references toiler(toilerid));

select * from department;

INSERT INTO TOILER(TOILERID,NAME,MOBILENUMBER,EMAILID) VALUES (101,'HARISH',10,'HARISH@GMAIL.COM');
insert into toiler(toilerid,name,mobilenumber,emailid) values (102,'isha',99,'isha@gmail.com');
INSERT INTO TOILER(TOILERID,NAME,MOBILENUMBER,EMAILID) VALUES (103,'apoorva',19,'apporva@GMAIL.COM');
insert into toiler(toilerid,name,mobilenumber,emailid) values (104,'sumit',4,'sumit@gmail.com');
INSERT INTO TOILER(TOILERID,NAME,MOBILENUMBER,EMAILID) VALUES (105,'chandni',11,'chandni@GMAIL.COM');
insert into toiler(toilerid,name,mobilenumber,emailid) values (106,'rupali',84,'rupali@gmail.com');
INSERT INTO TOILER(TOILERID,NAME,MOBILENUMBER,EMAILID) VALUES (107,'rajat',16,'rajat@GMAIL.COM');
insert into toiler(toilerid,name,mobilenumber,emailid) values (108,'raghu',96,'raghu@gmail.com');
select * from toiler;

insert into department (depid,depname,toilerid) values(01,'FS',101);
insert into department (depid,depname,toilerid) values(02,'LS',107);
insert into department (depid,depname,toilerid) values(03,'CE',104);
insert into department (depid,depname,toilerid) values(04,'FS',105);
insert into department (depid,depname,toilerid) values(05,'FS',102);
insert into department (depid,depname,toilerid) values(06,'FS',108);

select * from department where depid=01;
update department set toilerid=108 where depid=02;
select * from department;
select distinct (depname),depid from department;

select * from department
delete department where depid=2;
select * from department
use incedo
select count(toilerid)from department
select sum(toilerid) from department
select AVG(toilerid) from department
select min(toilerid) from department
select max(toilerid) from department
select * from department order by toilerid asc
select * from department order by  depname desc, toilerid desc
select count(depid),depname , toilerid from department group by depname ,toilerid
select count(depname),depid from department group by depid --always used with aggreagate function
select max(depname) ,depid from department group by depid
select max(depid),depname from department group by depname
select * from incedo.dbo.toiler
INSERT INTO TOILER(TOILERID,NAME,MOBILENUMBER,EMAILID) VALUES (109,'HARISH',88,'HARISH@GMAIL.COM');
select count(name),name from toiler group by name having count(name)>1
use incedo
select * from department
select sum(toilerid )  from toiler group by name
select distinct name ,emailid from toiler
select * from toiler inner join  department on toiler.toilerid=department.toilerid
select * from toiler inner join  department on toiler.toilerid=department.toilerid where
use incedo
create table salary(salid int, salary money, depid int)
insert into salary(salid,salary,depid)values(11,2000,02)
insert into salary(salid,salary,depid)values(12,3300,03)
insert into salary(salid,salary,depid)values(13,6666,04)
insert into salary(salid,salary,depid)values(14,2400,02)
insert into salary(salid,salary,depid)values(15,2000,05)
select * from salary

select * from toiler t join department d on t.toilerid=d.depid join salary s on d. depid=s.salid where s.salary>2000
