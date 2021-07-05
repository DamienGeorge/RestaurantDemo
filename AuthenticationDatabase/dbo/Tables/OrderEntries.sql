CREATE TABLE [dbo].[OrderEntries]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ItemName] NVARCHAR(50) NULL, 
    [Cost] DECIMAL(18, 2) NULL, 
    [Quantity] INT NULL, 
    [Total] DECIMAL(18, 2) NULL
)
