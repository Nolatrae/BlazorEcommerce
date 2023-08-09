using BlazorEcommerce.Shared;


namespace BlazorEcommerce.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public List<Product> Products { get; set; } = new List<Product>();

        public async Task<ServiceResponce<Product>> GetProduct(int productId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponce<Product>>($"api/product/{productId}");
            return result;
        }

        public async Task GetProducts()
        {
            var result = 
                await _http.GetFromJsonAsync<ServiceResponce<List<Product>>>("api/product");
            if (result != null && result.Data != null)
                Products = result.Data;
        }
    }
}
