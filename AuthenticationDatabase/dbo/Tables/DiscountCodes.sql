CREATE TABLE [dbo].[DiscountCodes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CouponCode] NVARCHAR(50) NULL, 
    [PercentageDiscount] INT NULL, 
    [UpperLimit] NUMERIC(18, 2) NULL, 
    [Valid] BIT NULL, 
    [RemainingUses] INT NULL, 
    [ExpiryDate] DATETIME2 NULL, 
    [MinimumPurchase] DECIMAL(18, 2) NULL
)
