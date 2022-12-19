create database BSUAcademy
go 
use BSUAcademy
go
create table Academies
(
	Id int identity(1,1) constraint PK_ACADEMIES primary key,
	Name nvarchar(50)
)
go

insert Academies values
('CodeAcademy'),('EduComp'),('CodeAze')

go

create table Groups
(
	Id int identity(1,1) constraint PK_Groups primary key,
	Name nvarchar(50),
	AcademyId int,
	foreign key (AcademyId) references Academies(Id)
)
go

insert into Groups
values
('BB201',1),('BP201',1),('EC001',2),('EC002',2),('AZE101',3)
go

create table Students
(
	Id int identity(1,1) constraint PK_Students1 primary key,
	Name nvarchar(50),
	Surname nvarchar(50),
	Age int,
	Adulthood nvarchar(5) default 'false',
	GroupId int,
	foreign key (GroupId) references Groups(Id)
)

go

create trigger InsertStudent
on Students
after insert as
Update Students
set Adulthood='true' where Age>17
Update Students
set Adulthood='false' where Age<18


go

create trigger UpdateStudent
on Students
after Update as
Update Students
set Adulthood='true' where Age>17
Update Students
set Adulthood='false' where Age<18

go

insert into Students
values
('Ceyhun','Farzullayev',19,Null,1),
('Samir','Quliyev',17,Null,2),
('Azer','Mehdili',20,Null,2),
('Fehmi','Huseynli',19,Null,1),
('Murad','Aliyev',19,Null,1),
('Sebine','Quluzade',22,Null,1),
('Nihad','Veloyev',16,Null,1),
('Aysun','Hesenli',19,Null,3),
('Sure','Hesenli',17,Null,3),
('Pervin','Ahmedova',20,Null,4),
('Samire','Ahmedova',19,Null,4),
('Turan','Rehmanli',19,Null,4),
('Azer','Memmedli',22,Null,5),
('Shahin','Elizade',16,Null,5)

go

create table DeletedStudents
(
	Id int identity(1,1) constraint PK_DeletedStudents primary key,
	Name nvarchar(50),
	Surname nvarchar(50),
	Age int,
	GroupId int,
	foreign key (GroupId) references Groups(Id)
)

go

create table DeletedGroups
(
	Id int identity(1,1) constraint PK_DeletedGroups primary key,
	Name nvarchar(50),
	AcademyId int,
	foreign key (AcademyId) references Academies(Id)
)


go

create view VW_Academies
as
select * from Academies

go

create view VW_Groups
as
select * from Groups

go

create view VW_Students
as
select * from Students

go

create proc USP_GetGroupByName @name nvarchar(50)
as
Select * from VW_Groups where Name = @name	

go

create proc USP_GetStudentsByUnderAge @age int
as
Select * from VW_Students where Age < @age

go

create proc USP_GetStudentsByOverAge @age int
as
Select * from VW_Students where Age > @age

go

create trigger DeleteStudent
on Students
after delete as
insert into DeletedStudents(Name,Surname,Age,GroupId)
select Name, Surname ,Age, GroupId from deleted

go

create trigger DeleteGroup
on Groups
after delete as
insert into DeletedGroups(Name,AcademyId)
select Name, AcademyId from deleted

select * from VW_Students
go


exec USP_GetGroupByName BP201
go
exec USP_GetGroupByName EC001
go
exec USP_GetStudentsByOverAge 17
go
exec USP_GetStudentsByUnderAge 17
go







