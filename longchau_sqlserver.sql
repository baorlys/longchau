/* SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO"; */
USE master
go
CREATE DATABASE longchau
go
USE longchau;
go
--USE master
--DROP DATABASE longchau

CREATE TABLE roles(
    [roleId] int NOT NULL PRIMARY KEY,
    [roleName] nvarchar(255)
)  ;

INSERT INTO roles VALUES 
(-1,'NOT SET'),
(0,'admin');

CREATE TABLE agency(
    [agencyId] int NOT NULL PRIMARY KEY,
    [agencyName] nvarchar(255) NOT NULL,
    [address] nvarchar(255) NOT NULL
)  ;

CREATE TABLE users (
    [userId] int NOT NULL identity(1,1) PRIMARY KEY,
    [email] varchar(255) DEFAULT NULL UNIQUE,
    [name] nvarchar(255) NOT NULL,
    [password] varchar(255) NOT NULL,
    [phone] char(11) DEFAULT NULL UNIQUE,
    [birthday] date DEFAULT NULL,
    [address] nvarchar(255) DEFAULT NULL,
    [dateExpire] date DEFAULT NULL, 
    [roleId] int DEFAULT -1,
    FOREIGN KEY ([roleId]) REFERENCES roles ([roleId])
)  ;
--SET IDENTITY_INSERT users ON;
INSERT INTO users VALUES ('admin@gmail.com','Admin','e10adc3949ba59abbe56e057f20f883e','0968278202','2002-07-04','VietNam','2222-12-31',0);

CREATE TABLE userManager(
    [umId] int NOT null IDENTITY(1,1) primary key,
    [email] varchar(255) DEFAULT NULL,
    [agencyId] int default -1,
    FOREIGN KEY ([agencyId]) REFERENCES agency ([agencyId]),
    FOREIGN KEY ([email]) REFERENCES users ([email])
)  ;

CREATE TABLE medicine(
    [mdcId] char(10) NOT NULL PRIMARY KEY,
    [name] nvarchar(255),
    [strength] nvarchar(255),
    [dosageForm] nvarchar(255),
    [price] int DEFAULT 0,
    [startDate] date NOT NULL,
    [dateExpire] date NOT NULL,
    [labelerName] nvarchar(255),
    [quantity] int DEFAULT 0
)  ;

CREATE TABLE import(
    [importId] int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [importDate] date DEFAULT GETDATE()  
)  ;

CREATE TABLE importDetail(
    [importId] int NOT NULL,
    [mdcId] char(10) NOT NULL,
    [quantity] int DEFAULT 0 NOT NULL,
    FOREIGN KEY ([importId]) REFERENCES import ([importId]),
    FOREIGN KEY ([mdcId]) REFERENCES medicine ([mdcId])

)  ;

CREATE TABLE transactions(
    [transId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [transType] nvarchar(255) NOT NULL,
    [transDate] date NOT NULL,
    [totalPrice] int DEFAULT 0,
    [state] int default 1 NOT NULL
)  ;

CREATE TABLE transactionDetail(
    [transId] INT NOT NULL,
    [mdcID] char(10) NOT NULL,
    [quantity] int default 0 NOT NULL,
    FOREIGN KEY ([mdcId]) REFERENCES medicine ([mdcId]),
    FOREIGN KEY ([transId]) REFERENCES transactions ([transId])
)  ;

CREATE TABLE disease(
    [diseaseId] int NOT NULL IDENTITY(1,1)  PRIMARY KEY,
    [diseaseName] nvarchar(255) NOT NULL,
    [diseaseInfo] nvarchar(255) NOT NULL
)  ;

CREATE TABLE certificate(
    [cerId] char(8) NOT NULL PRIMARY KEY,
    [diseaseId] int NOT NULL,
    [hospital] nvarchar(255) NOT NULL,
    FOREIGN KEY ([diseaseId]) REFERENCES disease ([diseaseId])
)  ;

CREATE TABLE certificateDetail(
    [cerId] char(8) NOT NULL,
    [mdcID] char(10) NOT NULL,
    [quantity] int DEFAULT 0,
    FOREIGN KEY ([cerId]) REFERENCES certificate ([cerId]),
    FOREIGN KEY ([mdcID]) REFERENCES medicine([mdcID])
)  ;




