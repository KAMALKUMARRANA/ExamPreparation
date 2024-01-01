using EFCoreTutorials.Models;

namespace BlazorServerApp.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategories();
    }
}
