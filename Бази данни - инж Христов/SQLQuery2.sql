CREATE DATABASE UPR1

USE UPR1

CREATE TABLE Countries(
Designation NVARCHAR (2) PRIMARY KEY NOT NULL,
Name NVARCHAR(16) NOT NULL,
PopulationMilions INT NOT NULL,
ContinentName NVARCHAR(16) NOT NULL,
Languages NVARCHAR(64) NOT NULL,
Description NVARCHAR(1024)
)
GO
CREATE TABLE Towns(
Id INT PRIMARY KEY,
Name NVARCHAR(16) NOT NULL,
Population INT NOT NULL,
PostCode NVARCHAR(8) NOT NULL,
CountryId NVARCHAR(2) NOT NULL
CONSTRAINT FK_Towns_Countries
FOREIGN KEY REFERENCES Countries(Designation),



Region INT
CONSTRAINT FK_Towns_Towns
FOREIGN KEY REFERENCES Towns(Id)




)
GO
CREATE TABLE People(
Id INT PRIMARY KEY IDENTITY,
FirstName NVARCHAR(16) NOT NULL,
SurName NVARCHAR(16),
LastName NVARCHAR(16) NOT NULL,
Age int NOT NULL,
Gender bit NOT NULL,
Email NVARCHAR(32),
TownId INT NOT NULL
CONSTRAINT FK_People_Towns
FOREIGN KEY REFERENCES Towns(Id)
)

DROP TABLE Towns
DROP TABLE Countries
DROP TABLE People

INSERT INTO Countries (Name,PopulationMilions, Designation, ContinentName, Languages, Description) VALUES
('Bulgaria',6.5,'BG','Europe','Bulgarian', 'Visoki sini planini, Reki I zlatni ravnini.'),
('Uganda',45,'UG','Africa','English','For God and My Country'),
('USA',329,'US','South America','English, Spanish', 'E pluribus unum')



INSERT INTO Towns (Id,Name, Population, PostCode,CountryId,Region)  VALUES
(1,'Shumen', 89000, '9700', 'BG',1),
(22,'Plovdiv',343000,'4000', 'BG', 22),
(3,'Smiadovo',4044,'9820', 'BG', 3),
(4,'Richmond',229000,'V4K','US',4),
(5,'Kampala',1500000,'759125','UG', 5),
(6,'Kaolinovo',1000,'9701','BG',1)

INSERT INTO Towns (Id,Name, Population, PostCode,CountryId,Region)  VALUES
(77,'Varna', 350000, '1700', 'BG',77)
SELECT * FROM Countries 
SELECT * FROM Towns

INSERT INTO People (FirstName,SurName, LastName, Age, Email, TownId, Gender) VALUES
('Kosta','Ivanov','Mladenov',35,'kom@abv.bg',1,1),
('Malinka','Kalinova' ,'Ivanova',25,'malimali@yahoo.com',22,0),
('Kamelia','Amelieva' ,'Preslavova',21,'kamali@gmail.com',1,0),
('Marin','Tomislavov' , 'Goleminov',40,'marin_g@gmail.com',1,1),
('Sambo','Viktor','Dontworry',58,'sambomambo@ugabuga.com',5,1),
('John', 'Bob', 'Marley', 17,'johnybegood@yahoo.com.', 4,1),
('Jessica', 'Jehna', 'Jahmeson', 27,'jehna27@gmail.com', 4,0)

SELECT * FROM Countries
SELECT * FROM Towns
SELECT * FROM People