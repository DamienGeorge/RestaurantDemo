namespace SupportLibrary.Models.General
{
    public interface ICartModel
    {
        string ItemName { get; set; }
        decimal Cost { get; set; }
        int Quantity { get; set; }
        decimal Total { get; }
    }
}