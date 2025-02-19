using mormordagnysbageri_del1_api.ViewModels;
using mormordagnysbageri_del1_api.ViewModels.Customer;

namespace mormordagnysbageri_del1_api;

public interface ICustomerRepository
{
    public Task<bool> Add(CustomerPostViewModel model);
    public Task<CustomerViewModel> Find(int id);
    public Task<IList<CustomersViewModel>> List();
}
