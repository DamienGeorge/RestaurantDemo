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
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter your Name")]
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public decimal ItemTotal { get; set; }
        public decimal TaxTotal
        {
            get
            {
                return ItemTotal * TaxRate;
            }
        }
        public decimal DiscountPercentage { get; set; } = 0;
        public decimal TotalCost
        {
            get
            {
                return (ItemTotal + (ItemTotal * TaxRate) - (ItemTotal * DiscountPercentage / 100));
            }
        }
        public List<ICartModel> CartData { get; set; }
        public bool OrderCompleted { get; set; } = false;
    }
}
