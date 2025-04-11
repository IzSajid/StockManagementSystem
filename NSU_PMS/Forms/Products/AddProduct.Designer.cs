namespace NSU_PMS.Forms.Products
{
    partial class AddProduct
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
            SaveBtn = new Button();
            ProductNameTxtBox = new TextBox();
            label4 = new Label();
            QuantityTxtBox = new TextBox();
            label5 = new Label();
            DiscountTxtBox = new TextBox();
            label6 = new Label();
            PriceTxtBox = new TextBox();
            label7 = new Label();
            DescriptionTxtBox = new TextBox();
            CategoryComboBox = new ComboBox();
            label9 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            CloseBtn = new Button();
            SuspendLayout();
            // 
            // SaveBtn
            // 
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.Font = new Font("Lato", 14F);
            SaveBtn.ForeColor = Color.Green;
            SaveBtn.Location = new Point(560, 325);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(213, 51);
            SaveBtn.TabIndex = 0;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // ProductNameTxtBox
            // 
            ProductNameTxtBox.BorderStyle = BorderStyle.None;
            ProductNameTxtBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            ProductNameTxtBox.Location = new Point(24, 99);
            ProductNameTxtBox.Multiline = true;
            ProductNameTxtBox.Name = "ProductNameTxtBox";
            ProductNameTxtBox.PlaceholderText = "Enter Your Product Name";
            ProductNameTxtBox.Size = new Size(331, 26);
            ProductNameTxtBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(25, 263);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 8;
            label4.Text = "Quantity";
            // 
            // QuantityTxtBox
            // 
            QuantityTxtBox.BorderStyle = BorderStyle.FixedSingle;
            QuantityTxtBox.Font = new Font("Lato", 12F);
            QuantityTxtBox.Location = new Point(24, 286);
            QuantityTxtBox.Name = "QuantityTxtBox";
            QuantityTxtBox.Size = new Size(284, 27);
            QuantityTxtBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.Location = new Point(24, 142);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 10;
            label5.Text = "Discount";
            // 
            // DiscountTxtBox
            // 
            DiscountTxtBox.BorderStyle = BorderStyle.FixedSingle;
            DiscountTxtBox.Font = new Font("Lato", 12F);
            DiscountTxtBox.Location = new Point(24, 164);
            DiscountTxtBox.Name = "DiscountTxtBox";
            DiscountTxtBox.Size = new Size(284, 27);
            DiscountTxtBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.Location = new Point(24, 203);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 12;
            label6.Text = "Price";
            // 
            // PriceTxtBox
            // 
            PriceTxtBox.BorderStyle = BorderStyle.FixedSingle;
            PriceTxtBox.Font = new Font("Lato", 12F);
            PriceTxtBox.Location = new Point(24, 226);
            PriceTxtBox.Name = "PriceTxtBox";
            PriceTxtBox.Size = new Size(284, 27);
            PriceTxtBox.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11.249999F, FontStyle.Bold);
            label7.Location = new Point(392, 110);
            label7.Name = "label7";
            label7.Size = new Size(94, 18);
            label7.TabIndex = 13;
            label7.Text = "Description";
            // 
            // DescriptionTxtBox
            // 
            DescriptionTxtBox.BorderStyle = BorderStyle.FixedSingle;
            DescriptionTxtBox.Font = new Font("Lato", 12F);
            DescriptionTxtBox.Location = new Point(392, 132);
            DescriptionTxtBox.Multiline = true;
            DescriptionTxtBox.Name = "DescriptionTxtBox";
            DescriptionTxtBox.Size = new Size(381, 180);
            DescriptionTxtBox.TabIndex = 14;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(24, 344);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(331, 21);
            CategoryComboBox.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(25, 322);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 18;
            label9.Text = "Category";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(24, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 1);
            panel1.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(25, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 42);
            label1.TabIndex = 42;
            label1.Text = "Add Product";
            // 
            // CloseBtn
            // 
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseBtn.ForeColor = Color.IndianRed;
            CloseBtn.Location = new Point(691, 27);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(82, 51);
            CloseBtn.TabIndex = 43;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(812, 411);
            Controls.Add(CloseBtn);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(CategoryComboBox);
            Controls.Add(DescriptionTxtBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(PriceTxtBox);
            Controls.Add(label5);
            Controls.Add(DiscountTxtBox);
            Controls.Add(label4);
            Controls.Add(QuantityTxtBox);
            Controls.Add(ProductNameTxtBox);
            Controls.Add(SaveBtn);
            Font = new Font("Lato", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProduct";
            FormClosed += AddProduct_FormClosed;
            Load += AddProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveBtn;
        private TextBox ProductNameTxtBox;
        private Label label4;
        private TextBox QuantityTxtBox;
        private Label label5;
        private TextBox DiscountTxtBox;
        private Label label6;
        private TextBox PriceTxtBox;
        private Label label7;
        private TextBox DescriptionTxtBox;
        private ComboBox CategoryComboBox;
        private Label label9;
        private Panel panel1;
        private Label label1;
        private Button CloseBtn;
    }
}