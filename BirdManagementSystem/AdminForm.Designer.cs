namespace Bird.APP
{
    partial class AdminForm
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
            tabcontrol1 = new TabControl();
            tab_manageaccounts = new TabPage();
            lb_totaluser = new Label();
            label17 = new Label();
            btn_closeuser = new Button();
            btn_block = new Button();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            txt_role = new TextBox();
            txt_address = new TextBox();
            txt_gender = new TextBox();
            txt_yob = new TextBox();
            txt_phone = new TextBox();
            txt_email = new TextBox();
            txt_password = new TextBox();
            txt_username = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            lb_nameuser = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            cb_userstatus = new ComboBox();
            txt_searchuser = new TextBox();
            label1 = new Label();
            dtg_user = new DataGridView();
            tab_manageproducts = new TabPage();
            label21 = new Label();
            lb_totalproduct = new Label();
            Btn_closeproduct = new Button();
            btn_deleteproduct = new Button();
            btn_addproduct = new Button();
            btn_editproduct = new Button();
            dtg_product = new DataGridView();
            gb_productname = new GroupBox();
            label16 = new Label();
            txt_productname = new TextBox();
            label20 = new Label();
            cb_category = new ComboBox();
            label19 = new Label();
            txt_image = new TextBox();
            txt_id = new TextBox();
            label18 = new Label();
            label12 = new Label();
            txt_description = new TextBox();
            txt_quantity = new TextBox();
            txt_price = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            lb_nameproduct = new Label();
            pb_productimage = new PictureBox();
            groupBox3 = new GroupBox();
            cb_categoryproduct = new ComboBox();
            label22 = new Label();
            txt_searchproduct = new TextBox();
            label11 = new Label();
            tabPage3 = new TabPage();
            btn_clearcategory = new Button();
            btn_deletecategory = new Button();
            btn_closecategory = new Button();
            label27 = new Label();
            label26 = new Label();
            btn_savecategory = new Button();
            txt_categoryname = new TextBox();
            txt_categoryid = new TextBox();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            dtg_category = new DataGridView();
            tabPage4 = new TabPage();
            pvChart = new OxyPlot.WindowsForms.PlotView();
            dtg_order = new DataGridView();
            groupBox4 = new GroupBox();
            label28 = new Label();
            groupBox8 = new GroupBox();
            txt_ordercancel = new TextBox();
            label32 = new Label();
            groupBox7 = new GroupBox();
            txt_ordered = new TextBox();
            label31 = new Label();
            groupBox6 = new GroupBox();
            txt_ordersuccessful = new TextBox();
            label30 = new Label();
            groupBox5 = new GroupBox();
            txt_allorder = new TextBox();
            label29 = new Label();
            tabcontrol1.SuspendLayout();
            tab_manageaccounts.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_user).BeginInit();
            tab_manageproducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_product).BeginInit();
            gb_productname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_productimage).BeginInit();
            groupBox3.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_category).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_order).BeginInit();
            groupBox4.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // tabcontrol1
            // 
            tabcontrol1.Controls.Add(tab_manageaccounts);
            tabcontrol1.Controls.Add(tab_manageproducts);
            tabcontrol1.Controls.Add(tabPage3);
            tabcontrol1.Controls.Add(tabPage4);
            tabcontrol1.Location = new Point(2, 2);
            tabcontrol1.Name = "tabcontrol1";
            tabcontrol1.SelectedIndex = 0;
            tabcontrol1.Size = new Size(1240, 693);
            tabcontrol1.TabIndex = 0;
            // 
            // tab_manageaccounts
            // 
            tab_manageaccounts.Controls.Add(lb_totaluser);
            tab_manageaccounts.Controls.Add(label17);
            tab_manageaccounts.Controls.Add(btn_closeuser);
            tab_manageaccounts.Controls.Add(btn_block);
            tab_manageaccounts.Controls.Add(groupBox2);
            tab_manageaccounts.Controls.Add(groupBox1);
            tab_manageaccounts.Controls.Add(dtg_user);
            tab_manageaccounts.Location = new Point(4, 29);
            tab_manageaccounts.Name = "tab_manageaccounts";
            tab_manageaccounts.Padding = new Padding(3);
            tab_manageaccounts.Size = new Size(1232, 660);
            tab_manageaccounts.TabIndex = 0;
            tab_manageaccounts.Text = "Manage Accounts";
            tab_manageaccounts.UseVisualStyleBackColor = true;
            tab_manageaccounts.Click += tab_manageaccounts_Click;
            // 
            // lb_totaluser
            // 
            lb_totaluser.AutoSize = true;
            lb_totaluser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_totaluser.Location = new Point(3, 377);
            lb_totaluser.Name = "lb_totaluser";
            lb_totaluser.Size = new Size(135, 28);
            lb_totaluser.TabIndex = 8;
            lb_totaluser.Text = "Total records";
            // 
            // label17
            // 
            label17.BackColor = Color.Blue;
            label17.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Transparent;
            label17.Location = new Point(-4, 0);
            label17.Name = "label17";
            label17.Size = new Size(1236, 40);
            label17.TabIndex = 7;
            label17.Text = "MANAGE ACCOUNTS";
            // 
            // btn_closeuser
            // 
            btn_closeuser.Location = new Point(1138, 368);
            btn_closeuser.Name = "btn_closeuser";
            btn_closeuser.Size = new Size(83, 29);
            btn_closeuser.TabIndex = 6;
            btn_closeuser.Text = "Close";
            btn_closeuser.UseVisualStyleBackColor = true;
            btn_closeuser.Click += btn_closeuser_Click;
            // 
            // btn_block
            // 
            btn_block.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_block.ForeColor = Color.Red;
            btn_block.Location = new Point(1001, 368);
            btn_block.Name = "btn_block";
            btn_block.Size = new Size(121, 29);
            btn_block.TabIndex = 5;
            btn_block.Text = "BLOCK";
            btn_block.UseVisualStyleBackColor = true;
            btn_block.Click += btn_blockuser_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Silver;
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(txt_role);
            groupBox2.Controls.Add(txt_address);
            groupBox2.Controls.Add(txt_gender);
            groupBox2.Controls.Add(txt_yob);
            groupBox2.Controls.Add(txt_phone);
            groupBox2.Controls.Add(txt_email);
            groupBox2.Controls.Add(txt_password);
            groupBox2.Controls.Add(txt_username);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(lb_nameuser);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(333, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(900, 288);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin cá nhân";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(17, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // txt_role
            // 
            txt_role.Location = new Point(718, 95);
            txt_role.Name = "txt_role";
            txt_role.Size = new Size(177, 27);
            txt_role.TabIndex = 19;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(718, 212);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(177, 53);
            txt_address.TabIndex = 18;
            // 
            // txt_gender
            // 
            txt_gender.Location = new Point(718, 155);
            txt_gender.Name = "txt_gender";
            txt_gender.Size = new Size(177, 27);
            txt_gender.TabIndex = 17;
            // 
            // txt_yob
            // 
            txt_yob.Location = new Point(718, 37);
            txt_yob.Name = "txt_yob";
            txt_yob.Size = new Size(176, 27);
            txt_yob.TabIndex = 16;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(390, 155);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(195, 27);
            txt_phone.TabIndex = 15;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(390, 212);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(195, 27);
            txt_email.TabIndex = 14;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(390, 95);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(195, 27);
            txt_password.TabIndex = 12;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(390, 37);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(195, 27);
            txt_username.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(657, 98);
            label10.Name = "label10";
            label10.Size = new Size(39, 20);
            label10.TabIndex = 8;
            label10.Text = "Role";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(657, 219);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 7;
            label9.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(657, 162);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 6;
            label8.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(657, 40);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 5;
            label7.Text = "YOB";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(309, 162);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 4;
            label6.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(309, 219);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 3;
            label5.Text = "Email";
            // 
            // lb_nameuser
            // 
            lb_nameuser.AutoSize = true;
            lb_nameuser.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_nameuser.Location = new Point(56, 230);
            lb_nameuser.Name = "lb_nameuser";
            lb_nameuser.Size = new Size(135, 25);
            lb_nameuser.TabIndex = 2;
            lb_nameuser.Text = "User FullName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 98);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 44);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cb_userstatus);
            groupBox1.Controls.Add(txt_searchuser);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 288);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 127);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 6;
            label4.Text = "Status";
            // 
            // cb_userstatus
            // 
            cb_userstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_userstatus.FormattingEnabled = true;
            cb_userstatus.Items.AddRange(new object[] { "ALL", "ACTIVE", "BANNED" });
            cb_userstatus.Location = new Point(6, 159);
            cb_userstatus.Name = "cb_userstatus";
            cb_userstatus.Size = new Size(216, 28);
            cb_userstatus.TabIndex = 5;
            cb_userstatus.SelectedIndexChanged += cb_userstatus_SelectedIndexChanged;
            // 
            // txt_searchuser
            // 
            txt_searchuser.Location = new Point(6, 63);
            txt_searchuser.Name = "txt_searchuser";
            txt_searchuser.Size = new Size(312, 27);
            txt_searchuser.TabIndex = 1;
            txt_searchuser.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "By Name:";
            // 
            // dtg_user
            // 
            dtg_user.AllowUserToAddRows = false;
            dtg_user.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_user.Location = new Point(3, 416);
            dtg_user.Name = "dtg_user";
            dtg_user.RowHeadersWidth = 51;
            dtg_user.RowTemplate.Height = 29;
            dtg_user.Size = new Size(1230, 230);
            dtg_user.TabIndex = 0;
            dtg_user.CellClick += dtg_user_CellClick;
            // 
            // tab_manageproducts
            // 
            tab_manageproducts.Controls.Add(label21);
            tab_manageproducts.Controls.Add(lb_totalproduct);
            tab_manageproducts.Controls.Add(Btn_closeproduct);
            tab_manageproducts.Controls.Add(btn_deleteproduct);
            tab_manageproducts.Controls.Add(btn_addproduct);
            tab_manageproducts.Controls.Add(btn_editproduct);
            tab_manageproducts.Controls.Add(dtg_product);
            tab_manageproducts.Controls.Add(gb_productname);
            tab_manageproducts.Controls.Add(groupBox3);
            tab_manageproducts.Location = new Point(4, 29);
            tab_manageproducts.Name = "tab_manageproducts";
            tab_manageproducts.Padding = new Padding(3);
            tab_manageproducts.Size = new Size(1232, 660);
            tab_manageproducts.TabIndex = 1;
            tab_manageproducts.Text = "Manage Products";
            tab_manageproducts.UseVisualStyleBackColor = true;
            tab_manageproducts.Click += tabPage2_Click;
            // 
            // label21
            // 
            label21.BackColor = Color.Blue;
            label21.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.Transparent;
            label21.Location = new Point(3, 0);
            label21.Name = "label21";
            label21.Size = new Size(1233, 35);
            label21.TabIndex = 9;
            label21.Text = "MANAGE PRODUCTS";
            // 
            // lb_totalproduct
            // 
            lb_totalproduct.AutoSize = true;
            lb_totalproduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_totalproduct.Location = new Point(16, 348);
            lb_totalproduct.Name = "lb_totalproduct";
            lb_totalproduct.Size = new Size(135, 28);
            lb_totalproduct.TabIndex = 8;
            lb_totalproduct.Text = "Total records";
            // 
            // Btn_closeproduct
            // 
            Btn_closeproduct.BackColor = Color.FromArgb(255, 128, 128);
            Btn_closeproduct.Location = new Point(1102, 594);
            Btn_closeproduct.Name = "Btn_closeproduct";
            Btn_closeproduct.Size = new Size(124, 51);
            Btn_closeproduct.TabIndex = 7;
            Btn_closeproduct.Text = "Close";
            Btn_closeproduct.UseVisualStyleBackColor = false;
            Btn_closeproduct.Click += Btn_closeproduct_Click;
            // 
            // btn_deleteproduct
            // 
            btn_deleteproduct.BackColor = Color.FromArgb(255, 128, 128);
            btn_deleteproduct.Location = new Point(1102, 528);
            btn_deleteproduct.Name = "btn_deleteproduct";
            btn_deleteproduct.Size = new Size(124, 51);
            btn_deleteproduct.TabIndex = 7;
            btn_deleteproduct.Text = "Delete";
            btn_deleteproduct.UseVisualStyleBackColor = false;
            btn_deleteproduct.Click += btn_deleteproduct_Click;
            // 
            // btn_addproduct
            // 
            btn_addproduct.BackColor = Color.FromArgb(255, 128, 128);
            btn_addproduct.Location = new Point(1103, 452);
            btn_addproduct.Name = "btn_addproduct";
            btn_addproduct.Size = new Size(123, 51);
            btn_addproduct.TabIndex = 6;
            btn_addproduct.Text = "Add";
            btn_addproduct.UseVisualStyleBackColor = false;
            btn_addproduct.Click += btn_addproduct_Click;
            // 
            // btn_editproduct
            // 
            btn_editproduct.BackColor = Color.FromArgb(255, 128, 128);
            btn_editproduct.Location = new Point(1102, 382);
            btn_editproduct.Name = "btn_editproduct";
            btn_editproduct.Size = new Size(124, 52);
            btn_editproduct.TabIndex = 5;
            btn_editproduct.Text = "Edit";
            btn_editproduct.UseVisualStyleBackColor = false;
            btn_editproduct.Click += btn_editproduct_Click;
            // 
            // dtg_product
            // 
            dtg_product.AllowUserToAddRows = false;
            dtg_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_product.Location = new Point(16, 382);
            dtg_product.Name = "dtg_product";
            dtg_product.RowHeadersWidth = 51;
            dtg_product.RowTemplate.Height = 29;
            dtg_product.Size = new Size(1080, 263);
            dtg_product.TabIndex = 4;
            dtg_product.CellClick += dtg_product_CellClick;
            dtg_product.CellContentClick += dtg_product_CellContentClick;
            // 
            // gb_productname
            // 
            gb_productname.BackColor = Color.FromArgb(255, 224, 192);
            gb_productname.Controls.Add(label16);
            gb_productname.Controls.Add(txt_productname);
            gb_productname.Controls.Add(label20);
            gb_productname.Controls.Add(cb_category);
            gb_productname.Controls.Add(label19);
            gb_productname.Controls.Add(txt_image);
            gb_productname.Controls.Add(txt_id);
            gb_productname.Controls.Add(label18);
            gb_productname.Controls.Add(label12);
            gb_productname.Controls.Add(txt_description);
            gb_productname.Controls.Add(txt_quantity);
            gb_productname.Controls.Add(txt_price);
            gb_productname.Controls.Add(label15);
            gb_productname.Controls.Add(label14);
            gb_productname.Controls.Add(label13);
            gb_productname.Controls.Add(lb_nameproduct);
            gb_productname.Controls.Add(pb_productimage);
            gb_productname.Location = new Point(344, 47);
            gb_productname.Name = "gb_productname";
            gb_productname.Size = new Size(888, 329);
            gb_productname.TabIndex = 3;
            gb_productname.TabStop = false;
            gb_productname.Text = "Thông tin sản phẩm";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(557, 158);
            label16.Name = "label16";
            label16.Size = new Size(51, 20);
            label16.TabIndex = 19;
            label16.Text = "Image";
            // 
            // txt_productname
            // 
            txt_productname.Location = new Point(630, 62);
            txt_productname.Name = "txt_productname";
            txt_productname.Size = new Size(247, 27);
            txt_productname.TabIndex = 18;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(557, 65);
            label20.Name = "label20";
            label20.Size = new Size(49, 20);
            label20.TabIndex = 17;
            label20.Text = "Name";
            // 
            // cb_category
            // 
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(630, 111);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(247, 28);
            cb_category.TabIndex = 16;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(557, 115);
            label19.Name = "label19";
            label19.Size = new Size(69, 20);
            label19.TabIndex = 15;
            label19.Text = "Category";
            // 
            // txt_image
            // 
            txt_image.Location = new Point(630, 155);
            txt_image.Multiline = true;
            txt_image.Name = "txt_image";
            txt_image.Size = new Size(247, 97);
            txt_image.TabIndex = 14;
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(443, 62);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(82, 27);
            txt_id.TabIndex = 12;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(372, 65);
            label18.Name = "label18";
            label18.Size = new Size(24, 20);
            label18.TabIndex = 11;
            label18.Text = "ID";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(372, 232);
            label12.Name = "label12";
            label12.Size = new Size(85, 20);
            label12.TabIndex = 8;
            label12.Text = "Description";
            // 
            // txt_description
            // 
            txt_description.Location = new Point(372, 258);
            txt_description.Multiline = true;
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(505, 65);
            txt_description.TabIndex = 0;
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(443, 158);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(82, 27);
            txt_quantity.TabIndex = 7;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(443, 112);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(82, 27);
            txt_price.TabIndex = 6;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(237, 173);
            label15.Name = "label15";
            label15.Size = new Size(0, 20);
            label15.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(372, 158);
            label14.Name = "label14";
            label14.Size = new Size(65, 20);
            label14.TabIndex = 3;
            label14.Text = "Quantity";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(372, 115);
            label13.Name = "label13";
            label13.Size = new Size(44, 20);
            label13.TabIndex = 2;
            label13.Text = "Price:";
            // 
            // lb_nameproduct
            // 
            lb_nameproduct.AutoSize = true;
            lb_nameproduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_nameproduct.Location = new Point(358, 20);
            lb_nameproduct.Name = "lb_nameproduct";
            lb_nameproduct.Size = new Size(148, 28);
            lb_nameproduct.TabIndex = 1;
            lb_nameproduct.Text = "Product Name";
            // 
            // pb_productimage
            // 
            pb_productimage.Location = new Point(18, 28);
            pb_productimage.Name = "pb_productimage";
            pb_productimage.Size = new Size(316, 227);
            pb_productimage.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_productimage.TabIndex = 0;
            pb_productimage.TabStop = false;
            pb_productimage.Click += pb_productimage_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(255, 255, 192);
            groupBox3.Controls.Add(cb_categoryproduct);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(txt_searchproduct);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(16, 47);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(322, 298);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            // 
            // cb_categoryproduct
            // 
            cb_categoryproduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_categoryproduct.FormattingEnabled = true;
            cb_categoryproduct.Location = new Point(6, 154);
            cb_categoryproduct.Name = "cb_categoryproduct";
            cb_categoryproduct.Size = new Size(296, 28);
            cb_categoryproduct.TabIndex = 4;
            cb_categoryproduct.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(10, 131);
            label22.Name = "label22";
            label22.Size = new Size(145, 20);
            label22.TabIndex = 3;
            label22.Text = "Theo loại sản phẩm";
            // 
            // txt_searchproduct
            // 
            txt_searchproduct.Location = new Point(10, 62);
            txt_searchproduct.Name = "txt_searchproduct";
            txt_searchproduct.Size = new Size(292, 27);
            txt_searchproduct.TabIndex = 1;
            txt_searchproduct.TextChanged += txt_searchproduct_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(10, 32);
            label11.Name = "label11";
            label11.Size = new Size(110, 20);
            label11.TabIndex = 0;
            label11.Text = "Tên sản phẩm:";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(255, 224, 192);
            tabPage3.Controls.Add(btn_clearcategory);
            tabPage3.Controls.Add(btn_deletecategory);
            tabPage3.Controls.Add(btn_closecategory);
            tabPage3.Controls.Add(label27);
            tabPage3.Controls.Add(label26);
            tabPage3.Controls.Add(btn_savecategory);
            tabPage3.Controls.Add(txt_categoryname);
            tabPage3.Controls.Add(txt_categoryid);
            tabPage3.Controls.Add(label25);
            tabPage3.Controls.Add(label24);
            tabPage3.Controls.Add(label23);
            tabPage3.Controls.Add(dtg_category);
            tabPage3.ForeColor = Color.Black;
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1232, 660);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Manage Categories";
            // 
            // btn_clearcategory
            // 
            btn_clearcategory.Location = new Point(501, 380);
            btn_clearcategory.Name = "btn_clearcategory";
            btn_clearcategory.Size = new Size(113, 43);
            btn_clearcategory.TabIndex = 12;
            btn_clearcategory.Text = "Clear";
            btn_clearcategory.UseVisualStyleBackColor = true;
            btn_clearcategory.Click += btn_clearcategory_Click;
            // 
            // btn_deletecategory
            // 
            btn_deletecategory.Location = new Point(891, 380);
            btn_deletecategory.Name = "btn_deletecategory";
            btn_deletecategory.Size = new Size(113, 43);
            btn_deletecategory.TabIndex = 11;
            btn_deletecategory.Text = "Detele";
            btn_deletecategory.UseVisualStyleBackColor = true;
            btn_deletecategory.Click += btn_deletecategory_Click;
            // 
            // btn_closecategory
            // 
            btn_closecategory.Location = new Point(1081, 614);
            btn_closecategory.Name = "btn_closecategory";
            btn_closecategory.Size = new Size(140, 36);
            btn_closecategory.TabIndex = 9;
            btn_closecategory.Text = "Close";
            btn_closecategory.UseVisualStyleBackColor = true;
            btn_closecategory.Click += btn_closecategory_Click;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label27.Location = new Point(65, 94);
            label27.Name = "label27";
            label27.Size = new Size(182, 46);
            label27.TabIndex = 8;
            label27.Text = "Danh sách";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label26.Location = new Point(593, 94);
            label26.Name = "label26";
            label26.Size = new Size(329, 46);
            label26.TabIndex = 7;
            label26.Text = "Thêm category mới";
            // 
            // btn_savecategory
            // 
            btn_savecategory.Location = new Point(695, 380);
            btn_savecategory.Name = "btn_savecategory";
            btn_savecategory.Size = new Size(113, 43);
            btn_savecategory.TabIndex = 6;
            btn_savecategory.Text = "Save";
            btn_savecategory.UseVisualStyleBackColor = true;
            btn_savecategory.Click += btn_savecategory_Click;
            // 
            // txt_categoryname
            // 
            txt_categoryname.Location = new Point(647, 278);
            txt_categoryname.Name = "txt_categoryname";
            txt_categoryname.Size = new Size(340, 27);
            txt_categoryname.TabIndex = 5;
            // 
            // txt_categoryid
            // 
            txt_categoryid.Location = new Point(641, 169);
            txt_categoryid.Name = "txt_categoryid";
            txt_categoryid.Size = new Size(346, 27);
            txt_categoryid.TabIndex = 4;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label25.Location = new Point(481, 274);
            label25.Name = "label25";
            label25.Size = new Size(154, 28);
            label25.TabIndex = 3;
            label25.Text = "CategoryName";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label24.Location = new Point(481, 165);
            label24.Name = "label24";
            label24.Size = new Size(119, 28);
            label24.TabIndex = 2;
            label24.Text = "CategoryID";
            // 
            // label23
            // 
            label23.BackColor = Color.Blue;
            label23.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.White;
            label23.Location = new Point(0, 0);
            label23.Name = "label23";
            label23.Size = new Size(1232, 46);
            label23.TabIndex = 1;
            label23.Text = "MANAGE CATEGORIES";
            // 
            // dtg_category
            // 
            dtg_category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_category.Location = new Point(3, 191);
            dtg_category.Name = "dtg_category";
            dtg_category.RowHeadersWidth = 51;
            dtg_category.RowTemplate.Height = 29;
            dtg_category.Size = new Size(305, 469);
            dtg_category.TabIndex = 0;
            dtg_category.CellClick += dtg_category_CellClick;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(pvChart);
            tabPage4.Controls.Add(dtg_order);
            tabPage4.Controls.Add(groupBox4);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1232, 660);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Manage Orders";
            tabPage4.UseVisualStyleBackColor = true;
            tabPage4.Click += tabPage4_Click;
            // 
            // pvChart
            // 
            pvChart.Location = new Point(498, 15);
            pvChart.Name = "pvChart";
            pvChart.PanCursor = Cursors.Hand;
            pvChart.Size = new Size(479, 409);
            pvChart.TabIndex = 2;
            pvChart.ZoomHorizontalCursor = Cursors.SizeWE;
            pvChart.ZoomRectangleCursor = Cursors.SizeNWSE;
            pvChart.ZoomVerticalCursor = Cursors.SizeNS;
            pvChart.Click += tabPage4_Click;
            // 
            // dtg_order
            // 
            dtg_order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_order.Location = new Point(259, 443);
            dtg_order.Name = "dtg_order";
            dtg_order.RowHeadersWidth = 51;
            dtg_order.RowTemplate.Height = 29;
            dtg_order.Size = new Size(973, 207);
            dtg_order.TabIndex = 1;
            dtg_order.CellClick += dtg_order_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label28);
            groupBox4.Controls.Add(groupBox8);
            groupBox4.Controls.Add(groupBox7);
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Location = new Point(6, 134);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(247, 516);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            // 
            // label28
            // 
            label28.BackColor = Color.FromArgb(128, 128, 255);
            label28.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label28.Location = new Point(0, 12);
            label28.Name = "label28";
            label28.Size = new Size(245, 38);
            label28.TabIndex = 1;
            label28.Text = "ALL OF ORDER";
            label28.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(txt_ordercancel);
            groupBox8.Controls.Add(label32);
            groupBox8.Location = new Point(18, 423);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(219, 70);
            groupBox8.TabIndex = 0;
            groupBox8.TabStop = false;
            // 
            // txt_ordercancel
            // 
            txt_ordercancel.Enabled = false;
            txt_ordercancel.Location = new Point(127, 20);
            txt_ordercancel.Name = "txt_ordercancel";
            txt_ordercancel.Size = new Size(65, 27);
            txt_ordercancel.TabIndex = 1;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label32.ForeColor = Color.Red;
            label32.Location = new Point(17, 20);
            label32.Name = "label32";
            label32.Size = new Size(75, 20);
            label32.TabIndex = 0;
            label32.Text = "Cancelled";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(txt_ordered);
            groupBox7.Controls.Add(label31);
            groupBox7.Location = new Point(18, 330);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(219, 70);
            groupBox7.TabIndex = 0;
            groupBox7.TabStop = false;
            // 
            // txt_ordered
            // 
            txt_ordered.Enabled = false;
            txt_ordered.Location = new Point(127, 20);
            txt_ordered.Name = "txt_ordered";
            txt_ordered.Size = new Size(65, 27);
            txt_ordered.TabIndex = 1;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label31.ForeColor = Color.FromArgb(255, 128, 0);
            label31.Location = new Point(17, 23);
            label31.Name = "label31";
            label31.Size = new Size(66, 20);
            label31.TabIndex = 0;
            label31.Text = "Ordered";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txt_ordersuccessful);
            groupBox6.Controls.Add(label30);
            groupBox6.Location = new Point(18, 236);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(219, 71);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            // 
            // txt_ordersuccessful
            // 
            txt_ordersuccessful.Enabled = false;
            txt_ordersuccessful.Location = new Point(127, 20);
            txt_ordersuccessful.Name = "txt_ordersuccessful";
            txt_ordersuccessful.Size = new Size(65, 27);
            txt_ordersuccessful.TabIndex = 1;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label30.ForeColor = Color.Blue;
            label30.Location = new Point(17, 23);
            label30.Name = "label30";
            label30.Size = new Size(81, 20);
            label30.TabIndex = 0;
            label30.Text = "Successful";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txt_allorder);
            groupBox5.Controls.Add(label29);
            groupBox5.Location = new Point(18, 127);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(219, 75);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            // 
            // txt_allorder
            // 
            txt_allorder.Enabled = false;
            txt_allorder.Location = new Point(127, 34);
            txt_allorder.Name = "txt_allorder";
            txt_allorder.Size = new Size(65, 27);
            txt_allorder.TabIndex = 1;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label29.Location = new Point(17, 37);
            label29.Name = "label29";
            label29.Size = new Size(96, 20);
            label29.TabIndex = 0;
            label29.Text = "All of orders";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 693);
            Controls.Add(tabcontrol1);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += AdminForm_Load;
            tabcontrol1.ResumeLayout(false);
            tab_manageaccounts.ResumeLayout(false);
            tab_manageaccounts.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_user).EndInit();
            tab_manageproducts.ResumeLayout(false);
            tab_manageproducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_product).EndInit();
            gb_productname.ResumeLayout(false);
            gb_productname.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_productimage).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_category).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_order).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabcontrol1;
        private TabPage tab_manageaccounts;
        private DataGridView dtg_user;
        private TabPage tab_manageproducts;
        private GroupBox groupBox2;
        private Label label2;
        private GroupBox groupBox1;
        private Label label1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lb_nameuser;
        private Label label3;
        private TextBox txt_searchuser;
        private Button btn_closeuser;
        private TextBox txt_role;
        private TextBox txt_address;
        private TextBox txt_gender;
        private TextBox txt_yob;
        private TextBox txt_phone;
        private TextBox txt_email;
        private TextBox txt_password;
        private TextBox txt_username;
        private Button btn_block;
        private PictureBox pictureBox1;
        private ComboBox cb_userstatus;
        private Label label4;
        private GroupBox groupBox3;
        private TextBox txt_searchproduct;
        private Label label11;
        private GroupBox gb_productname;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label lb_nameproduct;
        private PictureBox pb_productimage;
        private DataGridView dtg_product;
        private TextBox txt_quantity;
        private TextBox txt_price;
        private Button btn_deleteproduct;
        private Button btn_addproduct;
        private Button btn_editproduct;
        private TextBox txt_description;
        private Label label12;
        private ComboBox cb_category;
        private Label label19;
        private TextBox txt_image;
        private TextBox txt_id;
        private Label label18;
        private TextBox txt_productname;
        private Label label20;
        private Button Btn_closeproduct;
        private ComboBox cb_categoryproduct;
        private Label label22;
        private Label label16;
        private Label label17;
        private Label lb_totaluser;
        private Label lb_totalproduct;
        private Label label21;
        private TextBox txt_categoryname;
        private TextBox txt_categoryid;
        private Label label25;
        private Label label24;
        private Label label23;
        private DataGridView dtg_category;
        private Button btn_savecategory;
        private Button btn_closecategory;
        private Label label27;
        private Label label26;
        private GroupBox groupBox4;
        private Label label28;
        private GroupBox groupBox8;
        private Label label32;
        private GroupBox groupBox7;
        private TextBox txt_ordered;
        private Label label31;
        private GroupBox groupBox6;
        private TextBox txt_ordersuccessful;
        private Label label30;
        private GroupBox groupBox5;
        private TextBox txt_allorder;
        private Label label29;
        private TextBox txt_ordercancel;
        private DataGridView dtg_order;
        private OxyPlot.WindowsForms.PlotView pvChart;
        private Button btn_deletecategory;
        private Button btn_clearcategory;
    }
}