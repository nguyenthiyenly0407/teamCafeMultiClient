CREATE DATABASE TeamCafe17
GO

USE TeamCafe17
GO

CREATE TABLE TableFood
(
	idTable int IDENTITY PRIMARY KEY,
	nameTable nvarchar(40),
	status int NOT NULL DEFAULT 0 -- 0 là trống, 1 là có ng
)
GO

CREATE TABLE Staff
(
	idStaff char(4) PRIMARY KEY,
	fullName nvarchar(40),
	phoneNumber varchar(10),
	firstDoW smalldatetime,
	position nvarchar(20)
)
GO
	
CREATE TABLE Account
(
	userName varchar(30) PRIMARY KEY,
	passWord varchar(256) NOT NULL DEFAULT 0,
	idStaff char(4)

	FOREIGN KEY (idStaff) REFERENCES dbo.Staff(idStaff)
)
GO

CREATE TABLE FoodCategory
(
	idCategory int IDENTITY PRIMARY KEY,
	name nvarchar(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO	

CREATE TABLE Food
(
	idFood int IDENTITY PRIMARY KEY,
	name nvarchar(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory int NOT NULL,
	price FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(idCategory)
)
GO

CREATE TABLE Bill
(
	idBill int IDENTITY PRIMARY KEY,
	idStaff char(4),
	DateCheckIn smalldatetime NOT NULL DEFAULT GETDATE(),
	DateCheckOut smalldatetime,
	idTable int NOT NULL,
	total money NOT NULL DEFAULT 0,
	status int NOT NULL DEFAULT 0, -- 1: đã thanh toán && 0: chưa thanh toán
	discount int

	FOREIGN KEY (idStaff) REFERENCES dbo.Staff(idStaff),
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(idTable)
)
GO

CREATE TABLE BillInfo
(
	idBill int NOT NULL,
	idFood int NOT NULL,
	count int NOT NULL DEFAULT 0
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(idBill),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(idFood)
)
GO

SET DATEFORMAT DMY
-- Thêm dữ liệu vào bảng Staff
INSERT INTO Staff (idStaff, fullName, phoneNumber, firstDoW, position)
VALUES ('M001', N'Lâm Hải Đăng', '0836130371', '01/06/2023', N'Quản Lý')
INSERT INTO Staff (idStaff, fullName, phoneNumber, firstDoW, position)
VALUES ('S001', N'Nguyễn Hoàng Lộc', '0935244475', '04/06/2023', N'Nhân Viên')
INSERT INTO Staff (idStaff, fullName, phoneNumber, firstDoW, position)
VALUES ('S002', N'Nguyễn Thị Yến Ly', '0999999999', '04/06/2023', N'Nhân Viên')

-- Thêm dữ liệu vào bảng Account, với idStaff tương ứng là 'S001'
INSERT INTO Account (userName, passWord, idStaff)
VALUES ('haidang', '8c7242b324bb095737de738fe3bb6676b68f938166d98f25643710507070402a', 'M001')
INSERT INTO Account (userName, passWord, idStaff)
VALUES ('hoangloc', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 'S001')
INSERT INTO Account (userName, passWord, idStaff)
VALUES ('yenly', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'S002')

-- Thêm category
INSERT dbo.FoodCategory ( name ) VALUES ( N'Cà phê' ) --1
INSERT dbo.FoodCategory ( name ) VALUES ( N'Sinh tố' ) --2
INSERT dbo.FoodCategory ( name ) VALUES ( N'Trà' ) --3
INSERT dbo.FoodCategory ( name ) VALUES ( N'TeamCafe' ) --4
INSERT dbo.FoodCategory ( name ) VALUES ( N'Đá xay' ) --5
INSERT dbo.FoodCategory ( name ) VALUES ( N'Ăn vặt' ) --6
INSERT dbo.FoodCategory ( name ) VALUES ( N'Nước ép' ) --7
INSERT dbo.FoodCategory ( name ) VALUES ( N'Mojito' ) --8

-- Thêm đồ uống
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Cà phê đen', 1, 20000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Cà phê sữa', 1, 25000 )	
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Chocolate', 1, 35000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Cappuccino', 1, 40000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Latte', 1, 40000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Americano', 1, 35000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Mocha', 1, 45000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Espresso', 1, 35000 ) 
	
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Dâu', 2, 35000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Bơ', 2, 35000 )	
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Mãng cầu', 2, 35000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Xoài', 2, 35000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Chanh dây, Bạc hà', 2, 35000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Sữa dừa', 2, 35000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Yogurt trái cây', 2, 35000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Yogurt việt quất', 2, 35000 ) 

INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Trà vải', 3, 35000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Trà dâu', 3, 35000 )	
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Trà táo', 3, 35000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Trà đào', 3, 35000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Trà chanh', 3, 35000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Trà tắc xí muội', 3, 35000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Trà thảo mộc', 3, 35000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Trà thơm kim quất', 3, 35000 ) 	
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Hồng trà việt quất', 3, 35000 ) 	

INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Trà sữa gốm', 4, 30000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Trà chanh', 4, 30000 )	
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Trà sữa chocolate', 4, 35000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Trà sữa matcha', 4, 35000 ) 

INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Chocolate đá xay', 5, 45000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Oreo việt quất đá xay', 5, 45000 ) 

INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Snacks', 6, 15000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Hạt hướng dương, Bánh tai heo', 6, 15000 ) 

INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Dưa hấu', 7, 35000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Thơm', 7, 35000 )	
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Ổi', 7, 35000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Táo', 7, 35000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Cam', 7, 35000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Dâu', 7, 35000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Cà rốt', 7, 35000 ) 	
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Mix 2 loại bất kì', 7, 38000 ) 	

INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Dâu', 8, 40000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Chanh dây', 8, 40000 )	
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Táo', 8, 40000 ) 
INSERT dbo.Food ( name, idCategory, price ) VALUES ( N'Đào', 8, 40000 ) 

--Insert default table
DECLARE @i INT = 1

WHILE @i <= 10
BEGIN
	INSERT TableFood ( nameTable ) VALUES ( N'Bàn ' + CAST(@i AS nvarchar(40)))
	SET @i = @i + 1
END


--table list
--GO
--CREATE PROC USP_GetTableList
--AS SELECT * FROM dbo.TableFood
--GO

--store proc cho insert bill
GO
CREATE PROC USP_InsertBill
@idTable int, @idStaff char(4)
AS
BEGIN
	INSERT dbo.Bill (idStaff, DateCheckIn, DateCheckOut, idTable, status, discount ) VALUES (@idStaff, GETDATE(), NULL, @idTable, 0, 0)
	UPDATE dbo.TableFood SET status =  1 WHERE idTable = @idTable
END
GO


--store proc cho insert bill info
GO
CREATE PROC USP_InsertBillInfo
@idBill int, @idFood int, @count int
AS
BEGIN
	--DECLARE @existedBillInfo int;
	DECLARE @foodCount int = 1;
	IF NOT EXISTS (SELECT idBill FROM dbo.BillInfo WHERE idBill = @idBill)
	BEGIN
		INSERT dbo.BillInfo ( idBill, idFood, count ) VALUES ( @idBill, @idFood, @count )
	END
	ELSE
	BEGIN
		SELECT @foodCount = count FROM dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
		IF NOT EXISTS (SELECT idFood FROM dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood)
		BEGIN
			INSERT dbo.BillInfo ( idBill, idFood, count ) VALUES ( @idBill, @idFood, @count )
		END
		ELSE
		BEGIN
			DECLARE @newCount int = @foodCount + @count
			IF (@newCount > 0)
				UPDATE dbo.BillInfo SET count = @newCount WHERE idBill = @idBill AND idFood = @idFood
			ELSE
				DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
		END
	END
END

-- Proc CheckOut
GO
CREATE PROC USP_CheckOut
@idBill int, @discount int, @total money
AS
BEGIN
	DECLARE @idTable int;
	SELECT @idTable = idTable FROM dbo.Bill WHERE idBill = @idBill
	UPDATE dbo.Bill SET DateCheckOut = GETDATE(), status = 1, discount = @discount, total = @total WHERE idBill = @idBill
	UPDATE dbo.TableFood SET status =  0 WHERE idTable = @idTable
END
GO

----update acc proc
GO
CREATE PROC USP_UpdateAccount
@idStaff char(4) , @fullName nvarchar(40) , @phoneNumber varchar(10) , @userName varchar(30) , @passWord varchar(256) , @newPassWord varchar(256)
AS
BEGIN	
	IF (@newPassWord = NULL OR @newPassWord = '')
	BEGIN
		UPDATE dbo.Staff SET fullName = @fullName, phoneNumber = @phoneNumber WHERE idStaff = @idStaff
	END
	ELSE
	BEGIN
		UPDATE dbo.Staff SET fullName = @fullName, phoneNumber = @phoneNumber WHERE idStaff = @idStaff
		UPDATE dbo.Account SET passWord = @newPassWord WHERE idStaff = @idStaff AND userName = @userName
	END
END
GO

--thong ke proc
GO
CREATE PROC USP_GetListBillByDates
@checkIn date, @checkOut date
AS
BEGIN
	SELECT b.idBill AS [Mã bill], b.idStaff AS [Mã nhân viên] ,t.nameTable AS [Tên bàn], b.total AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], discount AS [Giảm giá (%)]
	FROM dbo.Bill AS b, dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.idTable = b.idTable
END
GO

-- Tao tai khoan connect sql cho client chi co quyen select 
CREATE LOGIN client WITH PASSWORD = 'teamcafe';
USE TeamCafe;
CREATE USER client FOR LOGIN client;
GRANT SELECT ON TableFood TO client;
GRANT SELECT ON Staff TO client;
GRANT SELECT ON Account TO client;
GRANT SELECT ON FoodCategory TO client;
GRANT SELECT ON Food TO client;
GRANT SELECT ON Bill TO client;
GRANT SELECT ON BillInfo TO client;