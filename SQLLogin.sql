create database app;
create table Login(
Account nvarchar(50) primary key ,
Password nvarchar(50) not null);
select COUNT (*) From [dbo].[Login] where Account='admin' And Password='1234';
select *from Login