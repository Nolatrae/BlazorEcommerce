namespace BlazorEcommerce.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<ServiceResponce<List<Category>>> GetCategories();
    }
}
