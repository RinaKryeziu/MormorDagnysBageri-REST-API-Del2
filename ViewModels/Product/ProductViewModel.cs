namespace mormordagnysbageri_del1_api.ViewModels.Product;

public class ProductViewModel : ProductsViewModel
{
    public int Id { get; set; }
    public double Weight { get; set; }
    public DateTime ExpireDate { get; set; }
    public DateTime ManufactureDate { get; set; }
}
