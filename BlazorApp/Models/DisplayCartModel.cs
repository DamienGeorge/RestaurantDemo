using SupportLibrary.Models.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class DisplayCartModel : ICartModel
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
