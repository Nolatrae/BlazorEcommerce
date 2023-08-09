namespace BlazorEcommerce.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponce<List<Product>>> GetProductsAsync();
        Task<ServiceResponce<Product>> GetProductAsync(int id);
    }
}
