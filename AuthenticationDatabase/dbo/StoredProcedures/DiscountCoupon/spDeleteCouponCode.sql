CREATE PROCEDURE [dbo].[spDeleteCouponCode]
	@Id int
AS
begin
	set nocount on;
	Delete from dbo.DiscountCodes 
	where Id = @Id;
end
