CREATE PROCEDURE [dbo].[spReadItem]
	@Id int
AS
begin
set nocount on;

	Select [Id], [ItemType], [ItemName], [Cost], [Quantity]
	from dbo.Items 
	where Id = @Id

end