namespace Inventory
{
    partial class frnAddProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            richTxtDescription = new RichTextBox();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            dtPickerMfgDate = new DateTimePicker();
            cbCategory = new ComboBox();
            txtSellPrice = new TextBox();
            gridViewProductList = new DataGridView();
            label8 = new Label();
            dtPickerExpDate = new DateTimePicker();
            btnAddProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(16, 17);
            label1.Name = "label1";
            label1.Size = new Size(165, 37);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(16, 77);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 1;
            label2.Text = "Product";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(16, 111);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(16, 148);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 3;
            label4.Text = "Mfg. Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(16, 209);
            label5.Name = "label5";
            label5.Size = new Size(35, 19);
            label5.TabIndex = 4;
            label5.Text = "Qty.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(16, 245);
            label6.Name = "label6";
            label6.Size = new Size(62, 19);
            label6.TabIndex = 5;
            label6.Text = "Sell Price";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(373, 73);
            label7.Name = "label7";
            label7.Size = new Size(78, 19);
            label7.TabIndex = 6;
            label7.Text = "Description";
            label7.Click += label7_Click;
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(373, 95);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(335, 181);
            richTxtDescription.TabIndex = 7;
            richTxtDescription.Text = "";
            richTxtDescription.TextChanged += richTextBox1_TextChanged;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(107, 73);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(222, 23);
            txtProductName.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(107, 208);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(222, 23);
            txtQuantity.TabIndex = 9;
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Format = DateTimePickerFormat.Short;
            dtPickerMfgDate.Location = new Point(107, 144);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(222, 23);
            dtPickerMfgDate.TabIndex = 10;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(107, 107);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(222, 23);
            cbCategory.TabIndex = 11;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Location = new Point(107, 241);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(222, 23);
            txtSellPrice.TabIndex = 12;
            // 
            // gridViewProductList
            // 
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(75, 331);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.Size = new Size(633, 199);
            gridViewProductList.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(16, 179);
            label8.Name = "label8";
            label8.Size = new Size(66, 19);
            label8.TabIndex = 14;
            label8.Text = "Exp. Date";
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Format = DateTimePickerFormat.Short;
            dtPickerExpDate.Location = new Point(107, 175);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(222, 23);
            dtPickerExpDate.TabIndex = 15;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Font = new Font("Segoe UI", 12F);
            btnAddProduct.Location = new Point(541, 288);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(135, 30);
            btnAddProduct.TabIndex = 16;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // frnAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 533);
            Controls.Add(btnAddProduct);
            Controls.Add(dtPickerExpDate);
            Controls.Add(label8);
            Controls.Add(gridViewProductList);
            Controls.Add(txtSellPrice);
            Controls.Add(cbCategory);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductName);
            Controls.Add(richTxtDescription);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frnAddProduct";
            Text = "Form1";
            Load += frnAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private RichTextBox richTxtDescription;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private DateTimePicker dtPickerMfgDate;
        private ComboBox cbCategory;
        private TextBox txtSellPrice;
        private DataGridView gridViewProductList;
        private Label label8;
        private DateTimePicker dtPickerExpDate;
        private Button btnAddProduct;
    }
}
