using SupportLibrary.Models.General;
using System;
using System.Collections.Generic;

namespace SupportLibrary.Models.Admin
{
    public interface IOrderModel
    {
        int OrderId { get; set; }
        string CustomerName { get; set; }
        DateTime OrderDate { get; set; }
        decimal ItemTotal { get; set; }
        decimal TaxTotal { get; }
        decimal DiscountPercentage { get; set; }
        decimal TotalCost { get;}
        List<ICartModel> CartData { get; set; }
    }
}