CREATE PROCEDURE [dbo].[spReadDiscountCoupons]
AS
begin
set nocount on;
	SELECT [Id], [CouponCode], [PercentageDiscount],
			[UpperLimit], [Valid], [RemainingUses], 
			[ExpiryDate], [MinimumPurchase] 
	from dbo.DiscountCodes
end
