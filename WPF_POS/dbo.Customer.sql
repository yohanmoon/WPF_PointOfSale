CREATE TABLE [dbo].Customer
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Last Name] NVARCHAR(50) NOT NULL, 
    [First Name] NVARCHAR(50) NOT NULL, 
    [Middle Initial] NCHAR(10) NULL, 
    [Gender] NCHAR(10) NULL, 
    [Order] INT NULL
)
