CREATE PROCEDURE [dbo].[spReadItems]
AS
begin
set nocount on;
	SELECT [Id], [ItemType], [ItemName], [Cost], [Quantity]
	from dbo.Items
end

