--DROP THE DATABASE IF IT EXISTS
USE master
DECLARE @dbname nvarchar(50)
SET @dbname = 'SomethingStupid'
IF (EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE ('[' + name + ']' = @dbname OR name = @dbname)))
BEGIN
    DROP DATABASE SomethingStupid
END
--CREATE A NEW DATABASE
CREATE DATABASE SomethingStupid;
USE SomethingStupid
--CREATE THE ONLY TABLE NEEDED
CREATE TABLE orgUser(
    UserId INT IDENTITY(1,1) NOT NULL
    ,Username VARCHAR(50) NOT NULL
    ,Password VARCHAR(50) NOT NULL
    ,LoginCounter INT DEFAULT 0
    ,CreatedDate DATETIME DEFAULT GETDATE()
);   
--SEEDED DATA FOR TESTING
INSERT INTO orgUser
(Username, Password, LoginCounter)
VALUES
('Username1','Password1',0),
('Username2','Password2',1),
('Username3','Password3',2),
('Username4','Password4',3)
