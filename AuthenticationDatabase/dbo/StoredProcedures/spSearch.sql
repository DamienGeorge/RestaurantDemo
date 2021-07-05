CREATE PROCEDURE [dbo].[spSearch]
	@Search nvarchar(50)
AS
begin
	set nocount on;
	SELECT * from dbo.Items
	where ItemName Like '%'+@Search +'%' OR
		Cost Like '%'+@Search +'%' OR
		Quantity Like '%'+@Search +'%'

end
