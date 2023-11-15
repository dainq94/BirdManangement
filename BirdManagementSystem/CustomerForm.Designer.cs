namespace Bird.APP
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControllCustomer = new TabControl();
            tabHome = new TabPage();
            gbSelect = new GroupBox();
            txtCurrentIndex = new TextBox();
            btnNext = new Button();
            btnBack = new Button();
            groupBox3 = new GroupBox();
            dgvProducts = new DataGridView();
            groupBoxProduct = new GroupBox();
            groupBox4 = new GroupBox();
            txtDesc = new TextBox();
            txtAvailable = new TextBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            lbProductName = new Label();
            pbProductAvatar = new PictureBox();
            groupBoxSearch = new GroupBox();
            btnAddToCart = new Button();
            label6 = new Label();
            label5 = new Label();
            cbProductSort = new ComboBox();
            cbProductCategory2 = new ComboBox();
            txtProductNameSearch = new TextBox();
            label1 = new Label();
            btnReset = new Button();
            btnSearch = new Button();
            tabPage2 = new TabPage();
            groupBox7 = new GroupBox();
            dgvCarts = new DataGridView();
            Check = new DataGridViewCheckBoxColumn();
            groupBox6 = new GroupBox();
            btnCartDelete = new Button();
            btnDecrease = new Button();
            btnIncrease = new Button();
            txtCartQuantity = new TextBox();
            label28 = new Label();
            txtCartAvailable = new TextBox();
            txtCartPrice = new TextBox();
            groupBox9 = new GroupBox();
            txtCartDescription = new TextBox();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            lbCartName = new Label();
            pbCartAvatar = new PictureBox();
            groupBox5 = new GroupBox();
            txtCartTotal = new TextBox();
            lbCartTotal = new Label();
            cbCartSorting = new ComboBox();
            label17 = new Label();
            cbCartFilterCategory = new ComboBox();
            btnCheckout = new Button();
            label18 = new Label();
            txtCartFilterName = new TextBox();
            label19 = new Label();
            btnCartReset = new Button();
            button2 = new Button();
            tabMyProfile = new TabPage();
            phonedup = new Label();
            emaildup = new Label();
            pbCustomerAvatar = new PictureBox();
            btnSave = new Button();
            btnEdit = new Button();
            txtAddress = new TextBox();
            txtYob = new TextBox();
            txtPhone = new TextBox();
            txtGender = new TextBox();
            txtName = new TextBox();
            txtRole = new TextBox();
            txtEmail = new TextBox();
            txtUserName = new TextBox();
            label31 = new Label();
            label30 = new Label();
            label29 = new Label();
            label27 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            lbUserName = new Label();
            tabControllCustomer.SuspendLayout();
            tabHome.SuspendLayout();
            gbSelect.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            groupBoxProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductAvatar).BeginInit();
            groupBoxSearch.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarts).BeginInit();
            groupBox6.SuspendLayout();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCartAvatar).BeginInit();
            groupBox5.SuspendLayout();
            tabMyProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCustomerAvatar).BeginInit();
            SuspendLayout();
            // 
            // tabControllCustomer
            // 
            tabControllCustomer.Controls.Add(tabHome);
            tabControllCustomer.Controls.Add(tabPage2);
            tabControllCustomer.Controls.Add(tabMyProfile);
            tabControllCustomer.Location = new Point(-7, 2);
            tabControllCustomer.Name = "tabControllCustomer";
            tabControllCustomer.SelectedIndex = 0;
            tabControllCustomer.Size = new Size(1444, 705);
            tabControllCustomer.TabIndex = 0;
            tabControllCustomer.SelectedIndexChanged += tabControllCustomer_SelectedIndexChanged;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(gbSelect);
            tabHome.Controls.Add(groupBox3);
            tabHome.Controls.Add(groupBoxProduct);
            tabHome.Controls.Add(groupBoxSearch);
            tabHome.Location = new Point(4, 29);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3);
            tabHome.Size = new Size(1436, 672);
            tabHome.TabIndex = 0;
            tabHome.Text = "Home";
            tabHome.UseVisualStyleBackColor = true;
            tabHome.Click += tabHome_Click;
            // 
            // gbSelect
            // 
            gbSelect.Controls.Add(txtCurrentIndex);
            gbSelect.Controls.Add(btnNext);
            gbSelect.Controls.Add(btnBack);
            gbSelect.Location = new Point(355, 258);
            gbSelect.Name = "gbSelect";
            gbSelect.Size = new Size(1077, 72);
            gbSelect.TabIndex = 3;
            gbSelect.TabStop = false;
            // 
            // txtCurrentIndex
            // 
            txtCurrentIndex.Location = new Point(487, 31);
            txtCurrentIndex.Name = "txtCurrentIndex";
            txtCurrentIndex.Size = new Size(125, 27);
            txtCurrentIndex.TabIndex = 2;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(638, 31);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 1;
            btnNext.Text = ">>";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(369, 29);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 0;
            btnBack.Text = "<<";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvProducts);
            groupBox3.Location = new Point(355, 322);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1071, 329);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(-29, 40);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1081, 265);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // groupBoxProduct
            // 
            groupBoxProduct.Controls.Add(groupBox4);
            groupBoxProduct.Controls.Add(txtDesc);
            groupBoxProduct.Controls.Add(txtAvailable);
            groupBoxProduct.Controls.Add(label4);
            groupBoxProduct.Controls.Add(txtPrice);
            groupBoxProduct.Controls.Add(label3);
            groupBoxProduct.Controls.Add(lbProductName);
            groupBoxProduct.Controls.Add(pbProductAvatar);
            groupBoxProduct.Location = new Point(326, 0);
            groupBoxProduct.Name = "groupBoxProduct";
            groupBoxProduct.Size = new Size(1111, 252);
            groupBoxProduct.TabIndex = 1;
            groupBoxProduct.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(0, 275);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(937, 55);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(235, 158);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.ReadOnly = true;
            txtDesc.Size = new Size(834, 83);
            txtDesc.TabIndex = 7;
            // 
            // txtAvailable
            // 
            txtAvailable.Location = new Point(638, 110);
            txtAvailable.Name = "txtAvailable";
            txtAvailable.ReadOnly = true;
            txtAvailable.Size = new Size(125, 27);
            txtAvailable.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(514, 110);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 4;
            label4.Text = "Available";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(329, 110);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 117);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbProductName.Location = new Point(235, 34);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(206, 38);
            lbProductName.TabIndex = 1;
            lbProductName.Text = "Product Name";
            // 
            // pbProductAvatar
            // 
            pbProductAvatar.Location = new Point(19, 18);
            pbProductAvatar.Name = "pbProductAvatar";
            pbProductAvatar.Size = new Size(210, 223);
            pbProductAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProductAvatar.TabIndex = 0;
            pbProductAvatar.TabStop = false;
            pbProductAvatar.Click += pbProductAvatar_Click;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Controls.Add(btnAddToCart);
            groupBoxSearch.Controls.Add(label6);
            groupBoxSearch.Controls.Add(label5);
            groupBoxSearch.Controls.Add(cbProductSort);
            groupBoxSearch.Controls.Add(cbProductCategory2);
            groupBoxSearch.Controls.Add(txtProductNameSearch);
            groupBoxSearch.Controls.Add(label1);
            groupBoxSearch.Controls.Add(btnReset);
            groupBoxSearch.Controls.Add(btnSearch);
            groupBoxSearch.Location = new Point(0, 0);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(320, 651);
            groupBoxSearch.TabIndex = 0;
            groupBoxSearch.TabStop = false;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(34, 34);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(135, 38);
            btnAddToCart.TabIndex = 6;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 259);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 7;
            label6.Text = "Sorting";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 191);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 6;
            label5.Text = "Category";
            // 
            // cbProductSort
            // 
            cbProductSort.FormattingEnabled = true;
            cbProductSort.Location = new Point(34, 275);
            cbProductSort.Name = "cbProductSort";
            cbProductSort.Size = new Size(250, 28);
            cbProductSort.TabIndex = 5;
            cbProductSort.SelectedIndexChanged += cbProductSort_SelectedIndexChanged;
            // 
            // cbProductCategory2
            // 
            cbProductCategory2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProductCategory2.FormattingEnabled = true;
            cbProductCategory2.Location = new Point(34, 214);
            cbProductCategory2.Name = "cbProductCategory2";
            cbProductCategory2.Size = new Size(250, 28);
            cbProductCategory2.TabIndex = 4;
            cbProductCategory2.SelectedIndexChanged += cbProductCategory2_SelectedIndexChanged;
            // 
            // txtProductNameSearch
            // 
            txtProductNameSearch.Location = new Point(34, 142);
            txtProductNameSearch.Name = "txtProductNameSearch";
            txtProductNameSearch.Size = new Size(175, 27);
            txtProductNameSearch.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 113);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 2;
            label1.Text = "Product Name";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(215, 34);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 39);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(215, 142);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox7);
            tabPage2.Controls.Add(groupBox6);
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1436, 672);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "My Cart";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(dgvCarts);
            groupBox7.Location = new Point(355, 345);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(1062, 305);
            groupBox7.TabIndex = 2;
            groupBox7.TabStop = false;
            // 
            // dgvCarts
            // 
            dgvCarts.AllowUserToAddRows = false;
            dgvCarts.AllowUserToDeleteRows = false;
            dgvCarts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarts.Columns.AddRange(new DataGridViewColumn[] { Check });
            dgvCarts.Dock = DockStyle.Top;
            dgvCarts.Location = new Point(3, 23);
            dgvCarts.Name = "dgvCarts";
            dgvCarts.ReadOnly = true;
            dgvCarts.RowHeadersWidth = 51;
            dgvCarts.RowTemplate.Height = 29;
            dgvCarts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarts.Size = new Size(1056, 297);
            dgvCarts.TabIndex = 1;
            dgvCarts.CellClick += dgvCarts_CellClick;
            dgvCarts.CellContentClick += dgvCarts_CellContentClick;
            dgvCarts.CellFormatting += dgvCarts_CellFormatting;
            // 
            // Check
            // 
            Check.FalseValue = "false";
            Check.HeaderText = "Choose";
            Check.MinimumWidth = 8;
            Check.Name = "Check";
            Check.ReadOnly = true;
            Check.TrueValue = "true";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnCartDelete);
            groupBox6.Controls.Add(btnDecrease);
            groupBox6.Controls.Add(btnIncrease);
            groupBox6.Controls.Add(txtCartQuantity);
            groupBox6.Controls.Add(label28);
            groupBox6.Controls.Add(txtCartAvailable);
            groupBox6.Controls.Add(txtCartPrice);
            groupBox6.Controls.Add(groupBox9);
            groupBox6.Controls.Add(label24);
            groupBox6.Controls.Add(label25);
            groupBox6.Controls.Add(label26);
            groupBox6.Controls.Add(lbCartName);
            groupBox6.Controls.Add(pbCartAvatar);
            groupBox6.Location = new Point(355, 6);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1073, 317);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            // 
            // btnCartDelete
            // 
            btnCartDelete.BackColor = Color.LemonChiffon;
            btnCartDelete.Location = new Point(759, 139);
            btnCartDelete.Name = "btnCartDelete";
            btnCartDelete.Size = new Size(144, 37);
            btnCartDelete.TabIndex = 110;
            btnCartDelete.Text = "Delete";
            btnCartDelete.UseVisualStyleBackColor = false;
            btnCartDelete.Click += btnCartDelete_Click;
            // 
            // btnDecrease
            // 
            btnDecrease.Location = new Point(936, 104);
            btnDecrease.Margin = new Padding(2, 3, 2, 3);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(34, 24);
            btnDecrease.TabIndex = 109;
            btnDecrease.Text = "-";
            btnDecrease.UseVisualStyleBackColor = true;
            btnDecrease.Click += btnDecrease_Click;
            // 
            // btnIncrease
            // 
            btnIncrease.Location = new Point(936, 77);
            btnIncrease.Margin = new Padding(2, 3, 2, 3);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(34, 21);
            btnIncrease.TabIndex = 108;
            btnIncrease.Text = "+";
            btnIncrease.UseVisualStyleBackColor = true;
            btnIncrease.Click += btnIncrease_Click;
            // 
            // txtCartQuantity
            // 
            txtCartQuantity.Location = new Point(871, 94);
            txtCartQuantity.Name = "txtCartQuantity";
            txtCartQuantity.ReadOnly = true;
            txtCartQuantity.RightToLeft = RightToLeft.Yes;
            txtCartQuantity.Size = new Size(53, 27);
            txtCartQuantity.TabIndex = 107;
            txtCartQuantity.TextAlign = HorizontalAlignment.Center;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(759, 93);
            label28.Name = "label28";
            label28.Size = new Size(92, 28);
            label28.TabIndex = 106;
            label28.Text = "Quantity:";
            // 
            // txtCartAvailable
            // 
            txtCartAvailable.Location = new Point(623, 93);
            txtCartAvailable.Name = "txtCartAvailable";
            txtCartAvailable.ReadOnly = true;
            txtCartAvailable.RightToLeft = RightToLeft.Yes;
            txtCartAvailable.Size = new Size(110, 27);
            txtCartAvailable.TabIndex = 100;
            txtCartAvailable.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCartPrice
            // 
            txtCartPrice.Location = new Point(358, 89);
            txtCartPrice.Name = "txtCartPrice";
            txtCartPrice.ReadOnly = true;
            txtCartPrice.RightToLeft = RightToLeft.Yes;
            txtCartPrice.Size = new Size(110, 27);
            txtCartPrice.TabIndex = 99;
            txtCartPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(txtCartDescription);
            groupBox9.Location = new Point(306, 165);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(733, 115);
            groupBox9.TabIndex = 105;
            groupBox9.TabStop = false;
            groupBox9.Text = "Description";
            // 
            // txtCartDescription
            // 
            txtCartDescription.Location = new Point(9, 27);
            txtCartDescription.Multiline = true;
            txtCartDescription.Name = "txtCartDescription";
            txtCartDescription.ReadOnly = true;
            txtCartDescription.Size = new Size(715, 83);
            txtCartDescription.TabIndex = 0;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(315, 166);
            label24.Name = "label24";
            label24.Size = new Size(0, 28);
            label24.TabIndex = 104;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(505, 90);
            label25.Name = "label25";
            label25.Size = new Size(96, 28);
            label25.TabIndex = 103;
            label25.Text = "Available:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(285, 89);
            label26.Name = "label26";
            label26.Size = new Size(58, 28);
            label26.TabIndex = 102;
            label26.Text = "Price:";
            // 
            // lbCartName
            // 
            lbCartName.AutoSize = true;
            lbCartName.Font = new Font("Segoe UI Semibold", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbCartName.Location = new Point(285, 23);
            lbCartName.Name = "lbCartName";
            lbCartName.Size = new Size(236, 45);
            lbCartName.TabIndex = 98;
            lbCartName.Text = "Product Name";
            lbCartName.TextChanged += lbCartName_TextChanged;
            lbCartName.Click += lbCartName_Click;
            // 
            // pbCartAvatar
            // 
            pbCartAvatar.Location = new Point(38, 25);
            pbCartAvatar.Name = "pbCartAvatar";
            pbCartAvatar.Size = new Size(214, 220);
            pbCartAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCartAvatar.TabIndex = 101;
            pbCartAvatar.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtCartTotal);
            groupBox5.Controls.Add(lbCartTotal);
            groupBox5.Controls.Add(cbCartSorting);
            groupBox5.Controls.Add(label17);
            groupBox5.Controls.Add(cbCartFilterCategory);
            groupBox5.Controls.Add(btnCheckout);
            groupBox5.Controls.Add(label18);
            groupBox5.Controls.Add(txtCartFilterName);
            groupBox5.Controls.Add(label19);
            groupBox5.Controls.Add(btnCartReset);
            groupBox5.Controls.Add(button2);
            groupBox5.Location = new Point(6, 6);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(343, 660);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            // 
            // txtCartTotal
            // 
            txtCartTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtCartTotal.Location = new Point(111, 359);
            txtCartTotal.Margin = new Padding(2, 3, 2, 3);
            txtCartTotal.Name = "txtCartTotal";
            txtCartTotal.ReadOnly = true;
            txtCartTotal.Size = new Size(206, 39);
            txtCartTotal.TabIndex = 65;
            // 
            // lbCartTotal
            // 
            lbCartTotal.AutoSize = true;
            lbCartTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbCartTotal.Location = new Point(25, 360);
            lbCartTotal.Margin = new Padding(2, 0, 2, 0);
            lbCartTotal.Name = "lbCartTotal";
            lbCartTotal.Size = new Size(99, 32);
            lbCartTotal.TabIndex = 64;
            lbCartTotal.Text = "TOTAL: ";
            // 
            // cbCartSorting
            // 
            cbCartSorting.BackColor = Color.White;
            cbCartSorting.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCartSorting.FormattingEnabled = true;
            cbCartSorting.Items.AddRange(new object[] { "Sort by", "Price asc", "Price desc" });
            cbCartSorting.Location = new Point(27, 289);
            cbCartSorting.Name = "cbCartSorting";
            cbCartSorting.Size = new Size(290, 28);
            cbCartSorting.TabIndex = 62;
            cbCartSorting.SelectedIndexChanged += cbCartSorting_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(25, 269);
            label17.Name = "label17";
            label17.Size = new Size(57, 20);
            label17.TabIndex = 63;
            label17.Text = "Sorting";
            // 
            // cbCartFilterCategory
            // 
            cbCartFilterCategory.BackColor = Color.White;
            cbCartFilterCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCartFilterCategory.FormattingEnabled = true;
            cbCartFilterCategory.Items.AddRange(new object[] { "Select the category" });
            cbCartFilterCategory.Location = new Point(27, 217);
            cbCartFilterCategory.Name = "cbCartFilterCategory";
            cbCartFilterCategory.Size = new Size(290, 28);
            cbCartFilterCategory.TabIndex = 57;
            cbCartFilterCategory.SelectedIndexChanged += cbCartFilterCategory_SelectedIndexChanged;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.LemonChiffon;
            btnCheckout.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCheckout.Location = new Point(76, 517);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(174, 76);
            btnCheckout.TabIndex = 58;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(25, 197);
            label18.Name = "label18";
            label18.Size = new Size(69, 20);
            label18.TabIndex = 61;
            label18.Text = "Category";
            // 
            // txtCartFilterName
            // 
            txtCartFilterName.BackColor = Color.White;
            txtCartFilterName.Location = new Point(27, 149);
            txtCartFilterName.Name = "txtCartFilterName";
            txtCartFilterName.Size = new Size(290, 27);
            txtCartFilterName.TabIndex = 55;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(25, 127);
            label19.Name = "label19";
            label19.Size = new Size(104, 20);
            label19.TabIndex = 60;
            label19.Text = "Product Name";
            // 
            // btnCartReset
            // 
            btnCartReset.Location = new Point(192, 44);
            btnCartReset.Name = "btnCartReset";
            btnCartReset.Size = new Size(114, 31);
            btnCartReset.TabIndex = 59;
            btnCartReset.Text = "Reset";
            btnCartReset.UseVisualStyleBackColor = true;
            btnCartReset.Click += btnCartReset_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(27, 44);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(142, 31);
            button2.TabIndex = 56;
            button2.Text = "Auto Filting";
            button2.UseVisualStyleBackColor = true;
            // 
            // tabMyProfile
            // 
            tabMyProfile.Controls.Add(phonedup);
            tabMyProfile.Controls.Add(emaildup);
            tabMyProfile.Controls.Add(pbCustomerAvatar);
            tabMyProfile.Controls.Add(btnSave);
            tabMyProfile.Controls.Add(btnEdit);
            tabMyProfile.Controls.Add(txtAddress);
            tabMyProfile.Controls.Add(txtYob);
            tabMyProfile.Controls.Add(txtPhone);
            tabMyProfile.Controls.Add(txtGender);
            tabMyProfile.Controls.Add(txtName);
            tabMyProfile.Controls.Add(txtRole);
            tabMyProfile.Controls.Add(txtEmail);
            tabMyProfile.Controls.Add(txtUserName);
            tabMyProfile.Controls.Add(label31);
            tabMyProfile.Controls.Add(label30);
            tabMyProfile.Controls.Add(label29);
            tabMyProfile.Controls.Add(label27);
            tabMyProfile.Controls.Add(label23);
            tabMyProfile.Controls.Add(label22);
            tabMyProfile.Controls.Add(label21);
            tabMyProfile.Controls.Add(label20);
            tabMyProfile.Controls.Add(lbUserName);
            tabMyProfile.Location = new Point(4, 29);
            tabMyProfile.Name = "tabMyProfile";
            tabMyProfile.Padding = new Padding(3);
            tabMyProfile.Size = new Size(1436, 672);
            tabMyProfile.TabIndex = 2;
            tabMyProfile.Text = "My Profile";
            tabMyProfile.UseVisualStyleBackColor = true;
            tabMyProfile.Click += tabMyProfile_Click;
            // 
            // phonedup
            // 
            phonedup.AutoSize = true;
            phonedup.ForeColor = Color.Red;
            phonedup.Location = new Point(725, 135);
            phonedup.Name = "phonedup";
            phonedup.Size = new Size(148, 20);
            phonedup.TabIndex = 114;
            phonedup.Text = "Phone has been used";
            phonedup.Visible = false;
            // 
            // emaildup
            // 
            emaildup.AutoSize = true;
            emaildup.ForeColor = Color.Red;
            emaildup.Location = new Point(253, 219);
            emaildup.Name = "emaildup";
            emaildup.Size = new Size(144, 20);
            emaildup.TabIndex = 113;
            emaildup.Text = "Email has been used";
            emaildup.Visible = false;
            // 
            // pbCustomerAvatar
            // 
            pbCustomerAvatar.Location = new Point(1106, 118);
            pbCustomerAvatar.Name = "pbCustomerAvatar";
            pbCustomerAvatar.Size = new Size(272, 323);
            pbCustomerAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pbCustomerAvatar.TabIndex = 112;
            pbCustomerAvatar.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(769, 546);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 51);
            btnSave.TabIndex = 111;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(521, 546);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(164, 51);
            btnEdit.TabIndex = 110;
            btnEdit.Text = "Edit Profile";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(691, 324);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(350, 84);
            txtAddress.TabIndex = 109;
            // 
            // txtYob
            // 
            txtYob.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtYob.Location = new Point(691, 236);
            txtYob.Name = "txtYob";
            txtYob.ReadOnly = true;
            txtYob.Size = new Size(199, 38);
            txtYob.TabIndex = 108;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(691, 158);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(199, 38);
            txtPhone.TabIndex = 107;
            // 
            // txtGender
            // 
            txtGender.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtGender.Location = new Point(227, 464);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(199, 38);
            txtGender.TabIndex = 106;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(227, 383);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(199, 38);
            txtName.TabIndex = 105;
            // 
            // txtRole
            // 
            txtRole.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtRole.Location = new Point(227, 318);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(199, 38);
            txtRole.TabIndex = 104;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(227, 242);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(199, 38);
            txtEmail.TabIndex = 103;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(227, 158);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(199, 38);
            txtUserName.TabIndex = 102;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label31.Location = new Point(521, 324);
            label31.Name = "label31";
            label31.Size = new Size(97, 31);
            label31.TabIndex = 101;
            label31.Text = "Address";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(521, 243);
            label30.Name = "label30";
            label30.Size = new Size(137, 31);
            label30.TabIndex = 100;
            label30.Text = "Year of Birth";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label29.Location = new Point(521, 166);
            label29.Name = "label29";
            label29.Size = new Size(78, 31);
            label29.TabIndex = 99;
            label29.Text = "Phone";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(79, 471);
            label27.Name = "label27";
            label27.Size = new Size(89, 31);
            label27.TabIndex = 98;
            label27.Text = "Gender";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(79, 390);
            label23.Name = "label23";
            label23.Size = new Size(75, 31);
            label23.TabIndex = 97;
            label23.Text = "Name";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(79, 324);
            label22.Name = "label22";
            label22.Size = new Size(58, 31);
            label22.TabIndex = 96;
            label22.Text = "Role";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(79, 246);
            label21.Name = "label21";
            label21.Size = new Size(70, 31);
            label21.TabIndex = 95;
            label21.Text = "Email";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(79, 166);
            label20.Name = "label20";
            label20.Size = new Size(127, 31);
            label20.TabIndex = 94;
            label20.Text = "User Name";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbUserName.Location = new Point(525, 76);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(259, 41);
            lbUserName.TabIndex = 93;
            lbUserName.Text = "User Information";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 709);
            Controls.Add(tabControllCustomer);
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            tabControllCustomer.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            gbSelect.ResumeLayout(false);
            gbSelect.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            groupBoxProduct.ResumeLayout(false);
            groupBoxProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductAvatar).EndInit();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarts).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCartAvatar).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            tabMyProfile.ResumeLayout(false);
            tabMyProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCustomerAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControllCustomer;
        private TabPage tabHome;
        private TabPage tabPage2;
        private GroupBox groupBoxProduct;
        private Button btnAddToCart;
        private TextBox txtAvailable;
        private Label label4;
        private TextBox txtPrice;
        private Label label3;
        private Label lbProductName;
        private PictureBox pbProductAvatar;
        private GroupBox groupBoxSearch;
        private ComboBox cbProductSort;
        private ComboBox cbProductCategory2;
        private TextBox txtProductNameSearch;
        private Label label1;
        private Button btnReset;
        private Button btnSearch;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox txtDesc;
        private GroupBox gbSelect;
        private TextBox txtCurrentIndex;
        private Button btnNext;
        private Button btnBack;
        private Label label6;
        private Label label5;
        private DataGridView dgvProducts;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Button btnCartDelete;
        private Button btnDecrease;
        private Button btnIncrease;
        private TextBox txtCartQuantity;
        private Label label28;
        private TextBox txtCartAvailable;
        private TextBox txtCartPrice;
        private GroupBox groupBox9;
        private TextBox txtCartDescription;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label lbCartName;
        private PictureBox pbCartAvatar;
        private TextBox txtCartTotal;
        private Label lbCartTotal;
        private ComboBox cbCartSorting;
        private Label label17;
        private ComboBox cbCartFilterCategory;
        private Button btnCheckout;
        private Label label18;
        private TextBox txtCartFilterName;
        private Label label19;
        private Button btnCartReset;
        private Button button2;
        private GroupBox groupBox7;
        private DataGridView dgvCarts;
        private DataGridViewCheckBoxColumn Check;
        private TabPage tabMyProfile;
        private Label phonedup;
        private Label emaildup;
        private PictureBox pbCustomerAvatar;
        private Button btnSave;
        private Button btnEdit;
        private TextBox txtAddress;
        private TextBox txtYob;
        private TextBox txtPhone;
        private TextBox txtGender;
        private TextBox txtName;
        private TextBox txtRole;
        private TextBox txtEmail;
        private TextBox txtUserName;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label27;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label lbUserName;
    }
}