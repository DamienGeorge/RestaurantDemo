using System;
using System.Collections.Generic;
using System.Text;

namespace SupportLibrary.Models.Admin
{
    public class ItemEntryModel : IItemEntryModel
    {
        public int Id { get; set; }
        public string ItemType { get; set; }
        public string ItemName { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
    }
}
