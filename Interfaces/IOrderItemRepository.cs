using mormordagnysbageri_del1_api.Entities;
using mormordagnysbageri_del1_api.ViewModels.OrderItem;

namespace mormordagnysbageri_del1_api.Interfaces;

public interface IOrderItemRepository
{
    public Task<OrderItem> Add(OrderItemPostViewModel model);
}
