namespace SupportLibrary.Models.Admin
{
 /// <summary>
 /// Class describes an item model that is added in the restaurant
 /// </summary>
 public interface IItemEntryModel
    {
        int Id { get; set; }
        string ItemType { get; set; }
        string ItemName { get; set; }
        decimal Cost { get; set; }
        int Quantity { get; set; }
    }
}