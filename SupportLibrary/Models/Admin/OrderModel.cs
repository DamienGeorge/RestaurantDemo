using SupportLibrary.Models.General;
using System;
using System.Collections.Generic;
using System.Text;

namespace SupportLibrary.Models.Admin
{
    public class OrderModel : IOrderModel
    {
        public const decimal TaxRate = 0.15M;
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public decimal ItemTotal { get; set; }
        public decimal TaxTotal
        {
            get
            {
                if (ItemTotal > 0)
                {
                    return TaxRate * ItemTotal;
                }
                else
                {
                    return TaxRate;
                }
            }
        }
        public decimal DiscountPercentage { get; set; }
        public decimal TotalCost { get; set; }

        public DateTime OrderDate { get; set; }

        public List<ICartModel> CartData { get; set; }
        public bool OrderCompleted { get; set; }
    }
}
