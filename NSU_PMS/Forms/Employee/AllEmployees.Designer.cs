namespace NSU_PMS.Forms.Employee
{
    partial class AllEmployees
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
            CloseBtn = new Button();
            label9 = new Label();
            DetailsListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            SuspendLayout();
            // 
            // CloseBtn
            // 
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Font = new Font("Antipasto Pro DemiBold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseBtn.ForeColor = Color.IndianRed;
            CloseBtn.Location = new Point(1373, 7);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(82, 51);
            CloseBtn.TabIndex = 31;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Antipasto Pro DemiBold", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(23, 23);
            label9.Name = "label9";
            label9.Size = new Size(165, 35);
            label9.TabIndex = 30;
            label9.Text = "All Employee";
            // 
            // DetailsListView
            // 
            DetailsListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader5, columnHeader4, columnHeader6 });
            DetailsListView.Font = new Font("Lato", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DetailsListView.FullRowSelect = true;
            DetailsListView.GridLines = true;
            DetailsListView.Location = new Point(14, 81);
            DetailsListView.MultiSelect = false;
            DetailsListView.Name = "DetailsListView";
            DetailsListView.Size = new Size(1441, 346);
            DetailsListView.TabIndex = 29;
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
            columnHeader2.Text = "Name";
            columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Address";
            columnHeader3.Width = 330;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Phone";
            columnHeader5.Width = 220;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Email";
            columnHeader4.Width = 220;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Comments";
            columnHeader6.Width = 220;
            // 
            // AllEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1468, 450);
            Controls.Add(CloseBtn);
            Controls.Add(label9);
            Controls.Add(DetailsListView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AllEmployees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AllEmployees";
            FormClosed += AllEmployees_FormClosed;
            Load += AllEmployees_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CloseBtn;
        private Label label9;
        private ListView DetailsListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader6;
    }
}