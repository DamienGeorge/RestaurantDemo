using SupportLibrary.DataAccess;
using SupportLibrary.Models.Admin;
using SupportLibrary.Models.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary.Data.ItemData
{
    /// <summary>
    /// Class is used to fetch data from database for restaurant
    /// </summary>
    public class ItemSQLData : IItemSQLData
    {
        private readonly ISQLDataAccess _dataAccess;

        public ItemSQLData(ISQLDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task AddItem(IItemEntryModel item)
        {
            var i = new
            {

                item.ItemType,
                item.ItemName,
                item.Cost,
                item.Quantity
            };

            await _dataAccess.SaveData("dbo.spAddItem", i, "DefaultConnection");
        }

        public async Task<List<IItemEntryModel>> ReadAllItems()
        {
            var rows = await _dataAccess.LoadData<ItemEntryModel, dynamic>("dbo.spReadItems", new { }, "DefaultConnection");

            return rows.ToList<IItemEntryModel>();
        }

        public async Task UpdateItem(IItemEntryModel item)
        {
            await _dataAccess.SaveData("dbo.spUpdateItem", item, "DefaultConnection");
        }

        public async Task<IItemEntryModel> ReadItem(int id)
        {
            var rows = await _dataAccess.LoadData<ItemEntryModel, dynamic>("dbo.spReadItem", new { id }, "DefaultConnection");

            return rows.ToList<IItemEntryModel>().FirstOrDefault();
        }

        public async Task SaveOrder(IOrderModel order)
        {
            var p = new
            {
                order.CustomerName,
                order.ItemTotal,
                order.TaxTotal,
                order.DiscountPercentage,
                order.TotalCost,
                order.OrderDate
            };

            await _dataAccess.SaveData("dbo.spSaveOrder", p, "DefaultConnection");
        }

        private async Task SaveOrderEntries(IOrderModel order)
        {


            //await _dataAccess.LoadData<IItemSQLData,dynamic>("dbo.spSaveOrder", p, "DefaultConnection");
        }

        public async Task<List<IOrderModel>> GetOrderItemsByDate(IOrderModel order)
        {
            var rows = await _dataAccess.LoadData<OrderModel, dynamic>("dbo.spGetOrder", order, "DefaultConnection");

            return rows.ToList<IOrderModel>();
        }

        public async Task<IOrderModel> GetOrderItem(IOrderModel order)
        {
            var rows = await _dataAccess.LoadData<OrderModel, dynamic>("dbo.spGetOrderId", order, "DefaultConnection");

            return rows.ToList<IOrderModel>().FirstOrDefault();
        }

        public async Task<List<IItemEntryModel>> Search(string textToSearch)
        {
            var rows = await _dataAccess.LoadData<ItemEntryModel, dynamic>("dbo.spSearch", new { Search = textToSearch }, "DefaultConnection");

            return rows.ToList<IItemEntryModel>();
        }

    }
}
