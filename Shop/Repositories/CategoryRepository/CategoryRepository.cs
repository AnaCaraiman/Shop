using Shop.Data;
using Shop.Models;
using Shop.Repositories.GenericRepository;

namespace Shop.Repositories.CategoryRepository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await GetAllAsync();
        }

        public async Task<Category> FindCategoryByNameAsync(string categoryName)
        {
            return await FindSingleOrDefaultAsync(c => c.Name == categoryName);
        }
    }
}

