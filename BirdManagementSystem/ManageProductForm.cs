using BirdService;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bird.APP
{
    public partial class ManageProductForm : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public Product Product { get; set; }
        private BindingSource _bindingSource = new BindingSource();
        public ManageProductForm()
        {
            InitializeComponent();
            _productService = new ProductService();
            _categoryService = new CategoryService();
        }
        //create = false; update = true
        public Boolean CreateOrUpdate { get; set; }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            //Update
            if(CreateOrUpdate == true)
            {
                //load category
                var loadCategory = _categoryService.GetCategories();
                cb_category.DataSource = loadCategory;
                cb_category.DisplayMember = "CategoryID";
                cb_category.ValueMember = "CategoryName";

                //load data to update
                _bindingSource.DataSource = new BindingSource();
                _bindingSource.DataSource = Product;
                txt_productname.Text = Product.Name;
                txt_description.Text = Product.Description;
                txt_quantity.Text = Convert.ToString(Product.Quantity);
                txt_price.Text = Convert.ToString(Product.Price);
                txt_image.Text = Product.Image;

            } 
            //Create
            else
            {
                var loadCategory = _categoryService.GetCategories();
                cb_category.DataSource = loadCategory;
                cb_category.DisplayMember = "CategoryID";
                cb_category.ValueMember = "CategoryName";
            }
            
        }

        private void dtg_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Product product = _productService.GetProductById(int.Parse(txt_productid.Text.Trim()));
            //    if (product != null)
            //    {
            //        product.Name = txt_productname.Text.Trim();
            //        product.Description = txt_description.Text.Trim();
            //        product.Quantity = int.Parse(txt_quantity.Text.Trim());
            //        product.Price = double.Parse(txt_price.Text.Trim());
            //        product.CategoryId = int.Parse(cb_category.SelectedValue.ToString());

            //        _productService.UpdateProduct(product);
            //        MessageBox.Show("Update Successful");
            //        dtg_product.DataSource = _productService.GetAllProducts().Select(p => new
            //        {
            //            p.ProductId,
            //            p.Name,
            //            p.Description,
            //            p.Quantity,
            //            p.Price,
            //            p.Category.CategoryName,
            //            p.Image
            //        }).ToList();
            //        cb_category.DataSource = _categoryService.GetCategories();
            //        cb_category.DisplayMember = "CategoryName";
            //        cb_category.ValueMember = "CategoryID";
            //    }
            //    else
            //    {
            //        MessageBox.Show("PRoductId isn't empty!!!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
