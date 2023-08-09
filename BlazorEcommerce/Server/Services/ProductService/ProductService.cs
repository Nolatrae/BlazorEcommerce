namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponce<Product>> GetProductAsync(int productId)
        {
            var responce = new ServiceResponce<Product>();
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                responce.Success = false;
                responce.Message = "Sorry, but this product does not exist";
            }
            else
            {
                responce.Data = product;
            }
            return responce;
        }

        public async Task<ServiceResponce<List<Product>>> GetProductsAsync()
        {
            var responce = new ServiceResponce<List<Product>>
            {
                Data = await _context.Products.ToListAsync()
            };
            return responce;
        }

        public async Task<ServiceResponce<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            var responce = new ServiceResponce<List<Product>>
            {
                Data = await _context.Products
                    .Where(x => x.Category.Url.ToLower().Equals(categoryUrl.ToLower()))
                    .ToListAsync()
            };
            return responce;
        }
    }
}
