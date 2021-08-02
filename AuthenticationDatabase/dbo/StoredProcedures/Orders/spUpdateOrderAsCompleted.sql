CREATE PROCEDURE [dbo].[spUpdateOrderAsCompleted]
@Id int

AS
begin 
set nocount on;
Update dbo.Orders set OrderCompleted = 'True'
Where Id = @Id;
end

