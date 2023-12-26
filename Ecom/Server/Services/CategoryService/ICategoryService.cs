namespace Ecom.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<Category>>> GetCategoriesAsync();

        Task<int?> GetCategoryByUrlId(string categoryUrl);
    }
}
