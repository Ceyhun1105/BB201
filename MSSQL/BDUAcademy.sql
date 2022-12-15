CREATE DATABASE BDUAcademy

-- execute only first line and modify to comment it then excute all lines 

USE BDUAcademy

CREATE TABLE TEACHERS
(
	Id INT IDENTITY PRIMARY KEY ,
	Namee NVARCHAR(20) NOT NULL,
	Surname NVARCHAR(25) NOT NULL,
	Age INT NOT NULL,
	Experience FLOAT 
)

CREATE TABLE STUDENTS
(
	Id INT IDENTITY PRIMARY KEY ,
	Namee NVARCHAR(20) NOT NULL,
	Surname NVARCHAR(25) NOT NULL,
	Age INT NOT NULL
)

ALTER TABLE STUDENTS
DROP COLUMN Age 

ALTER TABLE STUDENTS
ADD Age INT NOT NULL

ALTER TABLE TEACHERS
ALTER COLUMN Surname NVARCHAR(30)

INSERT INTO TEACHERS VALUES
('Asim','Aliyev',26,2),
('Azer','Hemidov',34,NULL),
('Ikram','Quliyev',45,16),
('Samir','Hasanli',23,1)

INSERT INTO STUDENTS VALUES
('Fehmi','Huseynli',19),
('Ruslan','Qurbanov',18),
('Vusal','Imanov',20),
('Vusal','Agayev',17)

UPDATE TEACHERS
SET Experience = 7.5 WHERE Id=2

UPDATE STUDENTS
SET Namee='Rasim' WHERE Id=4

DELETE FROM TEACHERS WHERE Age>40 OR Experience>15

SELECT * FROM STUDENTS
SELECT * FROM TEACHERS


