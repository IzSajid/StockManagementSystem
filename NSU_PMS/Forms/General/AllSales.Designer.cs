namespace NSU_PMS.Forms.General
{
    partial class AllSales
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
            label3 = new Label();
            TotalQuantityTxtBox = new TextBox();
            CloseBtn = new Button();
            label9 = new Label();
            DetailsListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            label6 = new Label();
            GrandTotalTxtBox = new TextBox();
            label5 = new Label();
            DiscountTxtBox = new TextBox();
            label1 = new Label();
            TotalTxtBox = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(273, 466);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 43;
            label3.Text = "Total Quantity";
            // 
            // TotalQuantityTxtBox
            // 
            TotalQuantityTxtBox.BackColor = Color.White;
            TotalQuantityTxtBox.BorderStyle = BorderStyle.FixedSingle;
            TotalQuantityTxtBox.Font = new Font("Lato", 12F);
            TotalQuantityTxtBox.Location = new Point(400, 459);
            TotalQuantityTxtBox.Name = "TotalQuantityTxtBox";
            TotalQuantityTxtBox.ReadOnly = true;
            TotalQuantityTxtBox.Size = new Size(253, 27);
            TotalQuantityTxtBox.TabIndex = 42;
            // 
            // CloseBtn
            // 
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            CloseBtn.ForeColor = Color.IndianRed;
            CloseBtn.Location = new Point(1042, 12);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(82, 51);
            CloseBtn.TabIndex = 41;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lato", 26.25F);
            label9.Location = new Point(457, 9);
            label9.Name = "label9";
            label9.Size = new Size(146, 42);
            label9.TabIndex = 40;
            label9.Text = "All Sales";
            // 
            // DetailsListView
            // 
            DetailsListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            DetailsListView.Font = new Font("Lato", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DetailsListView.FullRowSelect = true;
            DetailsListView.GridLines = true;
            DetailsListView.Location = new Point(12, 94);
            DetailsListView.MultiSelect = false;
            DetailsListView.Name = "DetailsListView";
            DetailsListView.Size = new Size(1094, 346);
            DetailsListView.TabIndex = 39;
            DetailsListView.UseCompatibleStateImageBehavior = false;
            DetailsListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Client Name";
            columnHeader2.Width = 220;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Total";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Discount";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Quantity";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Grand Total";
            columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Date Time";
            columnHeader10.Width = 220;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(696, 553);
            label6.Name = "label6";
            label6.Size = new Size(151, 29);
            label6.TabIndex = 49;
            label6.Text = "Grand Total";
            // 
            // GrandTotalTxtBox
            // 
            GrandTotalTxtBox.BackColor = Color.White;
            GrandTotalTxtBox.BorderStyle = BorderStyle.FixedSingle;
            GrandTotalTxtBox.Font = new Font("Lato", 16F, FontStyle.Bold);
            GrandTotalTxtBox.Location = new Point(853, 549);
            GrandTotalTxtBox.Name = "GrandTotalTxtBox";
            GrandTotalTxtBox.ReadOnly = true;
            GrandTotalTxtBox.Size = new Size(253, 33);
            GrandTotalTxtBox.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.Location = new Point(767, 512);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 47;
            label5.Text = "Discount";
            // 
            // DiscountTxtBox
            // 
            DiscountTxtBox.BackColor = Color.White;
            DiscountTxtBox.BorderStyle = BorderStyle.FixedSingle;
            DiscountTxtBox.Font = new Font("Lato", 12F);
            DiscountTxtBox.Location = new Point(853, 505);
            DiscountTxtBox.Name = "DiscountTxtBox";
            DiscountTxtBox.ReadOnly = true;
            DiscountTxtBox.Size = new Size(253, 27);
            DiscountTxtBox.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(798, 466);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 45;
            label1.Text = "Total";
            // 
            // TotalTxtBox
            // 
            TotalTxtBox.BackColor = Color.White;
            TotalTxtBox.BorderStyle = BorderStyle.FixedSingle;
            TotalTxtBox.Font = new Font("Lato", 12F);
            TotalTxtBox.Location = new Point(853, 459);
            TotalTxtBox.Name = "TotalTxtBox";
            TotalTxtBox.ReadOnly = true;
            TotalTxtBox.Size = new Size(253, 27);
            TotalTxtBox.TabIndex = 44;
            // 
            // AllSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1136, 626);
            Controls.Add(label6);
            Controls.Add(GrandTotalTxtBox);
            Controls.Add(label5);
            Controls.Add(DiscountTxtBox);
            Controls.Add(label1);
            Controls.Add(TotalTxtBox);
            Controls.Add(label3);
            Controls.Add(TotalQuantityTxtBox);
            Controls.Add(CloseBtn);
            Controls.Add(label9);
            Controls.Add(DetailsListView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AllSales";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AllSales";
            FormClosed += AllSales_FormClosed;
            Load += AllSales_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox TotalQuantityTxtBox;
        private Button CloseBtn;
        private Label label9;
        private ListView DetailsListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Label label6;
        private TextBox GrandTotalTxtBox;
        private Label label5;
        private TextBox DiscountTxtBox;
        private Label label1;
        private TextBox TotalTxtBox;
    }
}