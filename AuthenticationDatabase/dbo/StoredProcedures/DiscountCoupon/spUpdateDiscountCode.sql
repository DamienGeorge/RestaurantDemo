CREATE PROCEDURE [dbo].[spUpdateDiscountCode]
	@Id int = 0,	
	@CouponCode		NVARCHAR(50),
	@PercentageDiscount int,
	@UpperLimit			NUMERIC(18, 2),
	@Valid				BIT,
	@RemainingUses		int,
	@ExpiryDate			datetime2(7),
	@MinimumPurchase	DECIMAL(18, 2) 
AS
begin
set nocount on;
	Update dbo.DiscountCodes
	Set 
		CouponCode = @CouponCode,
		PercentageDiscount	= @PercentageDiscount,
		UpperLimit			= @UpperLimit,
		Valid				= @Valid,
		RemainingUses		= @RemainingUses,
		ExpiryDate			= @ExpiryDate,
		MinimumPurchase		= @MinimumPurchase
	Where Id = @Id
							  
end
