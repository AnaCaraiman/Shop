using Shop.Models;

namespace Shop.Service.CategoryService
{
    public interface ICategoryService
    {
        Task<Category> GetByIdAsync(Guid id);
        Task CreateAsync(Category newCategory);
        Task<List<Category>> GetAllAsync();
        Task UpdateAsync(Category CategorytoUpdate);
        Task DeleteAsync(Category categroyToDelete);

    }
}
