USE longchau
go

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'medicineHandler')
	--DROP PROCEDURE createImport
	DROP TYPE medicineHandler
GO

CREATE TYPE medicineHandler AS TABLE
(
	mdcId char(10) NOT NULL,
	quantity int DEFAULT 0
)

-- Check procedure
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'checkEmail')
	DROP PROCEDURE checkEmail
GO

CREATE PROCEDURE checkEmail(@email varchar(255))
AS
SELECT * FROM users WHERE email = @email
GO

exec checkEmail 'admin@gmail.com'
GO

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'checkPhone')
	DROP PROCEDURE checkPhone
GO

CREATE PROCEDURE checkPhone(@phone char(11))
AS
SELECT * FROM users WHERE phone = @phone
GO

exec checkPhone '0968278202'
GO

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getMdcByID')
	DROP PROCEDURE getMdcByID
GO

CREATE PROCEDURE getMdcByID(@mdcId char(10))
AS
SELECT * FROM medicine WHERE mdcId = @mdcId
GO

exec getMdcByID '0006-0221'
GO

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getMdcByName')
	DROP PROCEDURE getMdcByName
GO

CREATE PROCEDURE getMdcByName(@name nvarchar(255))
AS
SELECT * FROM medicine WHERE name like CONCAT('%', @name, '%')
GO

exec getMdcByName 'opion'
GO

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getMdcQuantity')
	DROP PROCEDURE getMdcQuantity
GO

CREATE PROCEDURE getMdcQuantity(@mdcId char(10))
AS
SELECT quantity FROM medicine WHERE mdcId = @mdcId
GO

exec getMdcQuantity '0006-0221'
GO

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getMdcPrice')
	DROP PROCEDURE getMdcPrice
GO

CREATE PROCEDURE getMdcPrice(@mdcId char(10))
AS
SELECT price FROM medicine WHERE mdcId = @mdcId
GO

exec getMdcPrice '0006-0221'
GO

-- Get company by cpnId
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getCompany')
	DROP PROCEDURE getCompany
GO

CREATE PROCEDURE getCompany(@cpnId char(10))
AS
SELECT * FROM company WHERE cpnId = @cpnId
GO

-- Get transaction by day
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getTrans')
	DROP PROCEDURE getTrans
GO

CREATE PROCEDURE getTrans(@day date,@state int)
AS
BEGIN
IF @day IS NULL
	BEGIN
	IF @state = -1
		SELECT * FROM transactions
	ELSE
		SELECT * FROM transactions WHERE state = @state
	END
ELSE
	BEGIN
	IF @state = -1
		SELECT * FROM transactions WHERE CAST(transDate AS DATE) = @day
	ELSE
		SELECT * FROM transactions WHERE CAST(transDate AS DATE) = @day AND state = @state
	END
END
GO

exec getTrans null,0
GO

-- Get transaction detail by transId
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getTransDetail')
	DROP PROCEDURE getTransDetail
GO

CREATE PROCEDURE getTransDetail(@transId char(10))
AS
SELECT transactionDetail.transId, transactionDetail.mdcID, medicine.name, transactionDetail.quantity FROM transactionDetail JOIN medicine ON  transactionDetail.mdcID = medicine.mdcID WHERE transId = @transId
GO

-- Doanh thu theo ngày có tham số
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getRevenueByDay')
	DROP PROCEDURE getRevenueByDay
GO

CREATE PROCEDURE getRevenueByDay(@day date)
AS
SELECT SUM(totalPrice) as revenue FROM transactions WHERE CAST(transDate AS DATE) = @day
GO

-- Doanh thu theo ngày hiện tại
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getRevenueByDayNow')
	DROP PROCEDURE getRevenueByDayNow
GO

CREATE PROCEDURE getRevenueByDayNow
AS
SELECT SUM(totalPrice) as revenue FROM transactions WHERE CAST(transDate AS DATE) = CAST(GETDATE() AS DATE)
GO

exec getRevenueByDayNow
GO

-- Doanh thu theo tháng và năm có tham số
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getRevenueByMonth')
	DROP PROCEDURE getRevenueByMonth
GO

