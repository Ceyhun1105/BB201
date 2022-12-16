
create database TapAzTask
go
USE TapAzTask


create table Brands
(
	Id int identity constraint PK_Brands primary key,
	Name nvarchar(30) not null constraint UQ_BRANDS_NAME unique
)

create table Models
(
	Id int identity constraint PK_Models primary key,
	Name nvarchar(30) not null constraint UQ_Models_NAME unique,
	BrandId int foreign key(BrandId) references Brands(Id)
)

create table Materials
(
	Id int identity constraint PK_Materials primary key,
	Name nvarchar(30) not null constraint UQ_Materials_NAME unique
)

create table Colors
(
	Id int identity constraint PK_Colors primary key,
	Name nvarchar(30) not null constraint UQ_Colors_NAME unique
)

create table Features
(
	Id int identity constraint PK_Features primary key,
	Name nvarchar(30) not null constraint UQ_Features_NAME unique
)


create table Phones
(
	Id int identity constraint PK_Phones primary key,
	Price float not null,
	Storage int not null,
	ModelId int foreign key(ModelId) references Models(Id),
	MaterialId int foreign key (MaterialId) references Materials(Id)
)

create table PhoneColors
(
	Id int identity constraint PK_PhoneColors primary key,
	ColorId int foreign key(ColorId) references Colors(Id),
	PhoneId int foreign key(PhoneId) references Phones(Id)
)
create table PhoneFeatures
(
	Id int identity constraint PK_PhoneFeatures primary key,
	FeatureId int foreign key(FeatureId) references Features(Id),
	PhoneId int foreign key(PhoneId) references Phones(Id)
)



Insert into Brands
values
('Iphone'),('Samsung'),('Xiaomi'),('Huawei')


Insert into Models
values 
('Iphone 14',1),('Iphone 12',1),('A72',2),('S22 ultra',2),('Mi 10 Lite',3),('P50 Pocket',4),('A52',2),('Redmi 5',3)

insert into Materials
values
('Glass'),('Plastic'),('Iron'),('Aluminum')

insert into Colors
values
('black'),('green'),('white'),('red'),('grey')

insert into Features
values
('Delivery'),('New'),('SecondHand'),('Dual Sim')


insert into Phones
values
(2000,128,2,1),(4500,256,1,4),(900,256,3,2),(2500,256,4,4),(950,128,5,1),(3700,256,6,3),(355,64,7,2),(1700,64,2,4),(560,128,6,2),(3400,128,1,1),(770,64,3,3)

Update Phones
set Price=2560 where Id=9

insert into PhoneColors
values
(1,2),(4,1),(3,3),(2,5),(3,5),(1,4),(2,8),(3,7),(1,7),(2,6),(1,10),(5,11),(1,9)


insert into PhoneFeatures
values
(1,1),(2,1),(2,2),(4,2),(3,3),(4,3),(1,4),(2,4),(4,4),(1,5),(2,5),(2,6),(4,6),(3,7),(4,7),(1,8),(3,8),
(4,9),(2,9),(1,10),(3,10),(4,10),(2,11),(4,11)


select Md.Name , Ph.Price, Ph.Storage, Mt.Name from Phones as Ph
Join Models as Md 
ON Md.Id = Ph.ModelId
Join Materials as Mt
On Mt.Id=Ph.MaterialId

