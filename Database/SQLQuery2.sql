use incedo
declare @tvar table (col1 int,col2 int)
insert into @tvar values(3,3)
select * from @tvar

create table temptable2(col1 int, col2 int)
select * from temptable



declare @tvar1  (col1 int,col2 int)

select * into temptable2 from @tvar(1,1)
select * into @tvar3 from EmployeeDetails

select * into #empo from EmployeeDetails

DECLARE @COURSE_ID  INT =5;
print @course_ID
use incedo
declare @empid int , @name varchar(50) , @course varchar(50)
set @empid=5
set @name= (select fullname from employeedetails where empid =123)--'veera'
set @course='btech'
print @empid
print @name
print @course

declare @id int=(select empid,FullName from EmployeeDetails)
print @id

declare @id int=(select max(empid) from EmployeeDetails)
print @id

declare @id table(emid int)
set @id=(select distinct empid from EmployeeDetails)
use incedo
select * from EmployeeDetails a where exists (select facilities from employeeFacilities b where a.empid=b.empid)
select * from EmployeeDetails a in (select facilities from employeeFacilities b where a.empid=b.empid)

select * from EmployeeDetails a where exists (select facilities from employeeFacilities b where a.empid= b.empid and facilities='pen')
select * from EmployeeDetails a inner join employeeFacilities b on a.empid=b.empid and facilities in('dongal', 'headphones')
select * from EmployeeDetails
select * from employeeFacilities
select * from EmployeSalary
--using join but in this case we can get name of facility as well (is good to use coz it make cartesian product of two tables in a buffer or temporary table so easy to filter out
-- required data but need more space but nowadays to get sapce is easy task by cloud in case of subquery whether it is corelated or non corelated it needs comparison so more 
--comparison means need more input output operations so it consumes more time.
select a.empid ,a.FullName ,a.ManagerId,b.facilities from EmployeeDetails a inner join employeeFacilities b on a.empid=b.empid-- and facilities in('dongal', 'headphones')

--using exists and co related query by this we cant get facility column of another table in this co realated query firstly outer query execute then result of outer query compare data with
 --inner query (inner query executes multiple times ,means untill its last record of table) so after first row comparison then gain takes second row from outer query then again do comparison
 -- with inner query multiples times so do it like same
select a.empid ,a.FullName ,a.ManagerId from EmployeeDetails a where exists  (select facilities from employeeFacilities b where a.empid= b.empid) --and facilities in ('dongal','headphones'))

 --using simple non co related subquery but here also we will not get facility column (in this firstly inner query excute only once then execute outer query means after getting inner query 
 --result ,result will be compared with outer query rows  then give ans)
 select a.empid ,a.FullName ,a.ManagerId from EmployeeDetails a where empid in  (select empid from employeeFacilities b where a.empid=b.empid)-- and facilities in ('dongal','headphones') )

 --------------------------------------------------------------------------------------------------------------------------------------------------
 --Merge : it is basically used for merging two tables but condition both have same columns with same datatype .Purpose of merging is source
 -- table have data but not in target table so need to insert data in target table and sometimes target table have extra information comparitive
 -- to source table so need tol delete information in target table with respect to source table apart from that, sometimes information is not
 -- matched in target table with respect to source table so need to update  target table all in all we can say that at a same time all the 
 --operations insert ,update and delete are done at same time with the help of Merge Query

 CREATE TABLE category (
    category_id INT PRIMARY KEY,
    category_name VARCHAR(255) NOT NULL,
    amount DECIMAL(10 , 2 )
);
 
INSERT INTO category(category_id, category_name, amount)
VALUES(1,'Children Bicycles',15000),
    (2,'Comfort Bicycles',25000),
    (3,'Cruisers Bicycles',13000),
    (4,'Cyclocross Bicycles',10000);
 
 select * from category

CREATE TABLE category_staging (
    category_id INT PRIMARY KEY,
    category_name VARCHAR(255) NOT NULL,
    amountt DECIMAL(10 , 2 )
);
 
 
INSERT INTO category_staging(category_id, category_name, amountt)
VALUES(1,'Children Bicycles',15000),
    (3,'Cruisers Bicycles',13000),
    (4,'Cyclocross Bicycles',20000),
    (5,'Electric Bikes',10000),
    (6,'Mountain Bikes',10000);

	select * from category_staging

	MERGE category t 
    USING category_staging s
ON (s.category_id = t.category_id)
WHEN MATCHED
    THEN UPDATE SET 
        t.category_name = s.category_name,
        t.amount = s.amountt
WHEN NOT MATCHED BY TARGET 
    THEN INSERT (category_id, category_name, amount)
         VALUES (s.category_id, s.category_name, s.amountt)
WHEN NOT MATCHED BY SOURCE 
    THEN DELETE;

	
 select * from category
 select * from category_staging

 truncate table category
 truncate table category_staging