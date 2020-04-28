use incedo
create table RegisteredUsers( id int identity primary key, name nvarchar(50),email nvarchar(50),password nvarchar(50))

select * from RegisteredUsers
go 
create proc SpRegisterUser
@name nvarchar(50),
@email nvarchar(50),
@password nvarchar(50)
as 
begin 
insert into RegisteredUsers values (@name,@email,@password)
end

