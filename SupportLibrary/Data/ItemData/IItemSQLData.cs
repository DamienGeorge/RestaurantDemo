using SupportLibrary.Models.Admin;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupportLibrary.Data.ItemData
{
    public interface IItemSQLData
    {
        Task AddItem(IItemEntryModel item);
        Task<List<IItemEntryModel>> ReadAllItems();
        Task<IItemEntryModel> ReadItem(int id);
        Task SaveOrder(IOrderModel order);
        Task<List<IItemEntryModel>> Search(string textToSearch);
        Task UpdateItem(IItemEntryModel item);
    }
}