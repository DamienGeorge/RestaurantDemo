using System;
using System.Collections.Generic;
using System.Text;

namespace SupportLibrary.Models.Admin
{
    public class DiscountCouponModel : IDiscountCouponModel
    {
        public int Id { get; set; }
        public string CouponCode { get; set; }
        public int PercentageDiscount { get; set; }
        public decimal UpperLimit { get; set; }
        public int RemainingUses { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal MinimumPurchase { get; set; }
        public bool Valid { get; set; }

        public void CouponValidRecalc()
        {
            if (ExpiryDate < DateTime.Now)
            {
                Valid = false;
                return;
            }

            if (RemainingUses > 0)
            {
                Valid = true;
            }
            else if (RemainingUses == -1)
            {
                Valid = true;
            }
            else
            {
                Valid = false;
            }
        }
    }
}
