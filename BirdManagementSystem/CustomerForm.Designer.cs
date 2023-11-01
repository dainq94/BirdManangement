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
            btnAddToCart = new Button();
            txtAvailable = new TextBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            lbProductName = new Label();
            pbProductAvatar = new PictureBox();
            groupBoxSearch = new GroupBox();
            groupBox2 = new GroupBox();
            txtUnitsInStockMaxSearch = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtUnitsInStockMinSearch = new TextBox();
            groupBox1 = new GroupBox();
            label9 = new Label();
            txtUnitPriceMaxSearch = new TextBox();
            txtUnitPriceMinSearch = new TextBox();
            label10 = new Label();
            label6 = new Label();
            label5 = new Label();
            cbProductSort = new ComboBox();
            cbProductCategory2 = new ComboBox();
            txtProductNameSearch = new TextBox();
            label1 = new Label();
            btnReset = new Button();
            btnSearch = new Button();
            tabPage2 = new TabPage();
            tabControllCustomer.SuspendLayout();
            tabHome.SuspendLayout();
            gbSelect.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            groupBoxProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductAvatar).BeginInit();
            groupBoxSearch.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControllCustomer
            // 
            tabControllCustomer.Controls.Add(tabHome);
            tabControllCustomer.Controls.Add(tabPage2);
            tabControllCustomer.Location = new Point(-7, 2);
            tabControllCustomer.Name = "tabControllCustomer";
            tabControllCustomer.SelectedIndex = 0;
            tabControllCustomer.Size = new Size(1440, 703);
            tabControllCustomer.TabIndex = 0;
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
            tabHome.Size = new Size(1432, 670);
            tabHome.TabIndex = 0;
            tabHome.Text = "Home";
            tabHome.UseVisualStyleBackColor = true;
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
            dgvProducts.Location = new Point(6, 40);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.Size = new Size(1046, 265);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // groupBoxProduct
            // 
            groupBoxProduct.Controls.Add(groupBox4);
            groupBoxProduct.Controls.Add(txtDesc);
            groupBoxProduct.Controls.Add(btnAddToCart);
            groupBoxProduct.Controls.Add(txtAvailable);
            groupBoxProduct.Controls.Add(label4);
            groupBoxProduct.Controls.Add(txtPrice);
            groupBoxProduct.Controls.Add(label3);
            groupBoxProduct.Controls.Add(lbProductName);
            groupBoxProduct.Controls.Add(pbProductAvatar);
            groupBoxProduct.Location = new Point(355, 0);
            groupBoxProduct.Name = "groupBoxProduct";
            groupBoxProduct.Size = new Size(1082, 252);
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
            txtDesc.Location = new Point(211, 158);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.ReadOnly = true;
            txtDesc.Size = new Size(834, 83);
            txtDesc.TabIndex = 7;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(850, 44);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(135, 38);
            btnAddToCart.TabIndex = 6;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // txtAvailable
            // 
            txtAvailable.Location = new Point(517, 114);
            txtAvailable.Name = "txtAvailable";
            txtAvailable.ReadOnly = true;
            txtAvailable.Size = new Size(125, 27);
            txtAvailable.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 117);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 4;
            label4.Text = "Available";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(267, 114);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 119);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbProductName.Location = new Point(211, 44);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(206, 38);
            lbProductName.TabIndex = 1;
            lbProductName.Text = "Product Name";
            // 
            // pbProductAvatar
            // 
            pbProductAvatar.Location = new Point(19, 18);
            pbProductAvatar.Name = "pbProductAvatar";
            pbProductAvatar.Size = new Size(165, 223);
            pbProductAvatar.TabIndex = 0;
            pbProductAvatar.TabStop = false;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Controls.Add(groupBox2);
            groupBoxSearch.Controls.Add(groupBox1);
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
            groupBoxSearch.Size = new Size(349, 651);
            groupBoxSearch.TabIndex = 0;
            groupBoxSearch.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtUnitsInStockMaxSearch);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtUnitsInStockMinSearch);
            groupBox2.Location = new Point(6, 470);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(311, 125);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Units In Stock";
            // 
            // txtUnitsInStockMaxSearch
            // 
            txtUnitsInStockMaxSearch.Location = new Point(152, 84);
            txtUnitsInStockMaxSearch.Name = "txtUnitsInStockMaxSearch";
            txtUnitsInStockMaxSearch.Size = new Size(138, 27);
            txtUnitsInStockMaxSearch.TabIndex = 1;
            txtUnitsInStockMaxSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 87);
            label7.Name = "label7";
            label7.Size = new Size(130, 20);
            label7.TabIndex = 2;
            label7.Text = "Units In Stock Max";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 45);
            label8.Name = "label8";
            label8.Size = new Size(127, 20);
            label8.TabIndex = 0;
            label8.Text = "Units In Stock Min";
            // 
            // txtUnitsInStockMinSearch
            // 
            txtUnitsInStockMinSearch.Location = new Point(152, 45);
            txtUnitsInStockMinSearch.Name = "txtUnitsInStockMinSearch";
            txtUnitsInStockMinSearch.Size = new Size(138, 27);
            txtUnitsInStockMinSearch.TabIndex = 0;
            txtUnitsInStockMinSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtUnitPriceMaxSearch);
            groupBox1.Controls.Add(txtUnitPriceMinSearch);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new Point(6, 317);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 125);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Unit Price";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 45);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 0;
            label9.Text = "Unit Price Min";
            // 
            // txtUnitPriceMaxSearch
            // 
            txtUnitPriceMaxSearch.Location = new Point(152, 87);
            txtUnitPriceMaxSearch.Name = "txtUnitPriceMaxSearch";
            txtUnitPriceMaxSearch.Size = new Size(138, 27);
            txtUnitPriceMaxSearch.TabIndex = 1;
            txtUnitPriceMaxSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUnitPriceMinSearch
            // 
            txtUnitPriceMinSearch.Location = new Point(152, 45);
            txtUnitPriceMinSearch.Name = "txtUnitPriceMinSearch";
            txtUnitPriceMinSearch.Size = new Size(138, 27);
            txtUnitPriceMinSearch.TabIndex = 0;
            txtUnitPriceMinSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 87);
            label10.Name = "label10";
            label10.Size = new Size(104, 20);
            label10.TabIndex = 2;
            label10.Text = "Unit Price Max";
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
            txtProductNameSearch.Location = new Point(34, 140);
            txtProductNameSearch.Name = "txtProductNameSearch";
            txtProductNameSearch.Size = new Size(250, 27);
            txtProductNameSearch.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 117);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 2;
            label1.Text = "Product Name";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(136, 44);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(18, 44);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Auto Filting";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1432, 670);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox2;
        private TextBox txtUnitsInStockMaxSearch;
        private Label label7;
        private Label label8;
        private TextBox txtUnitsInStockMinSearch;
        private GroupBox groupBox1;
        private Label label9;
        private TextBox txtUnitPriceMaxSearch;
        private TextBox txtUnitPriceMinSearch;
        private Label label10;
    }
}