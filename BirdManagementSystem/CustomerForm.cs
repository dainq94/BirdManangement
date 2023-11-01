using BirdService;
using BusinessObjects.Models;
using System.Net;

namespace Bird.APP
{
    public partial class CustomerForm : Form
    {
        private readonly ICategoryService _categoryService = null;
        private readonly IProductService _productService = null;
        private readonly IOrderService _orderService = null;
        private BindingSource bindingSource = null;
        private BindingSource orderDetailBindingSource = null;

        public CustomerForm()
        {
            InitializeComponent();
            if (GlobalData.AuthenticatedUser == null)
            {
                MessageBox.Show("Let's start with login Form!");
                this.Close();
            }
            _categoryService = new CategoryService();
            _productService = new ProductService();
            _orderService = new OrderService();
        }
        //tab Home--------------------------------------------------------------------
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }



        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCategory();

            LoadGridView();
        }
        private void LoadCategory()
        {
            List<Category> categories = _categoryService.GetCategories();
            categories.Insert(0, new Category()
            {
                CategoryId = 0,
                CategoryName = "Select the category"
            });
            cbProductCategory2.DataSource = categories;
            cbProductCategory2.DisplayMember = "CategoryName";
            cbProductCategory2.ValueMember = "CategoryId";
            cbProductCategory2.SelectedValue = 0;
            cbProductCategory2.SelectedIndex = 0;
        }
        private void LoadGridView()
        {
            dgvProducts.DataSource = _productService.GetAllProducts();
            dgvProducts.Columns["Description"].Visible = false;
            dgvProducts.Columns["CategoryID"].Visible = false;
            dgvProducts.Columns["Image"].Visible = false;
            dgvProducts.Columns["Category"].Visible = false;
            dgvProducts.Columns["Carts"].Visible = false;
            dgvProducts.Columns["OrderDetails"].Visible = false;
            dgvProducts.CurrentCell = dgvProducts[0, 0];
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtProductNameSearch.Text = string.Empty;

            txtUnitPriceMinSearch.Text = string.Empty;
            txtUnitPriceMaxSearch.Text = string.Empty;
            txtUnitsInStockMinSearch.Text = string.Empty;
            txtUnitsInStockMaxSearch.Text = string.Empty;
            cbProductCategory2.SelectedValue = 0;
            LoadGridView();

            //cbProductSort.SelectedIndex = 0;
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbProductName.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dgvProducts.CurrentRow.Cells[4].Value.ToString();
            txtDesc.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
            txtAvailable.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
            object cellValue = dgvProducts.CurrentRow.Cells[6].Value;
            if (cellValue != null)
            {
                string imageURL = cellValue.ToString();
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        byte[] imageData = client.DownloadData(imageURL);
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            Image image = Image.FromStream(ms);
                            pbProductAvatar.Image = image;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public int ToIntOrZero(string input)
        {
            try
            {
                return Convert.ToInt32(input);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        private void cbProductCategory2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var category = (Category)(cbProductCategory2.SelectedItem);
            if (category != null)
            {
                int categoryId = category.CategoryId;
                dgvProducts.DataSource = _productService.getProductsByCategoryId(categoryId);
            }
        }


    }
}
