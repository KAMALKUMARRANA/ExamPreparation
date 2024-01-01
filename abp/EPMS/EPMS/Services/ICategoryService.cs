using EFCoreTutorials.Models;

namespace EPMS.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategories();
    }
}
