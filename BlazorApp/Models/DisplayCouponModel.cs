using SupportLibrary.Models.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class DisplayCouponModel : IDiscountCouponModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter a Valid Coupon code")]
        [MinLength(5, ErrorMessage = "Please ensure the code is atleast 5 characters long")]
        [MaxLength(20, ErrorMessage = "We've limited the code to save a maximum of 20 characters")]
        public string CouponCode { get; set; }

        [Required]
        [Range(0,100,ErrorMessage ="Enter a valid Percentage")]
        public int PercentageDiscount { get; set; }
        public decimal UpperLimit { get; set; }

        [Required]
        public int RemainingUses { get; set; }
        public DateTime ExpiryDate { get; set; } = DateTime.Now;
        public decimal MinimumPurchase { get; set; } 
        [Required]
        public bool Valid
        {
            get
            {
                if (ExpiryDate < DateTime.Now)
                {
                    return false;
                }

                if (RemainingUses > 0)
                {
                    return true;
                }
                else if (RemainingUses == -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            set => Valid = value;
        }

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
