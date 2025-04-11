namespace NSU_PMS.Forms.Products
{
    partial class AllProducts
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
            DetailsListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            label9 = new Label();
            CloseBtn = new Button();
            label5 = new Label();
            TotalPriceTxtBox = new TextBox();
            label3 = new Label();
            TotalQuantityTxtBox = new TextBox();
            SuspendLayout();
            // 
            // DetailsListView
            // 
            DetailsListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader5, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            DetailsListView.Font = new Font("Lato", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DetailsListView.FullRowSelect = true;
            DetailsListView.GridLines = true;
            DetailsListView.Location = new Point(12, 88);
            DetailsListView.MultiSelect = false;
            DetailsListView.Name = "DetailsListView";
            DetailsListView.Size = new Size(1308, 346);
            DetailsListView.TabIndex = 30;
            DetailsListView.UseCompatibleStateImageBehavior = false;
            DetailsListView.View = View.Details;
            DetailsListView.SelectedIndexChanged += DetailsListView_SelectedIndexChanged;
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
            columnHeader3.Text = "Description";
            columnHeader3.Width = 330;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Category";
            columnHeader5.Width = 180;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Discount";
            columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Quantity";
            columnHeader8.Width = 70;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Price";
            columnHeader9.Width = 130;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Status";
            columnHeader10.Width = 100;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(24, 28);
            label9.Name = "label9";
            label9.Size = new Size(183, 33);
            label9.TabIndex = 31;
            label9.Text = "All Products";
            // 
            // CloseBtn
            // 
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold);
            CloseBtn.ForeColor = Color.IndianRed;
            CloseBtn.Location = new Point(1239, 23);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(82, 51);
            CloseBtn.TabIndex = 32;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold);
            label5.Location = new Point(874, 497);
            label5.Name = "label5";
            label5.Size = new Size(188, 24);
            label5.TabIndex = 38;
            label5.Text = "Inventory Valuation";
            // 
            // TotalPriceTxtBox
            // 
            TotalPriceTxtBox.BackColor = Color.White;
            TotalPriceTxtBox.BorderStyle = BorderStyle.FixedSingle;
            TotalPriceTxtBox.Font = new Font("Lato", 12F);
            TotalPriceTxtBox.Location = new Point(1068, 498);
            TotalPriceTxtBox.Name = "TotalPriceTxtBox";
            TotalPriceTxtBox.ReadOnly = true;
            TotalPriceTxtBox.Size = new Size(253, 27);
            TotalPriceTxtBox.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold);
            label3.Location = new Point(924, 455);
            label3.Name = "label3";
            label3.Size = new Size(138, 24);
            label3.TabIndex = 36;
            label3.Text = "Total Quantity";
            // 
            // TotalQuantityTxtBox
            // 
            TotalQuantityTxtBox.BackColor = Color.White;
            TotalQuantityTxtBox.BorderStyle = BorderStyle.FixedSingle;
            TotalQuantityTxtBox.Font = new Font("Lato", 12F);
            TotalQuantityTxtBox.Location = new Point(1068, 452);
            TotalQuantityTxtBox.Name = "TotalQuantityTxtBox";
            TotalQuantityTxtBox.ReadOnly = true;
            TotalQuantityTxtBox.Size = new Size(253, 27);
            TotalQuantityTxtBox.TabIndex = 35;
            // 
            // AllProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1334, 598);
            Controls.Add(label5);
            Controls.Add(TotalPriceTxtBox);
            Controls.Add(label3);
            Controls.Add(TotalQuantityTxtBox);
            Controls.Add(CloseBtn);
            Controls.Add(label9);
            Controls.Add(DetailsListView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AllProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AllProducts";
            FormClosed += AllProducts_FormClosed;
            Load += AllProducts_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView DetailsListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Label label9;
        private Button CloseBtn;
        private Label label5;
        private TextBox TotalPriceTxtBox;
        private Label label3;
        private TextBox TotalQuantityTxtBox;
    }
}