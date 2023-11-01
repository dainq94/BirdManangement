using BusinessObjects.Models;

namespace BirdDAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        public CategoryDAO() { }
        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoryDAO();
                }
                return instance;
            }
        }
        public List<Category> GetCategories()
        {
            try
            {
                var dbContent = new BirdContext();
                return dbContent.Categories.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Category GetCategoryById(int id)
        {
            try
            {
                var dbContent = new BirdContext();
                return dbContent.Categories.SingleOrDefault(c => c.CategoryId.Equals(id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddCategory(Category category)
        {
            try
            {
                var dbContent = new BirdContext();
                Category c = GetCategoryById(category.CategoryId);
                if (c == null)
                {
                    dbContent.Categories.Add(category);
                    dbContent.SaveChanges();
                }
                else
                {
                    throw new Exception("CategoryID đã tồn tại!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateCategory(Category category)
        {
            try
            {
                var dbContent = new BirdContext();
                if (category != null)
                {
                    dbContent.Categories.Update(category);
                    dbContent.SaveChanges();
                }
                else
                {
                    throw new Exception("CategoryID không tồn tại!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteCategory(int id)
        {
            try
            {
                var dbContent = new BirdContext();
                Category category = GetCategoryById(id);
                if (category != null)
                {
                    dbContent.Categories.Remove(category);
                    dbContent.SaveChanges();
                }
                else
                {
                    throw new Exception("CategoryID không tồn tại!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
