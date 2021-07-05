CREATE TABLE [dbo].[Items]
(
	[Id] INT NOT NULL PRIMARY KEY IDentity, 
    [ItemType] NVARCHAR(10) NULL, 
    [ItemName] NVARCHAR(50) NULL, 
    [Cost] DECIMAL(18, 2) NULL, 
    [Quantity] INT NULL,
)
