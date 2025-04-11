namespace NSU_PMS.Forms.General
{
    partial class Sales
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
            label9 = new Label();
            CategoryComboBox = new ComboBox();
            DetailsListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            Client = new Label();
            ClientComboBox = new ComboBox();
            button1 = new Button();
            QuantityTxtBox = new TextBox();
            label2 = new Label();
            ProductNameComboBox = new ComboBox();
            label3 = new Label();
            TotalTxtBox = new TextBox();
            label5 = new Label();
            DiscountTxtBox = new TextBox();
            label6 = new Label();
            GrandTotalTxtBox = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ComentTxtBox = new Label();
            ClientInfoTxtBox = new TextBox();
            SalesBtn = new Button();
            label1 = new Label();
            panel1 = new Panel();
            CloseBtn = new Button();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label9.Location = new Point(29, 84);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 20;
            label9.Text = "Category";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryComboBox.Location = new Point(29, 106);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(292, 23);
            CategoryComboBox.TabIndex = 19;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // DetailsListView
            // 
            DetailsListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader5, columnHeader4 });
            DetailsListView.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            DetailsListView.FullRowSelect = true;
            DetailsListView.GridLines = true;
            DetailsListView.Location = new Point(366, 178);
            DetailsListView.MultiSelect = false;
            DetailsListView.Name = "DetailsListView";
            DetailsListView.Size = new Size(778, 187);
            DetailsListView.TabIndex = 22;
            DetailsListView.UseCompatibleStateImageBehavior = false;
            DetailsListView.View = View.Details;
            DetailsListView.KeyDown += DetailsListView_KeyDown;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Quantity";
            columnHeader3.Width = 110;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Discount";
            columnHeader5.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Price";
            columnHeader4.Width = 110;
            // 
            // Client
            // 
            Client.AutoSize = true;
            Client.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Client.Location = new Point(341, 85);
            Client.Name = "Client";
            Client.Size = new Size(55, 20);
            Client.TabIndex = 24;
            Client.Text = "Client";
            // 
            // ClientComboBox
            // 
            ClientComboBox.FormattingEnabled = true;
            ClientComboBox.Location = new Point(342, 105);
            ClientComboBox.Name = "ClientComboBox";
            ClientComboBox.Size = new Size(292, 23);
            ClientComboBox.TabIndex = 23;
            ClientComboBox.SelectedIndexChanged += ClientComboBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(29, 381);
            button1.Name = "button1";
            button1.Size = new Size(198, 40);
            button1.TabIndex = 25;
            button1.Text = "Add Details";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // QuantityTxtBox
            // 
            QuantityTxtBox.BorderStyle = BorderStyle.None;
            QuantityTxtBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            QuantityTxtBox.Location = new Point(976, 103);
            QuantityTxtBox.Multiline = true;
            QuantityTxtBox.Name = "QuantityTxtBox";
            QuantityTxtBox.PlaceholderText = "Type Your Quantity";
            QuantityTxtBox.Size = new Size(268, 23);
            QuantityTxtBox.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(658, 84);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 29;
            label2.Text = "Product Name";
            // 
            // ProductNameComboBox
            // 
            ProductNameComboBox.FormattingEnabled = true;
            ProductNameComboBox.Location = new Point(660, 106);
            ProductNameComboBox.Name = "ProductNameComboBox";
            ProductNameComboBox.Size = new Size(292, 23);
            ProductNameComboBox.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(961, 381);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 32;
            label3.Text = "Total";
            // 
            // TotalTxtBox
            // 
            TotalTxtBox.BackColor = Color.White;
            TotalTxtBox.BorderStyle = BorderStyle.FixedSingle;
            TotalTxtBox.Font = new Font("Lato", 12F);
            TotalTxtBox.Location = new Point(1016, 379);
            TotalTxtBox.Name = "TotalTxtBox";
            TotalTxtBox.ReadOnly = true;
            TotalTxtBox.Size = new Size(253, 27);
            TotalTxtBox.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.Location = new Point(930, 432);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 34;
            label5.Text = "Discount";
            // 
            // DiscountTxtBox
            // 
            DiscountTxtBox.BackColor = Color.White;
            DiscountTxtBox.BorderStyle = BorderStyle.FixedSingle;
            DiscountTxtBox.Font = new Font("Lato", 12F);
            DiscountTxtBox.Location = new Point(1016, 425);
            DiscountTxtBox.Name = "DiscountTxtBox";
            DiscountTxtBox.ReadOnly = true;
            DiscountTxtBox.Size = new Size(253, 27);
            DiscountTxtBox.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(874, 477);
            label6.Name = "label6";
            label6.Size = new Size(136, 25);
            label6.TabIndex = 36;
            label6.Text = "Grand Total";
            // 
            // GrandTotalTxtBox
            // 
            GrandTotalTxtBox.BackColor = Color.White;
            GrandTotalTxtBox.BorderStyle = BorderStyle.FixedSingle;
            GrandTotalTxtBox.Font = new Font("Lato", 16F, FontStyle.Bold);
            GrandTotalTxtBox.Location = new Point(1016, 469);
            GrandTotalTxtBox.Name = "GrandTotalTxtBox";
            GrandTotalTxtBox.ReadOnly = true;
            GrandTotalTxtBox.Size = new Size(253, 33);
            GrandTotalTxtBox.TabIndex = 35;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // ComentTxtBox
            // 
            ComentTxtBox.AutoSize = true;
            ComentTxtBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            ComentTxtBox.Location = new Point(29, 156);
            ComentTxtBox.Name = "ComentTxtBox";
            ComentTxtBox.Size = new Size(92, 20);
            ComentTxtBox.TabIndex = 38;
            ComentTxtBox.Text = "Client Info";
            // 
            // ClientInfoTxtBox
            // 
            ClientInfoTxtBox.BackColor = Color.White;
            ClientInfoTxtBox.BorderStyle = BorderStyle.FixedSingle;
            ClientInfoTxtBox.Font = new Font("Lato", 12F);
            ClientInfoTxtBox.Location = new Point(29, 178);
            ClientInfoTxtBox.Multiline = true;
            ClientInfoTxtBox.Name = "ClientInfoTxtBox";
            ClientInfoTxtBox.ReadOnly = true;
            ClientInfoTxtBox.Size = new Size(292, 187);
            ClientInfoTxtBox.TabIndex = 37;
            // 
            // SalesBtn
            // 
            SalesBtn.Font = new Font("Lato", 14F);
            SalesBtn.Location = new Point(1115, 528);
            SalesBtn.Name = "SalesBtn";
            SalesBtn.Size = new Size(153, 49);
            SalesBtn.TabIndex = 39;
            SalesBtn.Text = "Confirm";
            SalesBtn.UseVisualStyleBackColor = true;
            SalesBtn.Click += SalesBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(634, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 42);
            label1.TabIndex = 40;
            label1.Text = "Sales";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(980, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 1);
            panel1.TabIndex = 41;
            // 
            // CloseBtn
            // 
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold);
            CloseBtn.ForeColor = Color.IndianRed;
            CloseBtn.Location = new Point(1186, 12);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(82, 51);
            CloseBtn.TabIndex = 42;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1286, 589);
            Controls.Add(CloseBtn);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(SalesBtn);
            Controls.Add(ComentTxtBox);
            Controls.Add(ClientInfoTxtBox);
            Controls.Add(label6);
            Controls.Add(GrandTotalTxtBox);
            Controls.Add(label5);
            Controls.Add(DiscountTxtBox);
            Controls.Add(label3);
            Controls.Add(TotalTxtBox);
            Controls.Add(ProductNameComboBox);
            Controls.Add(label2);
            Controls.Add(QuantityTxtBox);
            Controls.Add(button1);
            Controls.Add(Client);
            Controls.Add(ClientComboBox);
            Controls.Add(DetailsListView);
            Controls.Add(label9);
            Controls.Add(CategoryComboBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales";
            FormClosed += Sales_FormClosed;
            Load += Sales_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private ComboBox CategoryComboBox;
        private ListView DetailsListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label Client;
        private ComboBox ClientComboBox;
        private Button button1;
        private TextBox QuantityTxtBox;
        private Label label2;
        private ComboBox ProductNameComboBox;
        private Label label3;
        private TextBox TotalTxtBox;
        private Label label5;
        private TextBox DiscountTxtBox;
        private Label label6;
        private TextBox GrandTotalTxtBox;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label ComentTxtBox;
        private TextBox ClientInfoTxtBox;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button SalesBtn;
        private Label label1;
        private Panel panel1;
        private Button CloseBtn;
    }
}