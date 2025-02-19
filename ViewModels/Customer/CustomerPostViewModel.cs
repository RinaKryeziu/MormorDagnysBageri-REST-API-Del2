using eshop.api.ViewModels.Address;

namespace mormordagnysbageri_del1_api.ViewModels.Customer;

public class CustomerPostViewModel : CustomerBaseViewModel
{
    public IList<AddressPostViewModel> Addresses { get; set; }
}