CREATE PROCEDURE getRevenueByMonth(@month int, @year int)
AS
SELECT SUM(totalPrice) as revenue FROM transactions WHERE MONTH(transDate) = @month and YEAR(transDate) = @year
GO

-- Doanh thu theo tháng hiện tại
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getRevenueByMonthNow')
	DROP PROCEDURE getRevenueByMonthNow
GO

CREATE PROCEDURE getRevenueByMonthNow
AS
SELECT SUM(totalPrice) as revenue FROM transactions WHERE MONTH(transDate) = MONTH(GETDATE()) and YEAR(transDate) = YEAR(GETDATE())
GO

exec getRevenueByMonthNow
GO

-------------------------------------------------------------
-- Sign in
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'signIn')
	DROP PROCEDURE signIn
GO

CREATE PROCEDURE signIn(@email varchar(255), @password varchar(255))
AS
SELECT * FROM users WHERE email = @email and password = @password
GO

exec signIn 'admin@gmail.com', 'e10adc3949ba59abbe56e057f20f883e'
GO

--Sign up
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'signUp')
	DROP PROCEDURE signUp
GO

CREATE PROCEDURE signUp(@email varchar(255), @name nvarchar(255), @phone char(11), @password varchar(255))
AS
insert into users(email,name,phone,password) values(@email,@name,@phone,@password)
GO

--exec signUp 'ngxbinh47@gmail.com', N'Nguyễn Xuân Bình','0932758302','e10adc3949ba59abbe56e057f20f883e'
GO

--Create import
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'createImport')
	DROP PROCEDURE createImport
GO

CREATE PROCEDURE createImport(@medicineHandler medicineHandler READONLY,@cpn int,@importDate datetime,@totalPrice int)
AS
BEGIN
	INSERT INTO import(cpnId,importDate,totalPrice) VALUES(@cpn,@importDate,@totalPrice)
	DECLARE @importId int
	SET @importId = SCOPE_IDENTITY()
	INSERT INTO importDetail(importId,mdcId,quantity) SELECT @importId,mdcId,quantity FROM @medicineHandler
	UPDATE medicine SET medicine.quantity = medicine.quantity + tablemdc.quantity FROM @medicineHandler tablemdc JOIN medicine  ON medicine.mdcId = tablemdc.mdcId
	RETURN 1
END 
GO

DECLARE @medicineHandler AS medicineHandler
INSERT INTO @medicineHandler VALUES('0006-0221',2)
INSERT INTO @medicineHandler VALUES('0009-0094',3)
INSERT INTO @medicineHandler VALUES('0024-5910',4)
exec createImport @medicineHandler,1,'2022-12-7',100000
GO

--Create transaction
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'createTransaction')
	DROP PROCEDURE createTransaction
GO

CREATE PROCEDURE createTransaction(@medicineHandler medicineHandler READONLY,@userId int,@transDate datetime,@totalPrice int)
AS
BEGIN
	INSERT INTO transactions(userId,transDate,totalPrice) VALUES(@userId,@transDate,@totalPrice)
	DECLARE @transId int
	SET @transId = SCOPE_IDENTITY()
	INSERT INTO transactionDetail(transId,mdcId,quantity) SELECT @transId,mdcId,quantity FROM @medicineHandler
	UPDATE medicine SET medicine.quantity = medicine.quantity - tablemdc.quantity FROM @medicineHandler tablemdc JOIN medicine  ON medicine.mdcId = tablemdc.mdcId
	RETURN 1
END
GO

DECLARE @medicineHandler AS medicineHandler
INSERT INTO @medicineHandler VALUES('0006-0221',2)
INSERT INTO @medicineHandler VALUES('0009-0094',3)
INSERT INTO @medicineHandler VALUES('0024-5910',4)
exec createTransaction @medicineHandler,1,'2022-12-7',100000
GO


--Update quantity mdc
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'updateMdcQuantity')
	DROP PROCEDURE updateMdcQuantity
GO

CREATE PROCEDURE updateMdcQuantity(@mdcId char(10),@quantity int)
AS
UPDATE medicine set quantity = quantity + @quantity WHERE mdcId = @mdcId
GO

exec updateMdcQuantity '0006-0221',2
GO

