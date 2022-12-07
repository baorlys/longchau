/* SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO"; */
USE master
go
CREATE DATABASE longchau
go
USE longchau;
go


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

CREATE TABLE expressBrand(
    [brandId] int NOT NULL IDENTITY(0,1)  PRIMARY KEY,
    [brandName] nvarchar(255) NOT NULL,
    [nationName] nvarchar(255) DEFAULT NULL
)  ;
INSERT INTO expressBrand VALUES('','');

CREATE TABLE company(
    [cpnId] int NOT NULL IDENTITY(0,1)  PRIMARY KEY,
    [cpnName] nvarchar(255) NOT NULL,
    [nationName] nvarchar(255) DEFAULT NULL
)  ;
INSERT INTO company VALUES
('',''),
('Ferzen' , 'America'),
('Kelado' , 'Canada'),
('Aclivia' , 'India'),
('Avirax' , 'Thailand'),
('SupplyPharma' , 'VietName'),
('HeadForge' , 'Singapore'),
('Vodaxa' , 'Rusia'),
('Vilexo' , 'China'),
('ReliefWand' , 'Japan'),
('Bexira', 'Korea');


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
	[cpnId] int DEFAULT 0,
    [importDate] datetime DEFAULT GETDATE(),
    [totalPrice] int DEFAULT 0  
)  ;

CREATE TABLE importDetail(
    [importId] int NOT NULL,
    [mdcId] char(10) NOT NULL,
    [quantity] int DEFAULT 0 NOT NULL,
    FOREIGN KEY ([importId]) REFERENCES import ([importId]),
    FOREIGN KEY ([mdcId]) REFERENCES medicine ([mdcId])

)  ;

CREATE TABLE transactions(
    [transId] INT NOT NULL IDENTITY(0,1) PRIMARY KEY,
	[userId] INT NOT NULL,
    [transType] nvarchar(255) DEFAULT NULL,
    [transDate] datetime NOT NULL,
    [totalPrice] int DEFAULT 0,
	[brandId] int DEFAULT 0,
	[expressState] int DEFAULT 0,  
    [state] int default 1 NOT NULL,
    FOREIGN KEY ([brandId]) REFERENCES expressBrand ([brandId]),
    FOREIGN KEY ([userId]) REFERENCES users ([userId])
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
GO

INSERT INTO MEDICINE VALUES('12496-0100','BUPRENORPHINE','100 mg/1','SOLUTION','20000','20180226','20231231','Indivior Inc.','12')
INSERT INTO MEDICINE VALUES('0009-0094','ALPRAZOLAM','2 mg/1','TABLET','34000','19811016','20231231','Pharmacia & Upjohn Company LLC','3')
INSERT INTO MEDICINE VALUES('55513-137','APREMILAST','30 mg/1','TABLET, FILM COATED','97000','20200226','20231231','Amgen Inc','12')
INSERT INTO MEDICINE VALUES('63187-037','PREDNISONE','10 mg/1','TABLET','161000','20020712','20221231','Proficient Rx LP','18')
INSERT INTO MEDICINE VALUES('43063-869','CIPROFLOXACIN HYDROCHLORIDE','500 mg/1','TABLET','12000','20040910','20231231','PD-Rx Pharmaceuticals, Inc.','12')
INSERT INTO MEDICINE VALUES('16714-174','ATORVASTATIN CALCIUM PROPYLENE GLYCOL SOLVATE','20 mg/1','TABLET, FILM COATED','199000','20210801','20221231','NORTHSTAR RX LLC','18')
INSERT INTO MEDICINE VALUES('0456-2010','ESCITALOPRAM OXALATE','10 mg/1','TABLET, FILM COATED','181000','20020814','20231231','Allergan, Inc.','3')
INSERT INTO MEDICINE VALUES('0173-0722','BUPROPION HYDROCHLORIDE','200 mg/1','TABLET, FILM COATED','134000','20020625','20231231','GlaxoSmithKline LLC','6')
INSERT INTO MEDICINE VALUES('53002-3112','NAPROXEN','500 mg/1','TABLET','37000','20160705','20221231','RPK Pharmaceuticals, Inc.','4')
INSERT INTO MEDICINE VALUES('50090-4364','CANAGLIFLOZIN','300 mg/1','TABLET, FILM COATED','114000','20130329','20221231','A-S Medication Solutions','20')
INSERT INTO MEDICINE VALUES('64764-300','VEDOLIZUMAB','300 mg/5mL','INJECTION, POWDER, LYOPHILIZED, FOR SOLUTION','116000','20140520','20231231','Takeda Pharmaceuticals America, Inc.','19')
INSERT INTO MEDICINE VALUES('71205-569','TRAMADOL HYDROCHLORIDE','300 mg/1','TABLET, EXTENDED RELEASE','112000','20140819','20231231','Proficient Rx LP','13')
INSERT INTO MEDICINE VALUES('0169-4307','SEMAGLUTIDE','7 mg/1','TABLET','45000','20190920','20231231','Novo Nordisk','5')
INSERT INTO MEDICINE VALUES('0006-0221','SITAGLIPTIN PHOSPHATE','25 mg/1','TABLET, FILM COATED','82000','20061016','20231231','Merck Sharp & Dohme LLC','9')
INSERT INTO MEDICINE VALUES('50090-3481','DAPAGLIFLOZIN PROPANEDIOL','10 mg/1','TABLET, FILM COATED','22000','20080114','20221231','A-S Medication Solutions','10')
INSERT INTO MEDICINE VALUES('0069-4220','SILDENAFIL CITRATE','100 mg/1','TABLET, FILM COATED','118000','19980327','20231231','Pfizer Laboratories Div Pfizer Inc','2')
INSERT INTO MEDICINE VALUES('0904-0428','DOXYCYCLINE HYCLATE','100 mg/1','CAPSULE','119000','20080805','20231231','Major Pharmaceuticals','15')
INSERT INTO MEDICINE VALUES('0024-5910','SARILUMAB','200 mg/1.14mL','INJECTION, SOLUTION','58000','20170522','20221231','sanofi-aventis U.S. LLC','12')
INSERT INTO MEDICINE VALUES('63739-777','HYDROXYCHLOROQUINE SULFATE','200 mg/1','TABLET, FILM COATED','60000','20080103','20221231','McKesson Corporation dba SKY Packaging','5')
INSERT INTO MEDICINE VALUES('54123-114','BUPRENORPHINE HYDROCHLORIDE','11.4 mg/1','TABLET, ORALLY DISINTEGRATING','155000','20141211','20231231','Orexo US, Inc.','16')
INSERT INTO MEDICINE VALUES('0078-0607','FINGOLIMOD HYDROCHLORIDE','.5 mg/1','CAPSULE','44000','20100921','20231231','Novartis Pharmaceuticals Corporation','15')
INSERT INTO MEDICINE VALUES('68071-5083','BENZONATATE','100 mg/1','CAPSULE','64000','20181221','20231231','NuCare Pharmaceuticals,Inc.','0')
INSERT INTO MEDICINE VALUES('73317-4258','METFORMIN HYDROCHLORIDE','1000 mg/1','TABLET, FILM COATED, EXTENDED RELEASE','140000','20210416','20221231','SLV PHARMACEUTICALS LLC DBA AUM PHARMACEUTICALS','3')
GO




