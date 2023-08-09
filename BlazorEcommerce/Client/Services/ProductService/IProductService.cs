namespace BlazorEcommerce.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged;
        List<Product> Products { get; set; }
        Task GetProducts(string? categoryUrl = null);
        Task<ServiceResponce<Product>> GetProduct(int productId);
    }
}
