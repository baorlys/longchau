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
SELECT medicine.mdcId, medicine.name,medicine.type,medicine.categoryId,category.categoryName,medicine.dateExpire,medicine.labelerName,medicine.description,medicine.price,medicine.quantity,medicine.img FROM medicine,category WHERE medicine.mdcId = @mdcId AND medicine.categoryId = category.categoryId
GO

exec getMdcByID 'MDC00001'

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getMdcByName')
	DROP PROCEDURE getMdcByName
GO

CREATE PROCEDURE getMdcByName(@name nvarchar(255))
AS
SELECT medicine.mdcId, medicine.name,medicine.type,medicine.categoryId,category.categoryName,medicine.dateExpire,medicine.labelerName,medicine.description,medicine.price,medicine.quantity,medicine.img FROM medicine,category WHERE medicine.categoryId = category.categoryId AND name like CONCAT('%', @name, '%')
GO

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getMdcQuantity')
	DROP PROCEDURE getMdcQuantity
GO

CREATE PROCEDURE getMdcQuantity(@mdcId char(10))
AS
SELECT quantity FROM medicine WHERE mdcId = @mdcId
GO

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getMdcPrice')
	DROP PROCEDURE getMdcPrice
GO

CREATE PROCEDURE getMdcPrice(@mdcId char(10))
AS
SELECT price FROM medicine WHERE mdcId = @mdcId
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
		SELECT transactions.transId,transactions.userId,users.name,transactions.transDate,transactions.totalPrice,transactions.brandId,expressBrand.brandName,transactions.expressState,transactions.state  FROM transactions,expressBrand,users WHERE transactions.brandId = expressBrand.brandId AND transactions.userId = users.userId
	ELSE
		SELECT transactions.transId,transactions.userId,users.name,transactions.transDate,transactions.totalPrice,transactions.brandId,expressBrand.brandName,transactions.expressState,transactions.state  FROM transactions,expressBrand,users WHERE transactions.state = @state AND transactions.brandId = expressBrand.brandId AND transactions.userId = users.userId
	END
ELSE
	BEGIN
	IF @state = 2
		SELECT transactions.transId,transactions.userId,users.name,transactions.transDate,transactions.totalPrice,transactions.brandId,expressBrand.brandName,transactions.expressState,transactions.state  FROM transactions,expressBrand,users  WHERE CAST(transDate AS DATE) = CAST(@day AS DATE) AND transactions.brandId = expressBrand.brandId AND transactions.userId = users.userId
	ELSE
		SELECT transactions.transId,transactions.userId,users.name,transactions.transDate,transactions.totalPrice,transactions.brandId,expressBrand.brandName,transactions.expressState,transactions.state  FROM transactions,expressBrand,users  WHERE CAST(transDate AS DATE) = CAST(@day AS DATE) AND transactions.state = @state AND transactions.brandId = expressBrand.brandId AND transactions.userId = users.userId
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
SELECT transactionDetail.transId, transactionDetail.mdcID, medicine.name, transactionDetail.quantity, transactionDetail.totalPrice FROM transactionDetail JOIN medicine ON  transactionDetail.mdcID = medicine.mdcID WHERE transactionDetail.transId = @transId
GO

exec getTransDetail 2
GO

--Doanh thu tu ngay den ngay
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getRevenue')
	DROP PROCEDURE getRevenue
GO

CREATE PROCEDURE getRevenue(@from date,@to date)
AS
SELECT * FROM transactions WHERE CAST(transDate AS DATE) BETWEEN @from AND @to
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


--Sign up
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'signUp')
	DROP PROCEDURE signUp
GO

CREATE PROCEDURE signUp(@email varchar(255), @name nvarchar(255), @phone char(11), @password varchar(255))
AS
insert into users(email,name,phone,password) values(@email,@name,@phone,@password)
GO

--Create request import
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'createRequestImport')
	DROP PROCEDURE createRequestImport
GO

