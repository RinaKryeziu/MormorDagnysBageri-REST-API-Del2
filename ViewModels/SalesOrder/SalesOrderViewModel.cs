using mormordagnysbageri_del1_api.ViewModels.OrderItem;

namespace mormordagnysbageri_del1_api.ViewModels.SalesOrder;

public class SalesOrderViewModel : SalesOrderBaseViewModel
{

    public IList<OrderItemViewModel> Items { get; set; }

}
