CREATE PROCEDURE [dbo].[spSaveDiscountCode]
	@CouponCode				NVARCHAR(50),
	@PercentageDiscount int,
	@UpperLimit			NUMERIC(18, 2),
	@Valid				BIT,
	@RemainingUses		int,
	@ExpiryDate			datetime2(7),
	@MinimumPurchase	DECIMAL(18, 2) 
    AS
begin
	set nocount on;
	Insert into dbo.DiscountCodes
	(CouponCode,PercentageDiscount,UpperLimit,Valid,RemainingUses,ExpiryDate,MinimumPurchase)
	values (@CouponCode,@PercentageDiscount,@UpperLimit,@Valid,		
			@RemainingUses,@ExpiryDate,@MinimumPurchase)
end