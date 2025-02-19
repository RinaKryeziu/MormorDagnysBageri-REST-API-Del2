namespace mormordagnysbageri_del1_api.Interfaces;

public interface IUnitOfWork
{
    ICustomerRepository CustomerRepository { get; }
    IAddressRepository AddressRepository { get; }
    IProductRepository ProductRepository { get; }

    Task<bool> Complete();
    bool HasChanges();
}
