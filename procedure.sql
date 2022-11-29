USE longchau
go

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

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'signIn')
	DROP PROCEDURE logIn
GO

CREATE PROCEDURE signIn(@email varchar(255), @password varchar(255))
AS
SELECT * FROM users WHERE email = @email and password = @password
GO

exec signIn 'admin@gmail.com', 'e10adc3949ba59abbe56e057f20f883e'
GO

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'signUp')
	DROP PROCEDURE logIn
GO

CREATE PROCEDURE signUp(@email varchar(255), @name nvarchar(255), @phone char(11), @password varchar(255))
AS
insert into users(email,name,phone,password) values(@email,@name,@phone,@password)
GO

exec signUp 'ngxbinh47@gmail.com', N'Nguyễn Xuân Bình','0932758302','e10adc3949ba59abbe56e057f20f883e'
GO