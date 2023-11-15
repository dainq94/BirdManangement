using BirdService;
using BusinessObjects.Models;
using GiftHommieWinforms;
using System.Data;
using System.Net;
using System.Text.RegularExpressions;

namespace Bird.APP
{
    public partial class CustomerForm : Form
    {
        private readonly ICategoryService _categoryService = null;
        private readonly IProductService _productService = null;
        private readonly IOrderService _orderService = null;
        private readonly ICartService _cartService = null;
        private readonly IUserService _userService = null;
        private BindingSource bindingSource = null;
        private BindingSource orderDetailBindingSource = null;
        private const string DEFAULT_AVATAR = "https://plus.unsplash.com/premium_photo-1683121366070-5ceb7e007a97?auto=format&fit=crop&q=80&w=2070&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D";

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
            _cartService = new CartService();
            _userService = new UserService();
        }
        //tab Home--------------------------------------------------------------------
        private void tabControllCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControllCustomer.SelectedIndex == 0)
            {
                tabHome_Click(sender, e);
            }
            else if (tabControllCustomer.SelectedIndex == 1)
            {
                tabPage2_Click(sender, e);
            }
            else if (tabControllCustomer.SelectedIndex == 2)
            {
                tabMyProfile_Click(sender, e);
            }
            //else if (tabcontrolCustomer.SelectedIndex == 3)
            //{
            //    tabMyProfile_Click(sender, e);
            //}
        }
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void tabHome_Click(object sender, EventArgs e)
        {
            LoadCategory();
            LoadGridView();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            tabHome_Click(sender, e);
            // LoadDgvCarts();

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
        private void cbProductCategory2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var category = (Category)(cbProductCategory2.SelectedItem);
            if (category != null)
            {
                int categoryId = category.CategoryId;
                dgvProducts.DataSource = _productService.getProductsByCategoryId(categoryId);
                dgvProducts.Columns["Description"].Visible = false;
                dgvProducts.Columns["CategoryID"].Visible = false;
                dgvProducts.Columns["Image"].Visible = false;
                dgvProducts.Columns["Category"].Visible = false;
                dgvProducts.Columns["Carts"].Visible = false;
                dgvProducts.Columns["OrderDetails"].Visible = false;
            }
        }
        //Search product 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtProductNameSearch.Text.Trim().ToLower();
            if (searchValue.Length > 0)
            {
                //dgvProducts.DataSource = _productService.GetAllProducts()
                //    .Where(s => s.Name.Contains(searchValue)).Select(p => new
                //    {
                //        p.ProductId,
                //        p.Name,
                //        p.Quantity,
                //        p.Description,
                //        p.Price,
                //        p.Category.CategoryName,
                //        p.Status
                //    }).ToList();
                List<Product> products = _productService.SearchProductsByName(searchValue);
                dgvProducts.DataSource = products;
            }
            else
            {
                LoadGridView();
            }
        }


        // Cart tab ----------------------------------------------------------------------------------------------




        private Dictionary<int, bool> memory = new Dictionary<int, bool>();



        private void lbCartName_Click(object sender, EventArgs e)
        {

        }

        private void pbProductAvatar_Click(object sender, EventArgs e)
        {

        }


        //private void LoadDgvCarts()
        //{
        //    List<Cart> carts = _cartService.GetAllCartItemsByUsername(GlobalData.AuthenticatedUser.Username);
        //    List<Product> products = _productService.GetAllProducts();
        //    dgvCarts.DataSource = carts;
        //    DataGridViewColumn newColumn = new DataGridViewTextBoxColumn();
        //    newColumn.HeaderText = "ProductName";  // Set the column header text
        //    dgvCarts.Columns.Add(newColumn);
        //    dataTable.Columns.Add(newColumn.HeaderText);
        //    foreach (DataGridViewRow row in dgvProducts.Rows)
        //    {
        //        foreach (Product product in products)
        //        {
        //            if ((int)row.Cells["ProductId"].Value == product.ProductId)
        //            {
        //                dataTable.Rows.Add(product.Name);
        //            }

        //        }
        //    }

        //    dgvCarts.DataSource = dataTable;

        //    //dgvCarts.Columns["Id"].Visible = false;

        //    ////dgvCarts.Columns["ProductId"].Visible 
        //    //dgvCarts.Columns["UsernameNavigation"].Visible = false;

        //}
        private void LoadCartFilter()
        {
            List<Category> list = new List<Category> { new Category { CategoryId = 0, CategoryName = "Select the category" } };
            list.AddRange(_categoryService.GetCategories());
            cbCartFilterCategory.DataSource = list;
            cbCartFilterCategory.ValueMember = "CategoryId";
            cbCartFilterCategory.DisplayMember = "CategoryName";
            cbCartFilterCategory.SelectedIndex = 0;
            cbCartSorting.SelectedIndex = 0;
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            //LoadDgvCarts();
            LoadCartFilter();
            LoadCart();

        }
        private void lbCartName_TextChanged(object sender, EventArgs e)
        {
            LoadCartAvailable();
        }

        private void btnCartReset_Click(object sender, EventArgs e)
        {
            CartPageReset();
            LoadCart();
        }
        //CART EVENT TEXTCHANGED
        private void cbCartSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCartVisible();
        }
        private void cbCartFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCartVisible();

        }
        //Add to cart
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ADD TO CART SUCCESSFULLY") == DialogResult.OK)
            {
                try
                {
                    //int productId = ((Product)bindingSource.Current).ProductId;
                    int productId = (int)dgvProducts.CurrentRow.Cells[0].Value;
                    Cart cart = new Cart
                    {
                        Username = GlobalData.AuthenticatedUser.Username,
                        ProductId = productId,
                        Quantity = 1,
                    };

                    _cartService.Save(cart);
                    //LoadDgvCarts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CartPageReset()
        {
            cbCartFilterCategory.SelectedIndex = 0;
            cbCartSorting.SelectedIndex = 0;
            txtCartFilterName.Text = "";
            memory.Clear();
        }
        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
        private void LoadCartAvailable()
        {
            try
            {
                //int productId = (int)(bindingSource.Current as Cart).ProductId;
                var bindingsrc = ((Cart)bindingSource.Current);
                if (bindingsrc != null)
                {
                    int productId = (int)((Cart)bindingSource.Current).ProductId;
                    txtCartAvailable.Text = _orderService.GetAvailableProductQuantity(productId).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //REFRESH CART
        private bool RefreshUserCart() => _cartService.RefreshAllCart(GlobalData.AuthenticatedUser.Username);
        //TRONG LOADCART CO SAN REFRESH CART
        private void LoadCart()
        {
            bindingSource = new BindingSource();
            if (RefreshUserCart())
                MessageBox.Show("YOUR CART HAS BEEN CHANGE");

            SetCartVisible();
        }
        private void SetCartVisible()
        {
            List<Cart> list = _cartService.GetAllCartItemsByUsername(GlobalData.AuthenticatedUser.Username);
            //List<string> columns = new List<string>
            //{
            //    "ID", "Username", "ProductId", "UsernameNavigation", "LastUpdatedTime"
            //};
            bindingSource = new BindingSource();

            //RELOAD CART FILTER    
            list = CartFilterTheDataGridView(list);

            bindingSource.DataSource = list.Select(p => new
            {
                p.Username,
                p.ProductId,
                p.Quantity,
                p.LastUpDatedTime,
                p.Product.Name,

            });
            dgvCarts.DataSource = bindingSource;

            //dgvCarts.Columns["Product"];





            //dgvCarts.Columns["ProductName"].
            //productNameColumn.HeaderText = "ProductName";
            //productNameColumn.ValueType = "ProductNam
            //productNameColumn.DataPropertyName = "ProductName";
            //dgvCarts.Columns["Product"].Name =;
            //foreach (string c in columns)
            //{
            //    dgvCarts.Columns[c].Visible = false;
            //}

            //SET DEFAULT VALUE FOR CHECKBOX
            LoadChoosenItems();
            SetCartCurrentProduct();
            LoadCartTotal();
        }
        private List<Cart> CartFilterTheDataGridView(List<Cart> list)
        {
            list = list.Where(c => c.Product.Name.Trim().ToUpper()
                .Contains(txtCartFilterName.Text.ToUpper()))
                .ToList();

            if (cbCartFilterCategory.SelectedIndex > 0)
            {
                list = list.Where(c => c.Product.CategoryId == (int)cbCartFilterCategory.SelectedValue)
                    .ToList();
            }

            if (cbCartSorting.SelectedIndex > 0)
            {
                if (cbCartSorting.SelectedIndex == 1)
                {
                    list = list.OrderBy(c => c.Product.Price * c.Quantity).ToList();
                }
                else
                {
                    list = list.OrderByDescending(c => c.Product.Price * c.Quantity).ToList();
                }
            }
            return list;
        }
        private void LoadChoosenItems()
        {
            foreach (DataGridViewRow row in dgvCarts.Rows)
            {
                int cartId = (int)row.Cells["Id"].Value;
                row.Cells["Check"].Value = (memory.ContainsKey(cartId)) ? memory[cartId] : false;
            }
        }
        private void SetCartCurrentProduct()
        {
            lbCartName.Text = "";
            txtCartPrice.Text = "";
            txtCartQuantity.Text = "";
            txtCartAvailable.Text = "";
            pbCartAvatar.ImageLocation = "";
            txtCartDescription.Text = "";

            lbCartName.DataBindings.Clear();
            txtCartPrice.DataBindings.Clear();
            txtCartQuantity.DataBindings.Clear();
            txtCartAvailable.DataBindings.Clear();
            pbCartAvatar.DataBindings.Clear();
            txtCartDescription.DataBindings.Clear();

            txtCartTotal.Text = "0";
            //lblCartIndex.Text = "1";
            lbCartName.DataBindings.Add("Text", bindingSource, "Product.Name");
            txtCartPrice.DataBindings.Add("Text", bindingSource, "Product.Price");
            txtCartQuantity.DataBindings.Add("Text", bindingSource, "Quantity");
            txtCartDescription.DataBindings.Add("Text", bindingSource, "Product.Description");
            pbCartAvatar.DataBindings.Add(new System.Windows.Forms.Binding(
             "ImageLocation", bindingSource, "Product.Image", true));
        }
        private void LoadCartTotal()
        {
            txtCartTotal.Text = "0";

            foreach (int cartId in memory.Keys.Where(k => memory[k]))
            {
                Cart cart = _cartService.GetCartById(GlobalData.AuthenticatedUser.Username, cartId);

                txtCartTotal.Text = (int.Parse(txtCartTotal.Text)
                + cart.Quantity
                    * (_productService.GetProductById((int)cart.ProductId).Price)).ToString();
            }
        }

        private void dgvCarts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int productId = (int)((Cart)bindingSource.Current).ProductId;
            }
            catch
            {

            }
        }
        //LOAD CART INDEX PAGE
        //private void LoadCartIndexPage()
        //{
        //    int p = bindingSource.Position;
        //    lblCartIndex.Text = (p + 1).ToString();
        //}

        //Cart click 
        private void dgvCarts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //lblCartIndex.Text = (bindingSource.Position + 1).ToString();
            int c, r;

            if (e.ColumnIndex == 0 && dgvCarts.RowCount > 0)
            {
                c = e.ColumnIndex;
                r = e.RowIndex;

                dgvCarts.Rows[r].Cells[c].Value = !((bool)dgvCarts.Rows[r].Cells[c].Value);

                bool check = (bool)dgvCarts.Rows[r].Cells[c].Value;
                int cartId = (int)dgvCarts.Rows[r].Cells["Id"].Value;

                memory[cartId] = check;
                LoadCartTotal();
            }
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSource.Current == null)
                {
                    return;
                }
                int quantity = int.Parse(txtCartQuantity.Text);
                int productId = (int)(bindingSource.Current as Cart).ProductId;

                if (quantity < _orderService.GetAvailableProductQuantity(productId))
                {
                    Cart cart = bindingSource.Current as Cart;
                    int p = bindingSource.Position;
                    _cartService.UpdateCartQuantityById(cart.Id, quantity + 1);
                    LoadCart();
                    //bindingSource.Position = p;
                    //lblCartIndex.Text = (p + 1).ToString();
                }
                else
                    MessageBox.Show("QUANTITY CANNOT MORE THAN AVAILABLE");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSource.Current == null)
                {
                    return;
                }

                int quantity = int.Parse(txtCartQuantity.Text);

                if (quantity > 1)
                {
                    Cart cart = bindingSource.Current as Cart;
                    int p = bindingSource.Position;
                    _cartService.UpdateCartQuantityById(cart.Id, quantity - 1);
                    LoadCart();
                    //bindingSource.Position = p;
                    //lblCartIndex.Text = (p + 1).ToString();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        ///Delete Cart 
        private void DeleteChoosenCartItem()
        {
            foreach (int id in memory.Keys.Where(i => memory[i]).ToList())
            {
                if (memory[id])
                    _cartService.DeleteCartById(id);
            }
            memory.Clear();
        }

        private void btnCartDelete_Click(object sender, EventArgs e)
        {
            List<int> list = memory.Keys.Where(i => memory[i]).ToList();

            if (list.Count <= 0)
                return;

            if (list.Count > 0 && MessageBox.Show("DO YOU WANT TO DELETE CART ITEMS?", "CONFIRM", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DeleteChoosenCartItem();
            }

            LoadCart();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            List<Cart> list = new List<Cart>();
            LoadCart();

            foreach (int id in memory.Keys.Where(k => memory[k]))
            {
                list.Add(_cartService
                            .GetCartById(GlobalData.AuthenticatedUser.Username, id));
            }

            if (list.Count > 0)
            {
                var checkout = new CheckoutForm
                {
                    CartList = list,
                    Total = double.Parse(txtCartTotal.Text)
                };

                if (checkout.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("BUY SUCCESSFULLY");

                    DeleteChoosenCartItem();
                    LoadCart();
                }
            }
        }
        /// Tab Profile ================================================================================


        private void tabMyProfile_Click(object sender, EventArgs e)
        {
            LoadUserProfile();
        }
        private void LoadUserProfile()
        {
            User user = _userService.GetUserByUsername(GlobalData.AuthenticatedUser.Username);
            if (user == null)
            {
                MessageBox.Show("something went wrong");
            }
            else
            {
                txtUserName.Text = user.Username;
                txtEmail.Text = user.Email;
                txtRole.Text = user.Role;
                txtName.Text = user.Name;
                txtGender.Text = user.Gender;
                txtPhone.Text = user.Phone;
                txtAddress.Text = user.Address;
                txtYob.Text = user.Yob.ToString();
                pbCustomerAvatar.ImageLocation = DEFAULT_AVATAR;
                btnSave.Visible = false;
            }
        }
        private bool CheckCharacterOfPhone(String input)
        {
            string pattern = @"^\d{9,12}$"; // Ký tự chữ cái không phải là số
            return Regex.IsMatch(input, pattern);
        }

        private bool CheckCharacterOfYob(String input)
        {
            string pattern = @"^\d{4,4}$"; // Ký tự chữ cái không phải là số
            return Regex.IsMatch(input, pattern);
        }

        private bool CheckName(String input)
        {
            string pattern = @"\d"; // Ký tự chữ cái không phải là số
            return Regex.IsMatch(input, pattern);
        }
        private bool CheckCharacter(String input)
        {
            string pattern = "^[a-zA-Z ]+$"; // Ký tự chữ cái không phải là số
            return Regex.IsMatch(input, pattern);
        }
        private bool ValidateInputs()
        {
            if (
                string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtYob.Text) ||
                string.IsNullOrEmpty(txtAddress.Text) ||
                string.IsNullOrEmpty(txtPhone.Text)

                )

            {
                MessageBox.Show("Please fill out the information completely", "Lack of information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (CheckCharacterOfPhone(txtPhone.Text) != true)
            {
                MessageBox.Show("Please only enter the number in the Phone box from 9 to 12 digits .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Clear();
                return false;
            }

            if (CheckName(txtName.Text) == true)
            {
                MessageBox.Show("Names cannot contain digits .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Clear();
                return false;
            }

            if (CheckCharacterOfYob(txtYob.Text) != true)
            {
                MessageBox.Show("Please enter only the correct year of birth  .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYob.Clear();
                return false;

            }

            if (int.Parse(txtYob.Text) < 1950 || int.Parse(txtYob.Text) >= 2023)
            {
                MessageBox.Show("Please enter only the correct year of birth (1950 - 2023).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYob.Clear();
                return false;
            }

            return true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                btnEdit.Text = "Cancel";
                txtName.ReadOnly = false;
                txtPhone.ReadOnly = false;
                txtAddress.ReadOnly = false;
                txtYob.ReadOnly = false;
                btnSave.Visible = true;
                txtEmail.ReadOnly = false;
                phonedup.Visible = false;
                emaildup.Visible = false;
            }
            else
            {
                btnEdit.Text = "Edit";
                phonedup.Visible = false;
                emaildup.Visible = false;
                ChangeReadOnly();
                LoadUserProfile();
            }
        }
        private void ChangeReadOnly()
        {
            txtName.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtYob.ReadOnly = true;
            txtEmail.ReadOnly = true;
        }
        private bool CheckDupplicated()
        {
            User Oldemail = GlobalData.AuthenticatedUser;

            if (txtEmail.Text.Equals(Oldemail.Email))
            {
                return true;
            }
            else if (_userService.CheckEmail(txtEmail.Text) != true)
            {
                return true;
            }
            return false;
        }
        private bool CheckDupplicatedPhone()
        {
            User Oldemail = GlobalData.AuthenticatedUser;

            if (txtPhone.Text.Equals(Oldemail.Phone) || _userService.CheckPhone(txtPhone.Text) != true)
            {
                return true;
            }
            return false;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (ValidateInputs() == true && CheckDupplicated() == true && CheckDupplicatedPhone() == true)
            {
                User user = new User()
                {
                    Username = GlobalData.AuthenticatedUser.Username,
                    Email = txtEmail.Text,
                    Role = GlobalData.AuthenticatedUser.Role,
                    Password = GlobalData.AuthenticatedUser.Password,
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Gender = GlobalData.AuthenticatedUser.Gender,
                    Yob = int.Parse(txtYob.Text.Trim()),
                    Address = txtAddress.Text,
                    Image = GlobalData.AuthenticatedUser.Image,
                    Status = GlobalData.AuthenticatedUser.Status
                };
                DialogResult d;
                d = MessageBox.Show($"Save User ", "Profile", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

                if (d == DialogResult.OK)
                {
                    _userService.Save(user);
                    DialogResult = DialogResult.OK;
                    btnEdit.Text = "Edit";
                    ChangeReadOnly();
                    LoadUserProfile();
                }
            }
            else
            {
                MessageBox.Show("Please Check Value Input Again");

            }
        }

        private void cbProductSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
