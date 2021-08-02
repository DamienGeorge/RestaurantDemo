CREATE PROCEDURE [dbo].[spReadPendingOrders]
AS
begin
	set nocount on;
	SELECT  [Id], [CustomerName], [ItemTotal], 
			[TaxTotal], [Discount], [TotalCost],
			[OrderDate], [OrderCompleted]
	from dbo.Orders where OrderCompleted = 'False';
end

