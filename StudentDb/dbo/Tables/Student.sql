CREATE TABLE [dbo].[Student]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [AverageRating] FLOAT NOT NULL, 
    [Grade] INT NOT NULL
)
