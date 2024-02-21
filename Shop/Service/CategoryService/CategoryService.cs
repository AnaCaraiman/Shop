using Shop.Models;
using Shop.Repositories.CategoryRepository;
using Shop.Repositories.ProductDetailRepository;

namespace Shop.Service.CategoryService
{
    public class CategoryService : ICategoryService
    {

        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task CreateAsync(Category newCategory)
        {
            await _categoryRepository.CreateAsync(newCategory);
            await _categoryRepository.SaveAsync();
        }

        public async Task DeleteAsync(Category categoryToDelete)
        {
            _categoryRepository.Delete(categoryToDelete);
            await _categoryRepository.SaveAsync();
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return (await _categoryRepository.GetAllAsync()).ToList();
        }

        public async Task<Category> GetByIdAsync(Guid id)
        {
            return await _categoryRepository.FindByIdAsync(id);
        }

        public async Task UpdateAsync(Category categoryToUpdate)
        {
            _categoryRepository.Update(categoryToUpdate);
            await _categoryRepository.SaveAsync();
        }




    }

      

       



}
