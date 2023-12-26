namespace Ecom.Client.Services.CategoriesService
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }

        Task GetCategories();
    }
}
