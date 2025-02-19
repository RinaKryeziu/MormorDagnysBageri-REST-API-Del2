using mormordagnysbageri_del1_api.ViewModels.Address;
using mormordagnysbageri_del1_api.ViewModels.Customer;
using mormordagnysbageri_del1_api.ViewModels.OrderItem;
using mormordagnysbageri_del1_api.ViewModels.SalesOrder;

namespace mormordagnysbageri_del1_api.ViewModels;

public class CustomerViewModel : CustomerBaseViewModel
{
    public IList<AddressViewModel> Addresses { get; set; }
    public IList<SalesOrderViewModel> SalesOrders { get; set; }

}
