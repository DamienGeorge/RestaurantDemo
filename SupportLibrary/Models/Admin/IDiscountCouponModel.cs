using System;

namespace SupportLibrary.Models.Admin
{
    public interface IDiscountCouponModel
    {
        int Id { get; set; }
        string CouponCode { get; set; }
        int PercentageDiscount { get; set; }
        decimal UpperLimit { get; set; }
        int RemainingUses { get; set; }
        DateTime ExpiryDate { get; set; }
        decimal MinimumPurchase { get; set; }
        bool Valid { get; set; }

        void CouponValidRecalc();
    }
}