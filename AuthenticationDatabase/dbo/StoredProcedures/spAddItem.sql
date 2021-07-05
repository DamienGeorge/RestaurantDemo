CREATE PROCEDURE [dbo].[spAddItem]
	@ItemType varchar(10),
	@ItemName varchar(50),
	@Cost decimal(18,2),
	@Quantity int
AS

begin
set nocount on;

	Insert into dbo.Items 
	(ItemType,ItemName,Cost,Quantity) 
	values(@ItemType,@ItemName,@Cost,@Quantity)

end

