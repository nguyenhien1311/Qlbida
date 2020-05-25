CREATE DATABASE QLBIDA
GO
USE QLBIDA
GO
CREATE TABLE TableCategory
(
	TableCatId int primary key identity(1,1),
	TableCatName nvarchar(50)
)
go
INSERT INTO TableCategory VALUES 
(N'Bàn Pool'),
(N'Bàn Carom'),
(N'Bàn Snooker')	
GO

CREATE TABLE BidaTable
(
	TableId int primary key identity(1,1),
	TableName nvarchar(50),
	TableCatID int foreign key references TableCategory(TableCatId),
	Price float,
	TableStatus int default(1),
)
go
INSERT INTO BidaTable VALUES 
(N'Bàn số 1',1,80000,1),
(N'Bàn số 2',1,80000,1),
(N'Bàn số 3',1,80000,1),	
(N'Bàn số 4',1,80000,1),
(N'Bàn số 5',2,94000,1),
(N'Bàn số 6',2,94000,1),
(N'Bàn số 7',2,94000,1),
(N'Bàn số 8',2,94000,1),
(N'Bàn số 9',3,134000,1),
(N'Bàn số 10',3,134000,1),
(N'Bàn số 11',3,134000,1),
(N'Bàn số 12',3,134000,1),
(N'Bàn số 13',3,134000,1),
(N'Bàn số 14',3,134000,1),
(N'Bàn số 15',3,134000,1),
(N'Bàn số 16',3,134000,1)
GO
CREATE TABLE Customer
(
	CusId int primary key identity(1,1),
	CusName nvarchar(100),
	CusAddress nvarchar(200),
	CusPhone varchar(10),
	CusLevel int default(0)
)
go
INSERT INTO Customer VALUES
(N'Nguyễn Văn Long',N'Cầu Giấy,Hà Nội','0988888888',0),
(N'Trần Bình Định',N'Ba Đình,Hà Nội','0977777777',1),
(N'Lê Quang Hiếu',N'Mai Dịch,Hà Nội','0966666666',0),
(N'Lê Văn Sơn',N'Đống Đa,Hà Nội','0955555555',1),
(N'Trần Thế Duyệt',N'Cầu Giấy,Hà Nội','0933333333',0),
(N'Vũ Minh Đạt',N'Đống Đa,Hà Nội','0922222222',1),
(N'Trần Linh Thiên Vy',N'Ba Đình,Hà Nội','0910101010',1)
GO
CREATE TABLE ServiceCategory
(
	SvCatId int primary key identity(1,1),
	SvCatName nvarchar(30)
)
go
INSERT INTO ServiceCategory VALUES 
(N'Đồ uống'),
(N'Đồ ăn'),
(N'Thuốc lá')
GO
CREATE TABLE TableService
(
	SvId int primary key identity(1,1),
	SvName nvarchar(50),
	SvCatId int foreign key references ServiceCategory(SvCatId),
	Price float,
	Quantity int
)
go
INSERT INTO TableService VALUES 
(N'Nước ngọt Number One',1,12000,30),
(N'Nước ngọt Sting đỏ',1,10000,30),
(N'Nước ngọt Sting vàng',1,10000,30),
(N'Nước suối',1,5000,30),
(N'Nước 7 up',1,10000,30),
(N'Cafe đen',1,15000,30),
(N'Cafe sữa',1,15000,30),
(N'Bim bim',2,10000,30),
(N'Bánh mì trứng',2,12000,30),
(N'Bim bim',2,10000,30),
(N'Bánh mì trứng',2,12000,30),
(N'Bánh mì xúc xích',2,12000,30),
(N'Bánh mì bò khô',2,12000,30),
(N'Gói hạt hướng dương',2,5000,30),
(N'Thuốc lá thăng long',3,10000,30),
(N'Thuốc lá 555',3,30000,30),
(N'Thuốc lá Marlboro',3,22000,30),
(N'Thuốc lá Mond Mond Gold',3,30000,30),
(N'Thuốc lá Mond Mond Black',3,20000,30)
GO
CREATE TABLE  OrderTable
(
	OrderId int primary key identity(1,1),
	CusId int foreign key references Customer(CusId) null,
	TableId int foreign key references BidaTable(TableId),
	StartTime datetime, 
	EndTime datetime,
	Surcharge float default(0),
	Price float,
	Note nvarchar(300),
	OrdStatus int
)
go

CREATE TABLE OrdDetail
(
	OrderId int foreign key references OrderTable(OrderId),
	SvId  int foreign key references TableService(SvId),
	Quantity int,
	Price float
)	
GO

CREATE TABLE Account
(
	Name nvarchar(50),
	Email varchar(100),
	Phone varchar(10),
	UserName varchar(30),
	Password varchar(30),
	AccLevel int default(1)
)
go
INSERT INTO ACCOUNT VALUES
(N'Nguyễn Hữu Hiền','Hien@gmail.com',0987654321,'admin','admin',2),
(N'Nguyễn Ngọc Ánh','Anh@gmail.com',0987654321,'NV01','123456',1),
(N'Trần Văn Đạt','Dat@gmail.com',0987654321,'NV02','123456',1),
(N'Lê Thị Mai','Mai@gmail.com',0987654321,'NV03','123456',1),
(N'Trần Trung Quân','Quan@gmail.com',0987654321,'NV04','123456',1)
GO