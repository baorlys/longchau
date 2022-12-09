use longchau

DECLARE @medicineHandler AS medicineHandler
INSERT INTO @medicineHandler VALUES('0024-5910',2)
INSERT INTO @medicineHandler VALUES('0069-4220',3)
exec createTransaction @medicineHandler,1,'2022-12-7',100000
GO

DECLARE @medicineHandler AS medicineHandler
INSERT INTO @medicineHandler VALUES('0078-0607',2)
INSERT INTO @medicineHandler VALUES('0169-4307',3)
exec createTransaction @medicineHandler,1,'2022-12-7',100000
GO

DECLARE @medicineHandler AS medicineHandler
INSERT INTO @medicineHandler VALUES('0173-0722',2)
INSERT INTO @medicineHandler VALUES('0456-2010',3)
exec createTransaction @medicineHandler,1,'2022-12-7',100000
GO

DECLARE @medicineHandler AS medicineHandler
INSERT INTO @medicineHandler VALUES('0904-0428',2)
INSERT INTO @medicineHandler VALUES('12496-0100',3)
exec createTransaction @medicineHandler,1,'2022-12-7',100000
GO


DECLARE @medicineHandler AS medicineHandler
INSERT INTO @medicineHandler VALUES('16714-174',2)
INSERT INTO @medicineHandler VALUES('43063-869',3)
exec createTransaction @medicineHandler,1,'2022-12-7',100000
GO

DECLARE @medicineHandler AS medicineHandler
INSERT INTO @medicineHandler VALUES('50090-3481',2)
INSERT INTO @medicineHandler VALUES('0009-0094',3)
exec createTransaction @medicineHandler,1,'2022-12-7',100000
GO

DECLARE @medicineHandler AS medicineHandler
INSERT INTO @medicineHandler VALUES('0006-0221',2)
INSERT INTO @medicineHandler VALUES('55513-137',3)
exec createTransaction @medicineHandler,1,'2022-12-7',100000
GO

DECLARE @medicineHandler AS medicineHandler
INSERT INTO @medicineHandler VALUES('0006-0221',2)
INSERT INTO @medicineHandler VALUES('63739-777',3)
exec createTransaction @medicineHandler,1,'2022-12-7',100000
GO
