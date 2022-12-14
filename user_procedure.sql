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

--Get transaction by user's id procedure
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'getTransactionByUserID')
    DROP PROCEDURE getTransactionByUserID
GO

CREATE PROCEDURE getTransactionByUserID(@userId varchar(255),@state int)
AS
BEGIN
IF @state = 2
    SELECT transactions.transId,transactions.userId,users.name,transactions.transDate,transactions.totalPrice,transactions.brandId,expressBrand.brandName,transactions.expressState,transactions.state  FROM transactions,expressBrand,users WHERE transactions.userId = @userId AND transactions.brandId = expressBrand.brandId AND transactions.userId = users.userId
ELSE
    SELECT transactions.transId,transactions.userId,users.name,transactions.transDate,transactions.totalPrice,transactions.brandId,expressBrand.brandName,transactions.expressState,transactions.state  FROM transactions,expressBrand,users WHERE transactions.userId = @userId AND state = @state AND transactions.brandId = expressBrand.brandId AND transactions.userId = users.userId
END
GO

exec getTransactionByUserID 1,2
GO


