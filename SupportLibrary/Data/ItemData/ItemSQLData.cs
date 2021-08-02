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


        #region Item Methods
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


        public async Task<List<IItemEntryModel>> Search(string textToSearch)
        {
            var rows = await _dataAccess.LoadData<ItemEntryModel, dynamic>("dbo.spSearch", new { Search = textToSearch }, "DefaultConnection");

            return rows.ToList<IItemEntryModel>();
        }
        #endregion

        #region Order Methods
        public async Task<List<IOrderModel>> ReadOrders()
        {
            var rows = await _dataAccess.LoadData<OrderModel, dynamic>("dbo.ReadAllOrders", new { }, "DefaultConnection");

            return rows.ToList<IOrderModel>();
        }
        public async Task<List<IOrderModel>> ReadPendingOrders()
        {
            var rows = await _dataAccess.LoadData<OrderModel, dynamic>("dbo.spReadPendingOrders", new { }, "DefaultConnection");

            return rows.ToList<IOrderModel>();
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
                order.OrderDate,
                order.OrderCompleted
            };

            await _dataAccess.SaveData("dbo.spSaveOrder", p, "DefaultConnection");
        }

        private async Task SaveOrderEntries(IOrderModel order)
        {


            //await _dataAccess.LoadData<IItemSQLData,dynamic>("dbo.spSaveOrder", p, "DefaultConnection");
        }

        public async Task<List<IOrderModel>> GetOrderItemsByDate(IOrderModel order)
        {
            //To implement in db, currently loaded into memory and filtered using LINQ, not scalable
            var rows = await _dataAccess.LoadData<OrderModel, dynamic>("dbo.spGetOrder", order, "DefaultConnection");

            return rows.ToList<IOrderModel>();
        }

        public async Task<IOrderModel> GetOrderItem(IOrderModel order)
        {
            //Not sure what this was for
            var rows = await _dataAccess.LoadData<OrderModel, dynamic>("dbo.spGetOrderId", order, "DefaultConnection");

            return rows.ToList<IOrderModel>().FirstOrDefault();
        }

        public async Task UpdateOrderModel(IOrderModel order)
        {
            await _dataAccess.SaveData("dbo.spUpdateOrderAsCompleted", new { Id = order.Id }, "DefaultConnection");
        }

        #endregion

        #region Discount Coupon Methods

        public async Task SaveDiscountCode(IDiscountCouponModel coupon)
        {
            var p = new
            {
                CouponCode = coupon.CouponCode,
                PercentageDiscount = coupon.PercentageDiscount,
                UpperLimit = coupon.UpperLimit,
                Valid = coupon.Valid,
                RemainingUses = coupon.RemainingUses,
                ExpiryDate = coupon.ExpiryDate,
                MinimumPurchase = coupon.MinimumPurchase
            };

            await _dataAccess.SaveData("spSaveDiscountCode", p, "DefaultConnection");
        }

        public async Task UpdateDiscountcode(IDiscountCouponModel coupon)
        {

            await _dataAccess.SaveData("spUpdateDiscountCode", coupon, "DefaultConnection");
        }

        public async Task<List<IDiscountCouponModel>> ReadDiscountCoupons()
        {
            var rows = await _dataAccess.LoadData<DiscountCouponModel, dynamic>("spReadDiscountCoupons", new { }, "DefaultConnection");

            return rows.ToList<IDiscountCouponModel>();
        }
        public async Task<IDiscountCouponModel> ReadDiscountCoupon(int Id)
        {
            var rows = await _dataAccess.LoadData<DiscountCouponModel, dynamic>("spReadDiscountCouponById", new { Id }, "DefaultConnection");

            return rows.ToList<IDiscountCouponModel>().FirstOrDefault();
        }

        public async Task DeleteDiscountCoupon(int Id)
        {
            await _dataAccess.SaveData("spDeleteCouponCode", new { Id = Id }, "DefaultConnection");
        }
        #endregion

    }
}
