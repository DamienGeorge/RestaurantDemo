using System;
using System.Collections.Generic;
using System.Text;

namespace SupportLibrary.Models.General
{
    public class CartModel : ICartModel
    {
        public string ItemName { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public decimal Total
        {
            get
            {
                return (decimal)Quantity * Cost;
            }
        }
    }
}
