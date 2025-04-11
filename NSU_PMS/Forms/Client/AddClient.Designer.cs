namespace NSU_PMS.Forms.Client
{
    partial class AddClient
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
            ComentTxtBox = new Label();
            CommentsTxtBox = new TextBox();
            SaveBtn = new Button();
            label7 = new Label();
            AddressTxtBox = new TextBox();
            PhoneTxtBox = new TextBox();
            EmailTxtBox = new TextBox();
            NameTxtBox = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            CloseBtn = new Button();
            SuspendLayout();
            // 
            // ComentTxtBox
            // 
            ComentTxtBox.AutoSize = true;
            ComentTxtBox.Font = new Font("Antipasto Pro DemiBold", 11.249999F, FontStyle.Bold);
            ComentTxtBox.ForeColor = Color.Black;
            ComentTxtBox.Location = new Point(790, 88);
            ComentTxtBox.Name = "ComentTxtBox";
            ComentTxtBox.Size = new Size(74, 19);
            ComentTxtBox.TabIndex = 37;
            ComentTxtBox.Text = "Comments";
            // 
            // CommentsTxtBox
            // 
            CommentsTxtBox.BorderStyle = BorderStyle.FixedSingle;
            CommentsTxtBox.Font = new Font("Lato", 12F);
            CommentsTxtBox.Location = new Point(790, 110);
            CommentsTxtBox.Multiline = true;
            CommentsTxtBox.Name = "CommentsTxtBox";
            CommentsTxtBox.Size = new Size(321, 180);
            CommentsTxtBox.TabIndex = 36;
            // 
            // SaveBtn
            // 
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.Font = new Font("Antipasto Pro DemiBold", 14.2499981F, FontStyle.Bold);
            SaveBtn.Location = new Point(1157, 110);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(145, 51);
            SaveBtn.TabIndex = 35;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Antipasto Pro DemiBold", 11.249999F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(431, 88);
            label7.Name = "label7";
            label7.Size = new Size(59, 19);
            label7.TabIndex = 34;
            label7.Text = "Address";
            // 
            // AddressTxtBox
            // 
            AddressTxtBox.BorderStyle = BorderStyle.FixedSingle;
            AddressTxtBox.Font = new Font("Lato", 12F);
            AddressTxtBox.Location = new Point(431, 110);
            AddressTxtBox.Multiline = true;
            AddressTxtBox.Name = "AddressTxtBox";
            AddressTxtBox.Size = new Size(321, 180);
            AddressTxtBox.TabIndex = 33;
            // 
            // PhoneTxtBox
            // 
            PhoneTxtBox.BorderStyle = BorderStyle.None;
            PhoneTxtBox.Font = new Font("Antipasto Pro Bold", 12F, FontStyle.Bold);
            PhoneTxtBox.Location = new Point(30, 256);
            PhoneTxtBox.Multiline = true;
            PhoneTxtBox.Name = "PhoneTxtBox";
            PhoneTxtBox.PlaceholderText = "Enter Your Phone Number";
            PhoneTxtBox.Size = new Size(331, 23);
            PhoneTxtBox.TabIndex = 27;
            // 
            // EmailTxtBox
            // 
            EmailTxtBox.BorderStyle = BorderStyle.None;
            EmailTxtBox.Font = new Font("Antipasto Pro Bold", 12F, FontStyle.Bold);
            EmailTxtBox.Location = new Point(31, 180);
            EmailTxtBox.Multiline = true;
            EmailTxtBox.Name = "EmailTxtBox";
            EmailTxtBox.PlaceholderText = "Enter Your Email";
            EmailTxtBox.Size = new Size(331, 23);
            EmailTxtBox.TabIndex = 23;
            // 
            // NameTxtBox
            // 
            NameTxtBox.BorderStyle = BorderStyle.None;
            NameTxtBox.Font = new Font("Antipasto Pro Bold", 12F, FontStyle.Bold);
            NameTxtBox.Location = new Point(31, 91);
            NameTxtBox.Multiline = true;
            NameTxtBox.Name = "NameTxtBox";
            NameTxtBox.PlaceholderText = "Enter Your Name";
            NameTxtBox.Size = new Size(331, 26);
            NameTxtBox.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(30, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 1);
            panel1.TabIndex = 38;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(31, 209);
            panel2.Name = "panel2";
            panel2.Size = new Size(331, 1);
            panel2.TabIndex = 39;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(30, 285);
            panel3.Name = "panel3";
            panel3.Size = new Size(331, 1);
            panel3.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lato", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(569, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(181, 42);
            label3.TabIndex = 41;
            label3.Text = "Add Client";
            // 
            // CloseBtn
            // 
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Font = new Font("Antipasto Pro DemiBold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseBtn.ForeColor = Color.IndianRed;
            CloseBtn.Location = new Point(1157, 180);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(145, 51);
            CloseBtn.TabIndex = 42;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // AddClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1339, 344);
            Controls.Add(CloseBtn);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(ComentTxtBox);
            Controls.Add(CommentsTxtBox);
            Controls.Add(SaveBtn);
            Controls.Add(label7);
            Controls.Add(AddressTxtBox);
            Controls.Add(PhoneTxtBox);
            Controls.Add(EmailTxtBox);
            Controls.Add(NameTxtBox);
            ForeColor = Color.Green;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddClient";
            FormClosed += AddClient_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ComentTxtBox;
        private TextBox CommentsTxtBox;
        private Button SaveBtn;
        private Label label7;
        private TextBox AddressTxtBox;
        private TextBox PhoneTxtBox;
        private TextBox EmailTxtBox;
        private TextBox NameTxtBox;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Button CloseBtn;
    }
}