CREATE PROCEDURE createRequestImport(@mdcID char(10),@quantity int)
AS
BEGIN
	DECLARE @importId int
	INSERT INTO import(mdcID,quantity) VALUES(@mdcID,@quantity)
	SET @importId = SCOPE_IDENTITY()
	INSERT INTO storage(importId,quantity) VALUES(@importId,@quantity)
	RETURN 1
END
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
	UPDATE import SET import.dateExpire = (SELECT dateExpire FROM storage WHERE storage.importId = @importId) WHERE import.importId = @importId
	RETURN 1
END
GO

--Update request import
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'updateRequestImport')
	DROP PROCEDURE updateRequestImport
GO

CREATE PROCEDURE updateRequestImport(@importId int)
AS
BEGIN
	UPDATE import SET status = 2 WHERE importId = @importId
	UPDATE Storage SET status = 2 WHERE importId = @importId
	UPDATE medicine SET quantity = import.quantity, dateExpire = CAST(import.dateExpire AS DATE) FROM import WHERE import.mdcId = medicine.mdcId AND import.importID=@importId
	RETURN 1
END
GO

--Get request import
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getRequestImport')
	DROP PROCEDURE getRequestImport
GO

CREATE PROCEDURE getRequestImport(@status int)
AS
BEGIN
	IF @status = 3
		SELECT import.importID,import.requestDate,import.mdcID,medicine.name,import.quantity,import.dateExpire,import.status FROM import,medicine WHERE import.mdcId = medicine.mdcId
	ELSE
		SELECT import.importID,import.requestDate,import.mdcID,medicine.name,import.quantity,import.dateExpire,import.status FROM import,medicine WHERE import.status = @status AND import.mdcId = medicine.mdcId
END

--Get storage by status
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getStorage')
	DROP PROCEDURE getStorage
GO

CREATE PROCEDURE getStorage(@status int)
AS
BEGIN
	IF @status = 3
		SELECT * FROM storage
	ELSE
		SELECT * FROM storage WHERE status = @status
END


--Create transaction
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'createTransaction')
	DROP PROCEDURE createTransaction
GO

CREATE PROCEDURE createTransaction(@medicineHandler medicineHandler READONLY,@userId int,@transDate datetime,@totalPrice int,@brandId int)
AS
BEGIN
	INSERT INTO transactions(userId,transDate,totalPrice,brandId) VALUES(@userId,@transDate,@totalPrice,@brandId)
	DECLARE @transId int
	SET @transId = SCOPE_IDENTITY()
	INSERT INTO transactionDetail(transId,mdcId,quantity) SELECT @transId,mdcId,quantity FROM @medicineHandler
	UPDATE medicine SET medicine.quantity = medicine.quantity - tablemdc.quantity FROM @medicineHandler tablemdc JOIN medicine  ON medicine.mdcId = tablemdc.mdcId
	RETURN 1
END
GO

DECLARE @medicineHandler AS medicineHandler
INSERT INTO @medicineHandler VALUES('MDC00001',2)
INSERT INTO @medicineHandler VALUES('MDC00002',3)
exec createTransaction @medicineHandler,1,'2022-12-7',100000,1
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

--Delete transaction
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'deleteTrans')
	DROP PROCEDURE deleteTrans
GO

CREATE PROCEDURE deleteTrans(@transId int)
AS
BEGIN
	UPDATE medicine SET medicine.quantity = medicine.quantity + transactionDetail.quantity FROM transactionDetail WHERE
	transactionDetail.transId = @transId
	DELETE FROM transactionDetail WHERE transId = @transId
	DELETE FROM transactions WHERE transId = @transId
	RETURN 1
END
go

--Get all MDC
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getAllMedicine')
	DROP PROCEDURE getAllMedicine
GO

CREATE PROCEDURE getAllMedicine
AS 
	SELECT medicine.mdcId, medicine.name,medicine.type,medicine.categoryId,category.categoryName,medicine.dateExpire,medicine.labelerName,medicine.description,medicine.price,medicine.quantity,medicine.img FROM medicine,category WHERE medicine.categoryId = category.categoryId
GO

exec getAllMedicine
GO
