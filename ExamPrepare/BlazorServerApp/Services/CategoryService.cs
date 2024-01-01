using EFCoreTutorials.Models;

namespace BlazorServerApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient httpClient;

        public CategoryService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await httpClient.GetFromJsonAsync<Category[]>("api/Categories");
        }
    }
}
