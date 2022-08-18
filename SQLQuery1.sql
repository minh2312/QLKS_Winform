CREATE DATABASE QLHOTEL
GO
USE QLHOTEL
GO



select * from DatPhong


CREATE TABLE Tang
(
	Id int primary key identity,
	Name nvarchar(100),
	Status Tinyint default 1
)
Go
INSERT INTO Tang VALUES('Tầng 5',1)
SELECT * FROM Tang


GO
CREATE TABLE LoaiPhong
(
	Id int primary key identity,
	Name nvarchar(100),
	Price float,
	Status Tinyint default 1
)
Go
DROP TABLE LoaiPhong
GO
INSERT INTO LoaiPhong (Name,Price,Status) VALUES
(N'Phòng Vip',4500000,1),
(N'Phòng Bình Dân',1200000,1),
(N'Phòng ABCXYZ',2000000,1)






GO
CREATE TABLE Room
(
	Id int primary key identity,
	Name nvarchar(150),
	NguoiToiDa int,
	Status Tinyint default 1,
	IdTang int foreign key references Tang(Id),
	IdLoaiPhong int foreign key references LoaiPhong(Id),
)
GO
DROP TABLE Room


GO

INSERT INTO Room (Name,NguoiToiDa,Status,IdTang,IdLoaiPhong) VALUES 
(N'Phòng VIP có Bể bơi nước nóng trong nhà',4,1,3,1),
(N'Phòng Vip có đủ tiện nghi',2,1,3,1)


SELECT * FROM ROom

GO



CREATE TABLE Customer
(
	Id varchar(10) primary key ,
	FullName nvarchar(150),
	CCCD varchar(50),
	Email varchar(150),
	Phone varchar(150),
	Address nvarchar(255),
	Gender tinyint ,
	Birthday Date,
)

GO

DROP TABLE Customer

INSERT INTO Customer  VALUES ('BC123',N'Lê Quang Minh','001202037655','minh@gmail.com','099999999',N'Hà Nội',1,'2002-12-23')
INSERT INTO Customer VALUES ('KH222',N'Trần Thị Thu Huyền','0012024243243','huyenbii@gmail.com','099999999',N'Bắc Giang',1,'2002-09-29')


GO

SELECT * FROM CUSTOMER

CREATE TABLE DatPhong
(
	Id int primary key identity,
	IdCustomer varchar(10) foreign key references Customer(Id),
	RoomId int foreign key references Room(Id),
	Price float,
	StartDate date,
	EndDate date,
	Status Tinyint default 1,
)
GO


GO

CREATE TABLE Account
(
	Id int primary key identity,
	FullName nvarchar(150),
	Email varchar(150) unique,
	Password varchar(255),
	Status bit default 1,
	Role int default 0,
)
Go

DROP TABLE Account

INSERT INTO Account (FullName,Email,Password,Role) VALUES 
(N'Lê Quang Minh','minhaz23122002@gmail.com','123456',1)
(N'Trần Thị Thu Huyền','tranhuyen2002@gmail.com','123456',0)
GO





SELECT * FROM Account



GO
-- Thủ tục Account
CREATE PROCEDURE getAccountByEmail
@email varchar(150)
AS
SELECT * FROM Account WHERE Email = @email
GO
EXEC getAccountByEmail @email = 'minhaz23122002@gmail.com';
DROP PROC getAccountByEmail
GO






-- Thủ tục Account By Id
CREATE PROCEDURE getAccountById
@id int
AS
SELECT * FROM Account WHERE id = @id
GO





GO
-- thủ tục đổi password

CREATE PROCEDURE CapNhapPassword
@id int,
@pass varchar(255)
AS
UPDATE Account SET Password = @pass  WHERE id = @id
GO






GO
-- Thủ tục Quản Lý Tầng
CREATE PROCEDURE GetTangAll
AS
SELECT Id,Name,(CASE Status WHEN 1 THEN N'Hoạt Động' WHEN 0 THEN N'Ngừng Hoạt Động' END) as Status FROM Tang 
GO




GO
-- tìm kiếm theo name Tầng
CREATE PROCEDURE GetTangByName
@name nvarchar(100)
AS
SELECT Id,Name,(CASE Status WHEN 1 THEN N'Hoạt Động' WHEN 0 THEN N'Ngừng Hoạt Động' END) as Status FROM Tang WHERE Name Like '%'+@name+'%'
GO




GO
DROP PROC GetTangAll

GO
-- thủ tục thêm mới
CREATE PROCEDURE AddTang
@name nvarchar(100),
@status Tinyint
AS
INSERT INTO Tang (Name,Status) VALUES (@name,@status)
GO
EXEC AddTang @name= N'Tầng 1',@status = 0
GO


-- thủ tục check name Tầng không trùng
CREATE PROCEDURE CheckNameTang
@name nvarchar(100)
AS
SELECT * FROM Tang WHERE Name = @name
GO



