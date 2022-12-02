USE longchau
go

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

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'checkMdcId')
	DROP PROCEDURE checkMdcId
GO

CREATE PROCEDURE checkMdcId(@mdcId char(10))
AS
SELECT * FROM medicine WHERE mdcId = @mdcId
GO

exec checkMdcId '0006-0221'
GO

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'checkMdcName')
	DROP PROCEDURE checkMdcName
GO

CREATE PROCEDURE checkMdcName(@name nvarchar(255))
AS
SELECT * FROM medicine WHERE name like CONCAT('%', @name, '%')
GO

exec checkMdcName 'opion'
GO

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'checkQuantityMdc')
	DROP PROCEDURE checkQuantityMdc
GO

CREATE PROCEDURE checkQuantityMdc(@mdcId char(10))
AS
SELECT quantity FROM medicine WHERE mdcId = @mdcId
GO

exec checkQuantityMdc '0006-0221'
GO

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'checkPriceMdc')
	DROP PROCEDURE checkPriceMdc
GO

CREATE PROCEDURE checkPriceMdc(@mdcId char(10))
AS
SELECT price FROM medicine WHERE mdcId = @mdcId
GO

exec checkPriceMdc '0006-0221'
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