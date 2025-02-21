using mormordagnysbageri_del1_api.ViewModels.OrderItem;

namespace mormordagnysbageri_del1_api.ViewModels.SalesOrder;

public class SalesOrderPostViewModel : SalesOrderViewModel
{
    public int CustomerId { get; set; }
    public IList<OrderItemPostViewModel> OrderItems { get; set; }
}
