using SupportLibrary.Models.Admin;
using SupportLibrary.Models.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class DisplayOrderModel : IOrderModel
    {
        public const decimal TaxRate = 0.15M;
        public int OrderId { get; set; }

        [Required]
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public decimal ItemTotal { get; set; }
        public decimal TaxTotal { get; }
        public decimal DiscountPercentage { get; set; } = 0;
        public decimal TotalCost
        {
            get
            {
                return (ItemTotal + ItemTotal * TaxRate - ItemTotal * DiscountPercentage);
            }
        }
        public List<ICartModel> CartData { get; set; }
    }
}
