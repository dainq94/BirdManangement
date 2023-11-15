﻿using Bird.APP;
using BirdService;
using BusinessObjects.Models;
using System.Text.RegularExpressions;

namespace GiftHommieWinforms
{
    public partial class CheckoutForm : Form
    {
        private IOrderService _orderService = null;
        private IProductService _productService = null;
        public List<Cart> CartList;
        // private double DEFAULT_SHIPPING_FEE = 20000;
        public double Total;
        private string DEFAULT_STATUS = "ORDERED";
        public CheckoutForm()
        {
            InitializeComponent();
            _orderService = new OrderService();
            _productService = new ProductService();
        }
        private void SetValidation()
        {
            if (txtPhone.Text.Trim().Length < 8)
                btnCheckout.Enabled = false;
            else if (txtName.Text.Trim().Length < 2)
                btnCheckout.Enabled = false;
            else if (txtAddress.Text.Trim().Length < 5)
                btnCheckout.Enabled = false;
            else
                btnCheckout.Enabled = true;
        }
        private void dgvCheckout_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvCheckout.Columns["ProductId"].Index && e.RowIndex >= 0)
            {
                int productId = Convert.ToInt32(e.Value);
                var product = _productService.GetProductById(productId);
                e.Value = product.Name;
                dgvCheckout.Columns["ProductId"].HeaderText = "Product Name";
            }
        }
        private Order GetCurrentOrder()
        {
            return new Order
            {
                Username = GlobalData.AuthenticatedUser.Username,
                OrderTime = DateTime.Now,
                Name = txtName.Text,
                Address = txtAddress.Text,
                //ShippingFee = DEFAULT_SHIPPING_FEE,
                //OrderTime = DateTime.Now,
                Message = txtMessage.Text,
                Status = DEFAULT_STATUS,
                //ShippingMode = true,
                //Comment = txtComment.Text,
                Phone = txtPhone.Text,
            };
        }

        private List<OrderDetail> GetCurrentOrderDetail()
        {
            List<OrderDetail> details = new List<OrderDetail>();

            foreach (Cart cart in CartList)
            {
                details.Add(new OrderDetail
                {
                    ProductId = cart.ProductId,
                    Price = cart.Product.Price,
                    Quantity = cart.Quantity,
                });
            }

            return details;
        }
        private bool CheckCharacterOfPhone(String input)
        {
            string pattern = @"^\d{9,12}$"; // Ký tự chữ cái không phải là số
            return Regex.IsMatch(input, pattern);
        }
        private bool CheckPhone(String input)
        {
            if (!CheckCharacterOfPhone(txtPhone.Text))
            {
                txtPhone.Focus();
                throw new Exception("PLEASE TYPE THE PHONE NUMBER FROM 9 to 12 DIGITS");
            }

            if (input[0] != '0')
            {
                txtPhone.Focus();
                throw new Exception("WRONG FORMAT OF PHONE");
            }

            return true;
        }

        private bool CheckName(String input)
        {
            if (input.Trim().Length <= 5)
            {
                txtName.Focus();
                throw new Exception("NAME WAS TOO SHORT");
            }


            string pattern = @"\d"; // Ký tự chữ cái không phải là số
            if (Regex.IsMatch(input, pattern))
            {
                txtName.Focus();
                throw new Exception("WRONG FORMAT OF NAME");
            }

            return true;
        }
        private void LoadData()
        {
            txtName.Text = GlobalData.AuthenticatedUser.Name;
            txtAddress.Text = GlobalData.AuthenticatedUser.Address;
            txtPhone.Text = GlobalData.AuthenticatedUser.Phone;
            txtTotal.Text = Total.ToString();

            List<string> columns = new List<string>
            {
                "ID", "OrderId", "Product", "Order"
            };
            List<OrderDetail> details = GetCurrentOrderDetail();

            foreach (OrderDetail orderDetail in details)
            {
                orderDetail.Product = _productService.GetProductById((int)orderDetail.ProductId);
            }

            dgvCheckout.DataSource = details;

            foreach (string c in columns)
            {
                dgvCheckout.Columns[c].Visible = false;
            }

            SetValidation();
        }

        private void frmCheckout_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<OrderDetail> detals = new List<OrderDetail>();
            try
            {
                CheckName(txtName.Text.Trim());

                CheckPhone(txtPhone.Text);

                Order order = GetCurrentOrder();
                List<OrderDetail> details = GetCurrentOrderDetail();


                order.OrderDetails = details;
                _orderService.Add(order);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            SetValidation();
            foreach (char c in txtAddress.Text)
            {
                if (!char.IsLetterOrDigit(c) && c != ' ' && c != ',')
                {
                    int len = txtAddress.Text.Length;
                    txtAddress.Text = txtAddress.Text.Remove(txtAddress.Text.Length - 1, 1);
                    MessageBox.Show("WRONG FORMAT");
                    return;
                }
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            SetValidation();
            foreach (char c in txtName.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    txtName.Text = txtName.Text.Remove(txtName.Text.Length - 1, 1);
                    MessageBox.Show("WRONG FORMAT");
                    return;
                }
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            SetValidation();
            foreach (char c in txtPhone.Text)
            {
                if (!char.IsDigit(c))
                {
                    txtPhone.Text = txtPhone.Text.Remove(txtPhone.Text.Length - 1, 1);
                    MessageBox.Show("WRONG FORMAT");
                    return;
                }
            }
        }

        private void txtName_TextChanged_1(object sender, EventArgs e)
        {

        }


    }
}
