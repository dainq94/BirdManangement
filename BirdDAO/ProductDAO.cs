using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace BirdDAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;
        public ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductDAO();
                }
                return instance;
            }
        }

        public List<Product> GetAllProducts()
        {
            try
            {
                var dbContent = new BirdContext();
                return dbContent.Products.Include(c => c.Category)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Product GetProductById(int id)
        {
            try
            {
                var dbContent = new BirdContext();
                return dbContent.Products.SingleOrDefault(p => p.ProductId.Equals(id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                var dbContent = new BirdContext();
                if (product != null)
                {
                    dbContent.Products.Update(product);
                    dbContent.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Update Error!!!" + ex.Message);
            }
        }
        public void AddProduct(Product product)
        {
            try
            {
                var dbContent = new BirdContext();
                //Product p = GetProductById(product.ProductId);
                //if (p != null)
                //{
                //    dbContent.Products.Add(product);
                //    dbContent.SaveChanges();
                //}
                //dbContent.Products.Add(product);
                //dbContent.SaveChanges();
                //else
                //{
                //    throw new Exception("ProductID has existed!!");
                //}
                dbContent.Products.Add(product);
                dbContent.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Add Error!!!" + ex.Message);
            }
        }

        public void DeleteProduct(int id)
        {
            try
            {
                var dbContent = new BirdContext();
                Product product = GetProductById(id);
                if (product != null)
                {
                    dbContent.Products.Remove(product);
                    dbContent.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Delete Error!!!" + ex.Message);
            }
        }

        public List<Product> getProductsByCategoryId(int categoryId)
        {
            try
            {
                var dbContent = new BirdContext();
                return dbContent.Products.Where(p => p.CategoryId == categoryId).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Delete Error!!!" + ex.Message);
            }
        }
    }
}
