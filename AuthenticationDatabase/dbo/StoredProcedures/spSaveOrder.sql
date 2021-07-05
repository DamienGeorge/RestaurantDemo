CREATE PROCEDURE [dbo].[spSaveOrder]
	@CustomerName nvarchar(50),
	@ItemTotal decimal(18,2),
	@TaxTotal decimal(18,2),
	@DiscountPercentage decimal(18,2),
	@TotalCost decimal(18,2),
	@OrderDate datetime2(7)
AS
begin
	set nocount on;

	Insert into dbo.Orders
	(CustomerName,ItemTotal,TaxTotal,Discount,TotalCost,OrderDate)
	values (@CustomerName,@ItemTotal,@TaxTotal,@DiscountPercentage,@TotalCost,@OrderDate)
end
