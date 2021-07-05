CREATE TABLE [dbo].[Orders]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CustomerName] NVARCHAR(50) NULL, 
    [ItemTotal] DECIMAL(18, 2) NULL, 
    [TaxTotal] DECIMAL(18, 2) NULL, 
    [Discount] DECIMAL(18, 2) NULL, 
    [TotalCost] DECIMAL(18, 2) NULL, 
    [OrderDate] DATETIME2 NULL 

)
