create database BB201Library
go
use BB201Library

create table Authors
(
	Id int identity  constraint PK_AUTHORS primary key,
	Name nvarchar(30) check(len(Name)>1),
	Surname nvarchar(40) 
)

create table Books
(
	Id int identity  constraint PK_BOOKS primary key,
	Name nvarchar(100) ,
	PageCount int check(PageCount>3),
	AuthorId int,
	Foreign key(AuthorId) references Authors(Id)
)

insert into Authors values
('Lauren','Mechling'),
('Angie','Thomas'),
('Elizabeth','McCracken'),
('Valeria','Luiselli'),
('Lauren','Philpott'),
('Rachel','Hollis'),
('Lara','Prior-Palme'),
('Julie','Yip-Williams')


insert into Books values
('How Could She',232,1),
('On the Come Up',354,2),
('Bowlaway',423,3),
('Lost Children Archive',144,4),
('I Miss You',343,5),
('Girl, Stop Apologizing',356,6),
('Rough Magic',434,7),
('The Unwinding of the Miracle',276,8),
('There There',266,2),
('Leah on the Offbeat',655,5),
('How Could She',344,4),
('Children of Blood',425,6),
('The President Is Missing',322,3),
('A Spark of Light',266,8),
('Girl, Wash Your Face',355,1),
('Normal People',187,7),
('The Pisces',702,4),
('Red Rising',542,3),
('Dorothy Must Die Stories',453,6),
('The Magician Land',239,5),
('Personal',340,7),
('Revival',250,2),
('The Blood of Olympus',430,3),	
('Being Mortal',344,7)

go



create view VW_BookInfo as 
select B.Id as 'Book ID', B.Name as 'Book Name',B.PageCount 'Count of Page', 
A.Name+' '+A.Surname as 'Author Fullname'  from Books as B
join Authors as A 
on B.AuthorId=A.Id

go

create procedure USP_FINDBYNAMEORAUTHORFULLNAME @name nvarchar(100)
as
select VW.[Book ID] as 'ID', VW.[Book Name] as 'NAME',
VW.[Count of Page] as 'PAGECOUNT', VW.[Author Fullname] as 'AUTHORFULLNAME'
from VW_BookInfo as VW
where @name=VW.[Book Name] or @name = VW.[Author Fullname]

go

create view VW_AllInfo as 
select A.Id as 'id', B.Name as 'bookname',B.PageCount 'countpage', 
A.Name+' '+A.Surname as 'authorfullname'  from Books as B
join Authors as A 
on B.AuthorId=A.Id
go

create view VW_AuthorInfo as
select max(AI.id) as 'Author Id',  AI.authorfullname as 'Full Name',count(AI.countpage) as 'BooksCount', max(AI.[countpage]) as 'MaxPageCount'  from VW_AllInfo as AI
group by AI.authorfullname
go


select * from VW_BookInfo
exec USP_FINDBYNAMEORAUTHORFULLNAME Revival
exec USP_FINDBYNAMEORAUTHORFULLNAME 'Angie Thomas'
select * from VW_AuthorInfo
