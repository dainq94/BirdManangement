namespace GiftHommieWinforms
{
    partial class CheckoutForm
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
            label1 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            dgvCheckout = new DataGridView();
            txtTotal = new TextBox();
            label4 = new Label();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            button2 = new Button();
            btnCheckout = new Button();
            txtMessage = new TextBox();
            label9 = new Label();
            txtName = new TextBox();
            label8 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(326, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 46);
            label1.TabIndex = 0;
            label1.Text = "CHECKOUT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(501, 6);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 4;
            label5.Text = "MESSAGE";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvCheckout);
            panel1.Controls.Add(txtTotal);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnCheckout);
            panel1.Controls.Add(txtMessage);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 84);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(859, 494);
            panel1.TabIndex = 15;
            // 
            // dgvCheckout
            // 
            dgvCheckout.AllowUserToAddRows = false;
            dgvCheckout.AllowUserToDeleteRows = false;
            dgvCheckout.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCheckout.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckout.Dock = DockStyle.Bottom;
            dgvCheckout.Location = new Point(0, 300);
            dgvCheckout.Margin = new Padding(3, 2, 3, 2);
            dgvCheckout.Name = "dgvCheckout";
            dgvCheckout.ReadOnly = true;
            dgvCheckout.RowHeadersWidth = 51;
            dgvCheckout.RowTemplate.Height = 29;
            dgvCheckout.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCheckout.Size = new Size(859, 194);
            dgvCheckout.TabIndex = 24;
            dgvCheckout.CellFormatting += dgvCheckout_CellFormatting;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(133, 154);
            txtTotal.Margin = new Padding(2, 2, 2, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(175, 27);
            txtTotal.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(53, 154);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 22;
            label4.Text = "TOTAL:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(133, 114);
            txtAddress.Margin = new Padding(2, 2, 2, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(215, 27);
            txtAddress.TabIndex = 21;
            txtAddress.TextChanged += txtAddress_TextChanged;
            txtAddress.KeyPress += txtAddress_KeyPress;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(133, 70);
            txtPhone.Margin = new Padding(2, 2, 2, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(215, 27);
            txtPhone.TabIndex = 20;
            txtPhone.TextChanged += txtPhone_TextChanged;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(661, 198);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(89, 26);
            button2.TabIndex = 19;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(501, 198);
            btnCheckout.Margin = new Padding(2, 2, 2, 2);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(89, 26);
            btnCheckout.TabIndex = 18;
            btnCheckout.Text = "ORDER";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += button1_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(391, 30);
            txtMessage.Margin = new Padding(3, 2, 3, 2);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(361, 150);
            txtMessage.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(53, 74);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(61, 20);
            label9.TabIndex = 9;
            label9.Text = "PHONE:";
            // 
            // txtName
            // 
            txtName.Location = new Point(133, 26);
            txtName.Margin = new Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(215, 27);
            txtName.TabIndex = 8;
            txtName.TextChanged += txtName_TextChanged_1;
            txtName.KeyPress += txtName_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(53, 114);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 7;
            label8.Text = "ADDRESS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 32);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "NAME:";
            // 
            // CheckoutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 578);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CheckoutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCheckout";
            Load += frmCheckout_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox3;
        private Panel panel1;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label9;
        private TextBox txtName;
        private Label label8;
        private Label label2;
        private Button button2;
        private Button btnCheckout;
        private TextBox txtMessage;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtTotal;
        private Label label4;
        private DataGridView dgvCheckout;
    }
}