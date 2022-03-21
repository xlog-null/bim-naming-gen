CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [filename] VARCHAR(255) NOT NULL, 
    [created_date] DATETIME NOT NULL DEFAULT GETDATE()
)
