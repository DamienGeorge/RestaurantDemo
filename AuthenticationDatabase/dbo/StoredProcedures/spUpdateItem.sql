CREATE PROCEDURE [dbo].[spUpdateItem]
	@Id int,
	@ItemType nvarchar(10),
	@ItemName nvarchar(50),
	@Cost decimal(18,2),
	@Quantity int
AS
begin
set nocount on;
	Update dbo.Items
	set ItemType = @ItemType,ItemName = @ItemName,Cost = @Cost,Quantity = @Quantity
	Where Id = @Id
end
