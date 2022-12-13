USE longchau 
GO

--Change password procedure
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'changePassword')
    DROP PROCEDURE changePassword
GO

CREATE PROCEDURE changePassword(@email varchar(255), @password varchar(255))
AS
UPDATE users SET password = @password WHERE email = @email
GO

--Update userInfo procedure
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'updateUserInfo')
    DROP PROCEDURE updateUserInfo
GO

CREATE PROCEDURE updateUserInfo(@email varchar(255), @name nvarchar(255), @phone char(11), @birthday date, @address nvarchar(255))
AS
UPDATE users SET name = @name, phone = @phone, birthday = @birthday, address = @address WHERE email = @email
GO

--Get transaction by user's id procedure
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getTransactionByUserID')
    DROP PROCEDURE getTransactionByUserID
GO

CREATE PROCEDURE getTransactionByUserID(@userId varchar(255),@state int)
AS
BEGIN
IF @state = 2
    SELECT * FROM transactions,expressBrand WHERE userId = @userId AND transactions.brandId = expressBrand.brandId
ELSE
    SELECT * FROM transactions,expressBrand WHERE userId = @userId AND state = @state AND transactions.brandId = expressBrand.brandId
END
GO

exec getTransactionByUserID 1,2
GO


