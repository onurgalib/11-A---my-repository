CREATE DATABASE SchoolDB

USE SchoolDB

CREATE TABLE Students(
Id INT PRIMARY KEY,
FirstName NVARCHAR(16),
SurName NVARCHAR(16),
LastName NVARCHAR(16),
GSM NVARCHAR(16),
Email NVARCHAR(32),
Address NVARCHAR(64),
Age int NOT NULL,
Gender int NOT NULL
)
GO
CREATE TABLE Teachers(
Id INT PRIMARY KEY IDENTITY,
FirstName NVARCHAR(16),
LastName NVARCHAR(16),
Gender bit NOT NULL,
Email NVARCHAR(32),
Subjects NVARCHAR(64),
ManagedClassID INT NOT NULL
CONSTRAINT FK_Teachers_Students
FOREIGN KEY REFERENCES Students(Id)
)
GO
CREATE TABLE Speciality(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(16),
Description NVARCHAR (1024),
GraduatesTitle NVARCHAR(32),
StartGrade int NOT NULL,
EndGrade int NOT NULL
CONSTRAINT FK_Speciality_Teachers
FOREIGN KEY REFERENCES Teachers(Id)
)
GO
CREATE TABLE Classes(
Id INT PRIMARY KEY IDENTITY,
Grade int NOT NULL,
GradeLetter int NOT NULL,
SpecialityID INT
CONSTRAINT FK_Classes_Speciality
FOREIGN KEY REFERENCES Speciality(Id)
)




DROP TABLE Students
DROP TABLE Teachers
DROP TABLE Speciality
DROP TABLE Classes



INSERT INTO Students (Id,FirstName,SurName,LastName,GSM,Email,Address,Age,Gender) VALUES
(1, 'Dzhaner','Ilhan','Ali',0899467356,'dzhaner@gmail.com','Hristo Botev', 17, 1), 
(2, 'Ivan','Ivanov','Ivanov',0899203419,'ivan@abv.bg','Aleko Konstantinov', 18, 1), 
(3, 'Yordan','Qsenov','Milev',0896224055,'yordan@yahoo.com','Edelvays', 16, 1), 
(4, 'Maria','Georgieva','Ivanowa',0887170104,'maria.ivanowa@pgmett.com','Ivan Vazov', 15, 0), 
(5, 'Ilyayda','Selim','Ahmed',0895323124,'ilyayda@gmail.com','Nikola Vaptsarov', 14,0), 
(6, 'Soner','Efraimov','Rufiev',0885201705,'soner@abv.bg','Pirin', 18, 1), 
(7, 'Nuridin','Nuri','Nuridin',0888222666,'nuridin@yahoo.com','Kaliakra', 17, 1), 
(8, 'Alen','Ayhanov','Ibishev',0899224488,'alen.ibishev@pgmett.com','Tsar Oswoboditel', 16, 1), 
(9, 'Emilia','Vasilewa','Anatoliewa',0886906010,'emilia@gmail.com','Simeon Veliki', 15, 0), 
(10, 'Melissa','Medzhnunova','Aliewa',0899157545,'melissa@hotmail.com','Kiril Metodi', 14, 0)


INSERT INTO Teachers (Id,FirstName,LastName,Gender,Email,Subjects,ManagedClassID) VALUES
(1,'Nikolay','Hristov',1,'nikicha@yahoo.com', 'OOP,BD,MOP,KOP',11),
(2,'Stefan','Kirov',1,'stefcho@gmail.com', 'Vgradeni s-mi', 11),
(3, 'Tatyana','Sarmova',0,'sarmova.tatyana@pgmett.com', 'English', 11)

INSERT INTO Classes (Id, Grade,GradeLetter,SpecialityId) VALUES	
(1, 11, 'A', 'PROGRAMMER')
(2, 11, 'B', 'ELECTRICIAN')

INSERT INTO Speciality(Id, Name, Description,GraduatesTitle,StartGrade,EndGrade) VALUES
(1, 'PROGRAMMER' ,'V tazi specialnost se 
obuchava zadulbocheno kompyutirni tehnologii
ot poslednoto pokolenie i kak da se programira
na razlichni programni programi i ezici!', 'Prilojen programist', 8,12)
(2, 'ELECTRICIAN', 'V tazi specialnost se uchi za 
obrabotka na elektricheski verigi, elektrichestvo,
centrali na vodna osnova, na uran i telekomunikacionna elektro centrala',
'Elektrotehnik', 9,12)
(3, 'Avtomatizaciq na neprekasnati proizvodcva', 'V tazi specialnost se obuchava
razchitane i izchislyavane i realizirane elektronni shemi',
'Avtomatici', 8,12)

SELECT * FROM Students
SELECT * FROM Teachers
SELECT * FROM Classes
SELECT * FROM Speciality 

