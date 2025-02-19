using mormordagnysbageri_del1_api.ViewModels.OrderItem;
using mormordagnysbageri_del1_api.ViewModels.Product;

namespace mormordagnysbageri_del1_api.ViewModels.SalesOrder;

public class SalesOrderViewModel
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public IList<OrderItemViewModel> Items { get; set; }

}
