﻿USE longchau
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

CREATE PROCEDURE getMdcByID(@mdcId varchar(10))
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

CREATE PROCEDURE getMdcQuantity(@mdcId varchar(10))
AS
SELECT quantity FROM medicine WHERE mdcId = @mdcId
GO

exec getMdcQuantity '0006-0221'
GO

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getMdcPrice')
	DROP PROCEDURE getMdcPrice
GO

CREATE PROCEDURE getMdcPrice(@mdcId varchar(10))
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

CREATE PROCEDURE getTrans(@day varchar(30),@state int)
AS
BEGIN
IF @day IS NULL
	BEGIN
	IF @state = 2
		SELECT * FROM transactions
	ELSE
		SELECT * FROM transactions WHERE state = @state
	END
ELSE
	BEGIN
	IF @state = 2
		SELECT * FROM transactions WHERE CAST(transDate AS DATE) = CAST(@day AS DATE)
	ELSE
		SELECT * FROM transactions WHERE CAST(transDate AS DATE) = CAST(@day AS DATE) AND state = @state
	END
END
GO

exec getTrans null,0
GO

-- Get transaction detail by transId
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getTransDetail')
	DROP PROCEDURE getTransDetail
GO

CREATE PROCEDURE getTransDetail(@transId int)
AS
SELECT transactionDetail.transId, transactionDetail.mdcID, medicine.name, transactionDetail.quantity FROM transactionDetail JOIN medicine ON  transactionDetail.mdcID = medicine.mdcID WHERE transId = @transId
GO

exec getTransDetail 0
GO

--Doanh thu tu ngay den ngay
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getRevenue')
	DROP PROCEDURE getRevenue
GO

CREATE PROCEDURE getRevenue(@from date,@to date)
AS
SELECT SUM(totalPrice) FROM transactions WHERE CAST(transDate AS DATE) BETWEEN @from AND @to
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

--Create request import
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'createRequestImport')
	DROP PROCEDURE createRequestImport
GO

CREATE PROCEDURE createRequestImport(@mdcID varchar(10))
AS
BEGIN
	DECLARE @importId int
	INSERT INTO import(mdcID) VALUES(@mdcID)
	SET @importId = SCOPE_IDENTITY()
	INSERT INTO storage(importId) VALUES(@importId)
	RETURN 1
END
GO

exec createRequestImport '0006-0221'
GO

--Approve request import from storage
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'approveRequestImport')
	DROP PROCEDURE approveRequestImport
GO

CREATE PROCEDURE approveRequestImport(@importId int)
AS
BEGIN
	UPDATE storage SET status = 1 WHERE importId = @importId
	UPDATE import SET status = 1 WHERE importId = @importId
	INSERT INTO importDetail(importId,quantity,dateExpire) SELECT importId,quantity,dateExpire FROM storage WHERE importId = @importId
	RETURN 1
END
GO

exec approveRequestImport 1
GO

--Update request import
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'updateRequestImport')
	DROP PROCEDURE updateRequestImport
GO

CREATE PROCEDURE updateRequestImport(@importId int)
AS
BEGIN
	UPDATE import SET status = 2 WHERE importId = @importId
	UPDATE medicine SET quantity = importDetail.quantity, dateExpire = CAST(importDetail.dateExpire AS DATE) FROM importDetail,import WHERE import.mdcId = medicine.mdcId AND import.importID=@importId
	RETURN 1
END
GO

exec updateRequestImport 1

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

CREATE PROCEDURE updateMdcQuantity(@mdcId varchar(10),@quantity int)
AS
UPDATE medicine set quantity = quantity + @quantity WHERE mdcId = @mdcId
GO

exec updateMdcQuantity '0006-0221',2
GO

--Delete transaction
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'deleteTrans')
	DROP PROCEDURE deleteTrans
GO

CREATE PROCEDURE deleteTrans(@transId int)
AS
BEGIN
	UPDATE medicine SET quantity = quantity + transactionDetail.quantity FROM transactionDetail WHERE
	transactionDetail.transId = @transId
	DELETE FROM transactionDetail WHERE transId = @transId
	DELETE FROM transactions WHERE transId = @transId
	RETURN 1
END