-- thủ tục update
CREATE PROCEDURE UpdateTang
@name nvarchar(100),
@status Tinyint,
@id int
AS
UPDATE Tang SET Name = @name, Status = @status WHERE Id = @id
GO
EXEC UpdateTang @name= N'Tầng 10',@status = 1 , @id = 1

GO








-- thủ tục xóa
CREATE PROCEDURE DeleteTang
@id int
AS
DELETE FROM DatPhong WHERE RoomId = (SELECT Id FROM Room WHERE IdTang = @id) 
DELETE FROM Room WHERE IdTang = @id
DELETE FROM Tang WHERE Id = @id

GO
EXEC DeleteTang @id = 2
GO

DROP PROC DeleteTang

--SELECT Id,Name,(case Status When 1 THEN N'Hiện' WHEN 0 then N'Ẩn' end) as Status FROM Tang 













-- thủ tục của bảng LoaiPhong
CREATE PROC GetAllLoaiPhong
AS 
SELECT * FROM LoaiPhong
GO
EXEC GetAllLoaiPhong
GO






-- thủ tục thêm mới loại phòng
CREATE PROC InsertLoaiPhong
	@name nvarchar(100),
	@price float,
	@status Tinyint
AS 
INSERT INTO LoaiPhong (Name,Price,Status) VALUES (@name,@price,@status);
GO
EXEC InsertLoaiPhong @name =N'Phòng Vip', @price=2500000, @status=1
EXEC InsertLoaiPhong @name =N'Deluxe', @price=50000000, @status=1
GO






-- thủ tục cập nhập
CREATE PROC UpdateLoaiPhong
	@name nvarchar(100),
	@price float,
	@status Tinyint,
	@id int
AS
UPDATE LoaiPhong SET Name=@name, Price=@price, Status =@status WHERE Id = @id
GO






-- thủ tục update loại phòng
CREATE PROC DeleteLoaiPhong
	@id int
AS
DELETE FROM DatPhong WHERE RoomId = (SELECT Id FROM Room WHERE IdLoaiPhong = @id) 
DELETE FROM Room WHERE IdLoaiPhong = @id
DELETE FROM LoaiPhong WHERE Id = @id
GO


DROP PROC DeleteLoaiPhong


-- thủ tục tìm kiếm loại phòng by name
CREATE PROC GetLoaiPhongByName
@name varchar(100)
AS 
SELECT * FROM LoaiPhong WHERE Name LIKE '%'+@name+'%'
GO
EXEC GetLoaiPhongByName
GO










-- Thủ Tục Quản Lý Phòng
CREATE PROC GetAllPhong
AS 
SELECT r.Id , r.Name, r.NguoiToiDa,(Case r.Status WHEN 0 THEN N'Hết Phòng' WHEN 1 THEN N'Còn Phòng' END ) as Status, t.Id, t.Name as NameTang, lp.Id, lp.Name as NameLoaiPhong, lp.Price FROM Room as r 
INNER JOIN Tang as t ON t.Id = r.IdTang
INNER JOIN LoaiPhong as lp ON lp.Id = r.IdLoaiPhong
GO
EXEC GetAllPhong
GO
DROP PROC GetAllPhong





GO
-- 
CREATE PROC GetRoomByTang
@idTang int
AS 
SELECT * FROM Room  WHERE idTang = @idTang;
GO
EXEC GetRoomByTang @idTang = 2
GO
DROP PROC GetRoom
GO




-- thủ tục thêm mới phòng
CREATE PROC InsertRoom
@name nvarchar(150),
@soNguoi int,
@status Tinyint,
@idTang int,
@idLoaiPhong int
AS 
INSERT INTO Room (Name,NguoiToiDa,Status,IdTang,IdLoaiPhong) VALUES (@name,@soNguoi,@status,@idTang,@idLoaiPhong)
GO


EXEC InsertRoom @name = N'Phòng Vip Có Bể Bơi Nước Nóng',
				@soNguoi = 4,
				@status = 1,
				@idTang = 1,
				@idLoaiPhong = 2

GO
EXEC InsertRoom @name = N'Phòng Vip Có Bể Bơi Nước Nóng',
				@soNguoi = 4,
				@status = 1,
				@idTang = 1,
				@idLoaiPhong = 2



DROP PROC InsertRoom

GO





-- thủ tục cập nhập room
CREATE PROC UpdateRoom
@name nvarchar(150),
@soNguoi int,
@status Tinyint,
@idTang int,
@idLoaiPhong int,
@idRoom int
AS 
Update Room SET Name = @name,NguoiToiDa = @soNguoi,Status = @status,IdTang = @idTang,IdLoaiPhong = @idLoaiPhong WHERE Id = @idRoom
GO
DROP PROC UpdateRoom


GO
-- thủ tục update trạng thái của bản room
CREATE PROC UpdateStatusRoom
@status Tinyint,
@idRoom int
AS 
Update Room SET Status = @status WHERE Id = @idRoom
GO

