
using Ecom.Server.Data;

namespace Ecom.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _dataContext;
        public CategoryService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<ServiceResponse<List<Category>>> GetCategoriesAsync()
        {
            var categories = await _dataContext.Categories.ToListAsync();
            return new ServiceResponse<List<Category>>
            {
                Data = categories,
            };
        }

        public Task<ServiceResponse<Category>> GetCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
