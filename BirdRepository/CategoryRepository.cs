using BirdDAO;
using BusinessObjects.Models;

namespace BirdRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        public void AddCategory(Category category)
        => CategoryDAO.Instance.AddCategory(category);

        public void DeleteCategory(int id)
        => CategoryDAO.Instance.DeleteCategory(id);

        public List<Category> GetCategories()
        => CategoryDAO.Instance.GetCategories();

        public Category GetCategoryById(int id)
        => CategoryDAO.Instance.GetCategoryById(id);

        public void UpdateCategory(Category category)
        => CategoryDAO.Instance.UpdateCategory(category);
    }
}