SELECT * FROM Room


-- thủ tục cập nhập trạng thái phòng






-- thủ tục xóa phòng
GO
CREATE PROC DeleteRoom
@idRoom int
AS 
DELETE FROM Room WHERE Id = @idRoom
GO


EXEC DeleteRoom @idRoom = 3




-- tìm kiếm phòng theo name
CREATE PROC GetRoomByName
@name nvarchar(150)
AS 
SELECT r.Id,r.Name,r.NguoiToiDa,r.Status,t.Id,t.Name as NameTang,lp.Id,lp.Name as NameLoaiPhong FROM Room as r 
INNER JOIN Tang as t ON t.Id = r.IdTang
INNER JOIN LoaiPhong as lp ON lp.Id = r.IdLoaiPhong
 WHERE r.Name LIKE '%'+@name+'%'
GO

EXEC GetRoomByName @name = N'Có'






-- CUSTOMER 
GO
 -- tìm Customer by id
CREATE PROC FindCusById
@id int

AS 
SELECT * FROM CUSTOMER WHERE Id = @id
GO

EXEC FindCusById @id = 1

GO
-- insert CUstomer

CREATE PROC InsertCustomer
@id varchar(10),
@fullName nvarchar(150),
@CCCD varchar(50),
@email varchar(150),
@phone varchar(150),
@address nvarchar(255),
@gender tinyint,
@birthday Date

AS 
INSERT INTO CUSTOMER (Id,FullName,CCCD,Email,Phone,Address,Gender,Birthday) VALUES (@id,@fullName ,@CCCD,@email ,@phone ,@address ,@gender ,@birthday)
GO

DROP  PROC InsertCustomer







-- get alll Customer
CREATE PROC GetAllCustomer
AS 
SELECT * FROM CUSTOMER
GO








-- thủ tục Đặt Phòng

-- lấy ra id vừa Thêm mới customer
CREATE PROC getIdInsertCustomer
AS 
SELECT MAX(Id) as idCustomer FROM CUSTOMER 
GO

-- insert Dặt Phòng

CREATE PROC InsertDatPhong
	@idCustomer varchar(10),
	@roomId int ,
	@price float,
	@startDate Datetime,
	@endDate Datetime,
	@status Tinyint 
AS
INSERT INTO DatPhong (IdCustomer,RoomId,Price,StartDate,EndDate,Status) VALUES(@idCustomer,@roomId,@price,@startDate,@endDate,@status);
GO


EXEC InsertDatPhong @idCustomer ='KH222' ,@roomId =1 ,@price =35000000 , @startDate ='2022/12/12' ,@endDate = '2022/12/14' ,@status = 1





-- láy ra tất cả thông tin đặt phòng
CREATE PROC GetAllDatPhong
AS
SELECT dp.Id, c.FullName as FullName, r.Name as RoomName, dp.Price, dp.StartDate, dp.EndDate, (Case dp.Status WHEN 0 THEN N'Đã Thanh Toán' WHEN 1 THEN N'Chưa Thanh Toán' END) as Status dp.RoomId
FROM DatPhong as dp
INNER JOIN Customer as c ON c.Id = dp.IdCustomer
INNER JOIN Room as r ON r.id = dp.RoomId
GO

EXEC GetAllDatPhong

SELECT * FROM DATPHONG
GO




-- thủ tục TRả Phong
CREATE PROC GetAllTraPhong
AS
SELECT dp.Id, c.FullName as FullName, r.Name as RoomName, dp.Price, dp.StartDate, dp.EndDate, (Case dp.Status WHEN 0 THEN N'Đã Thanh Toán' WHEN 1 THEN N'Chưa Thanh Toán' END) as Status
FROM DatPhong as dp
INNER JOIN Customer as c ON c.Id = dp.IdCustomer
INNER JOIN Room as r ON r.id = dp.RoomId
GO



-- thủ tục tìm phòng theo id
GO
CREATE PROC GetDatPhongById
@id int
AS
SELECT  dp.Id,c.Id as IdCustomer, c.FullName as FullName,r.Id as IdRoom, r.Name as RoomName, dp.Price, dp.StartDate, dp.EndDate,dp.Status FROM DatPhong as dp
INNER JOIN Customer as c ON c.Id = dp.IdCustomer
INNER JOIN Room as r ON r.id = dp.RoomId
WHERE dp.Id = @id

GO


EXEC GetDatPhongById @id = 1



CREATE PROC ThanhToan
@id int
AS
Update DatPhong SET status = 0 WHERE Id = @id
GO









DROP database QLHOTEL










drop table KhachSan
go
drop table DatKhachSan
go
drop table TourDetail
go
drop table DatTour
go
drop table TourDuLich
go
drop table DiemDuLich
go
drop table users_roles
go
drop table users
go
drop table role
go