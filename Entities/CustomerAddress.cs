namespace mormordagnysbageri_del1_api.Entities;

public class CustomerAddress
{
    public int CustomerId { get; set; }
    public int AddressId { get; set; }

    public Customer Customer { get; set; }
    public Address Address { get; set; }
}
