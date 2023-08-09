namespace BlazorEcommerce.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponce<List<Category>>> GetCategories()
        {
            var categories = await _context.Categories.ToListAsync();
            return new ServiceResponce<List<Category>>
            {
                Data = categories
            };
        }
    }
}
