
namespace Ecom.Client.Services.CategoriesService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        public CategoryService(HttpClient http)
        {
            _http = http;
        }

        public List<Category> Categories { get; set; } = new List<Category>();

        public async Task GetCategories()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/category");

            if (response?.Data != null)
            {
                Categories = response.Data;
            }
        }

        public int GetCategoryIdByUrl(string categoryUrl)
        {
            var category = Categories.FirstOrDefault(c => c.Url.ToLower() == categoryUrl.ToLower());
            return category?.Id ?? 0;
        }
    }
}
