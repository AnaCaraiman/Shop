using Shop.Models;
using Shop.Repositories.GenericRepository;

namespace Shop.Repositories.CategoryRepository
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<Category> FindCategoryByNameAsync(string categoryName);
    }
}
