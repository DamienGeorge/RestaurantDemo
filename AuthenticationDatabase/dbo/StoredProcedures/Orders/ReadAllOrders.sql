CREATE PROCEDURE [dbo].[ReadAllOrders]
AS
begin 
set nocount on;
	SELECT  [Id], [CustomerName],
			[ItemTotal], [TaxTotal],
			[Discount], [TotalCost], [OrderDate],[OrderCompleted]
	from dbo.Orders 
end
