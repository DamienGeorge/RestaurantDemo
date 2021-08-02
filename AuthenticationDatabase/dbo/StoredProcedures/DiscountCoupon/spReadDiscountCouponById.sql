CREATE PROCEDURE [dbo].[spReadDiscountCouponById]
	@Id int
AS
begin
	set nocount on;

	SELECT [Id], [CouponCode], [PercentageDiscount],
	[UpperLimit], [Valid], [RemainingUses],
	[ExpiryDate], [MinimumPurchase] from dbo.DiscountCodes
	where Id = @Id
end
