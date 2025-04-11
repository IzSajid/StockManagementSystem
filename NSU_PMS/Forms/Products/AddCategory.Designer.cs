namespace NSU_PMS.Forms.Products
{
    partial class AddCategory
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
            DescriptionTxtBox = new TextBox();
            label7 = new Label();
            CategoryTxtBox = new TextBox();
            SaveBtn = new Button();
            panel2 = new Panel();
            CloseBtn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // DescriptionTxtBox
            // 
            DescriptionTxtBox.BorderStyle = BorderStyle.FixedSingle;
            DescriptionTxtBox.Font = new Font("Lato", 12F);
            DescriptionTxtBox.Location = new Point(12, 181);
            DescriptionTxtBox.Multiline = true;
            DescriptionTxtBox.Name = "DescriptionTxtBox";
            DescriptionTxtBox.Size = new Size(682, 168);
            DescriptionTxtBox.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Antipasto Pro DemiBold", 11.249999F, FontStyle.Bold);
            label7.Location = new Point(12, 159);
            label7.Name = "label7";
            label7.Size = new Size(78, 19);
            label7.TabIndex = 19;
            label7.Text = "Description";
            // 
            // CategoryTxtBox
            // 
            CategoryTxtBox.BorderStyle = BorderStyle.None;
            CategoryTxtBox.Font = new Font("Antipasto Pro Bold", 12F, FontStyle.Bold);
            CategoryTxtBox.Location = new Point(12, 102);
            CategoryTxtBox.Multiline = true;
            CategoryTxtBox.Name = "CategoryTxtBox";
            CategoryTxtBox.PlaceholderText = "Type Your Category";
            CategoryTxtBox.Size = new Size(331, 23);
            CategoryTxtBox.TabIndex = 15;
            // 
            // SaveBtn
            // 
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.Font = new Font("Antipasto Pro DemiBold", 14.2499981F, FontStyle.Bold);
            SaveBtn.ForeColor = Color.Green;
            SaveBtn.Location = new Point(559, 373);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(135, 57);
            SaveBtn.TabIndex = 21;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(13, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 1);
            panel2.TabIndex = 24;
            // 
            // CloseBtn
            // 
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Font = new Font("Antipasto Pro DemiBold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseBtn.ForeColor = Color.IndianRed;
            CloseBtn.Location = new Point(614, 16);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(80, 51);
            CloseBtn.TabIndex = 29;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lato", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(233, 23);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(231, 42);
            label3.TabIndex = 30;
            label3.Text = "Add Category";
            // 
            // AddCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(710, 450);
            Controls.Add(label3);
            Controls.Add(CloseBtn);
            Controls.Add(panel2);
            Controls.Add(SaveBtn);
            Controls.Add(DescriptionTxtBox);
            Controls.Add(label7);
            Controls.Add(CategoryTxtBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCategory";
            FormClosed += AddCategory_FormClosed;
            Load += AddCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DescriptionTxtBox;
        private Label label7;
        private TextBox CategoryTxtBox;
        private Button SaveBtn;
        private Panel panel2;
        private Button CloseBtn;
        private Label label3;
    }
}