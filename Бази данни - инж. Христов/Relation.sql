CREATE DATABASE Relation
GO
USE Relation
GO
CREATE TABLE Addresses (
Id int PRIMARY KEY IDENTITY,
TownName nvarchar(16) NOT NULL,
StreetName nvarchar(32) NOT NULL,
[Description] nvarchar(128),
StreetNumber int NOT NULL
)
GO
CREATE TABLE Purposes (
Id int PRIMARY KEY IDENTITY,
Name nvarchar(16) NOT NULL,
Description nvarchar(128),
)
GO
CREATE TABLE Shops (
Id int PRIMARY KEY IDENTITY,
StartHour int NOT NULL,
EndHour int NOT NULL,
AddressId int NOT NULL 
CONSTRAINT FK_Shops_Addresses
REFERENCES Addresses(Id),
PurposeId int NOT NULL 
CONSTRAINT FK_Shops_Purposes
REFERENCES Purposes(Id)
)
GO
CREATE TABLE People (
EGN nvarchar(4) PRIMARY KEY,
Name nvarchar(32) NOT NULL,
Age int,
Email nvarchar(32) UNIQUE NOT NULL,
Proffession nvarchar(32) 
)






CREATE TABLE PeopleShops(
PersonId nvarchar(4) NOT NULL
CONSTRAINT FK_PeopleShops_People
REFERENCES People(EGN),
ShopId int NOT NULL
CONSTRAINT FK_PeopleShops_Shops
REFERENCES Shops(Id),
CONSTRAINT PK_PeopleShops PRIMARY KEY(PersonId,ShopId)
)GO
DROP DATABASE Relation