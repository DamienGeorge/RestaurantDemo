using SupportLibrary.Models.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{

    public enum EntryType
    {
        Drink,
        Food
    };

    public class DisplayItemEntry : IItemEntryModel
    {

        public int Id { get; set; }

        [Required]
        [EnumDataType(typeof(EntryType), ErrorMessage ="Please choose a Type")]
        public string ItemType { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public decimal Cost { get; set; }
       
        [Required]
        public int Quantity { get; set; }
    }
}
