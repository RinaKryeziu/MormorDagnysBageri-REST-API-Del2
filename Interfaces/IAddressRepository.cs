using eshop.api.ViewModels.Address;
using mormordagnysbageri_del1_api.Entities;

namespace mormordagnysbageri_del1_api.Interfaces;

public interface IAddressRepository
{
    public Task<Address> Add(AddressPostViewModel model);
    public Task<bool> Add (string type);
}
