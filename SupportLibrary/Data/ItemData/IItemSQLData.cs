using SupportLibrary.Models.Admin;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupportLibrary.Data.ItemData
{
    public interface IItemSQLData
    {
        Task AddItem(IItemEntryModel item);
        Task DeleteDiscountCoupon(int id);
        Task<List<IItemEntryModel>> ReadAllItems();
        Task<IDiscountCouponModel> ReadDiscountCoupon(int Id);
        Task<List<IDiscountCouponModel>> ReadDiscountCoupons();
        Task<IItemEntryModel> ReadItem(int id);
        Task<List<IOrderModel>> ReadOrders();
        Task<List<IOrderModel>> ReadPendingOrders();
        Task SaveDiscountCode(IDiscountCouponModel coupon);
        Task SaveOrder(IOrderModel order);
        Task<List<IItemEntryModel>> Search(string textToSearch);
        Task UpdateDiscountcode(IDiscountCouponModel coupon);
        Task UpdateItem(IItemEntryModel item);
        Task UpdateOrderModel(IOrderModel order);
    }
}