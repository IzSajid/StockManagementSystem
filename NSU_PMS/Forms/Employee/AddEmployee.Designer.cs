namespace NSU_PMS.Forms.Employee
{
    partial class AddEmployee
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
            NameTxtBox = new TextBox();
            EmailTxtBox = new TextBox();
            NidTxtBox = new TextBox();
            PhoneTxtBox = new TextBox();
            PassTxtBox = new TextBox();
            SalaryTxtBox = new TextBox();
            AddressTxtBox = new TextBox();
            label7 = new Label();
            SaveBtn = new Button();
            CommentsTxtBox = new TextBox();
            ComentTxtBox = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            CloseBtn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // NameTxtBox
            // 
            NameTxtBox.BorderStyle = BorderStyle.None;
            NameTxtBox.Font = new Font("Antipasto Pro Bold", 12F, FontStyle.Bold);
            NameTxtBox.Location = new Point(42, 100);
            NameTxtBox.Multiline = true;
            NameTxtBox.Name = "NameTxtBox";
            NameTxtBox.PlaceholderText = " Enter Your Name";
            NameTxtBox.Size = new Size(331, 23);
            NameTxtBox.TabIndex = 3;
            // 
            // EmailTxtBox
            // 
            EmailTxtBox.BorderStyle = BorderStyle.FixedSingle;
            EmailTxtBox.Font = new Font("Antipasto Pro Bold", 12F, FontStyle.Bold);
            EmailTxtBox.Location = new Point(435, 101);
            EmailTxtBox.Multiline = true;
            EmailTxtBox.Name = "EmailTxtBox";
            EmailTxtBox.PlaceholderText = " Enter Your Email";
            EmailTxtBox.Size = new Size(331, 23);
            EmailTxtBox.TabIndex = 5;
            // 
            // NidTxtBox
            // 
            NidTxtBox.BorderStyle = BorderStyle.None;
            NidTxtBox.Font = new Font("Antipasto Pro Bold", 12F, FontStyle.Bold);
            NidTxtBox.Location = new Point(42, 181);
            NidTxtBox.Multiline = true;
            NidTxtBox.Name = "NidTxtBox";
            NidTxtBox.PlaceholderText = " Type Your NID";
            NidTxtBox.Size = new Size(331, 23);
            NidTxtBox.TabIndex = 7;
            // 
            // PhoneTxtBox
            // 
            PhoneTxtBox.BorderStyle = BorderStyle.FixedSingle;
            PhoneTxtBox.Font = new Font("Antipasto Pro Bold", 12F, FontStyle.Bold);
            PhoneTxtBox.Location = new Point(824, 186);
            PhoneTxtBox.Multiline = true;
            PhoneTxtBox.Name = "PhoneTxtBox";
            PhoneTxtBox.PlaceholderText = "Enter Your Phone Number";
            PhoneTxtBox.Size = new Size(331, 23);
            PhoneTxtBox.TabIndex = 9;
            // 
            // PassTxtBox
            // 
            PassTxtBox.BorderStyle = BorderStyle.None;
            PassTxtBox.Font = new Font("Antipasto Pro Bold", 12F, FontStyle.Bold);
            PassTxtBox.Location = new Point(436, 186);
            PassTxtBox.Multiline = true;
            PassTxtBox.Name = "PassTxtBox";
            PassTxtBox.PasswordChar = '*';
            PassTxtBox.PlaceholderText = " Enter Your Password";
            PassTxtBox.Size = new Size(331, 23);
            PassTxtBox.TabIndex = 11;
            // 
            // SalaryTxtBox
            // 
            SalaryTxtBox.BorderStyle = BorderStyle.FixedSingle;
            SalaryTxtBox.Font = new Font("Antipasto Pro Bold", 12F, FontStyle.Bold);
            SalaryTxtBox.Location = new Point(819, 97);
            SalaryTxtBox.Multiline = true;
            SalaryTxtBox.Name = "SalaryTxtBox";
            SalaryTxtBox.PlaceholderText = " Type Your Salary";
            SalaryTxtBox.Size = new Size(331, 23);
            SalaryTxtBox.TabIndex = 13;
            // 
            // AddressTxtBox
            // 
            AddressTxtBox.BorderStyle = BorderStyle.FixedSingle;
            AddressTxtBox.Font = new Font("Lato", 12F);
            AddressTxtBox.Location = new Point(42, 288);
            AddressTxtBox.Multiline = true;
            AddressTxtBox.Name = "AddressTxtBox";
            AddressTxtBox.Size = new Size(331, 190);
            AddressTxtBox.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Antipasto Pro DemiBold", 11.249999F, FontStyle.Bold);
            label7.Location = new Point(42, 266);
            label7.Name = "label7";
            label7.Size = new Size(59, 19);
            label7.TabIndex = 17;
            label7.Text = "Address";
            // 
            // SaveBtn
            // 
            SaveBtn.FlatStyle = FlatStyle.Popup;
            SaveBtn.Font = new Font("Antipasto Pro DemiBold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBtn.ForeColor = Color.Green;
            SaveBtn.Location = new Point(866, 344);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(230, 51);
            SaveBtn.TabIndex = 18;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CommentsTxtBox
            // 
            CommentsTxtBox.BorderStyle = BorderStyle.FixedSingle;
            CommentsTxtBox.Font = new Font("Lato", 12F);
            CommentsTxtBox.Location = new Point(434, 288);
            CommentsTxtBox.Multiline = true;
            CommentsTxtBox.Name = "CommentsTxtBox";
            CommentsTxtBox.Size = new Size(331, 190);
            CommentsTxtBox.TabIndex = 19;
            // 
            // ComentTxtBox
            // 
            ComentTxtBox.AutoSize = true;
            ComentTxtBox.Font = new Font("Antipasto Pro DemiBold", 11.249999F, FontStyle.Bold);
            ComentTxtBox.Location = new Point(435, 266);
            ComentTxtBox.Name = "ComentTxtBox";
            ComentTxtBox.Size = new Size(74, 19);
            ComentTxtBox.TabIndex = 20;
            ComentTxtBox.Text = "Comments";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(42, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 1);
            panel2.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(436, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 1);
            panel1.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(822, 126);
            panel3.Name = "panel3";
            panel3.Size = new Size(330, 1);
            panel3.TabIndex = 23;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(42, 210);
            panel4.Name = "panel4";
            panel4.Size = new Size(330, 1);
            panel4.TabIndex = 23;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(437, 211);
            panel5.Name = "panel5";
            panel5.Size = new Size(330, 1);
            panel5.TabIndex = 23;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(824, 212);
            panel6.Name = "panel6";
            panel6.Size = new Size(330, 1);
            panel6.TabIndex = 23;
            // 
            // CloseBtn
            // 
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Font = new Font("Antipasto Pro DemiBold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseBtn.ForeColor = Color.IndianRed;
            CloseBtn.Location = new Point(866, 412);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(230, 51);
            CloseBtn.TabIndex = 28;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lato", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(488, 11);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(239, 42);
            label3.TabIndex = 29;
            label3.Text = "Add Employee";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1187, 540);
            Controls.Add(label3);
            Controls.Add(CloseBtn);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(ComentTxtBox);
            Controls.Add(CommentsTxtBox);
            Controls.Add(SaveBtn);
            Controls.Add(label7);
            Controls.Add(AddressTxtBox);
            Controls.Add(SalaryTxtBox);
            Controls.Add(PassTxtBox);
            Controls.Add(PhoneTxtBox);
            Controls.Add(NidTxtBox);
            Controls.Add(EmailTxtBox);
            Controls.Add(NameTxtBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEmployee";
            FormClosed += AddEmployee_FormClosed;
            Load += AddEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTxtBox;
        private TextBox EmailTxtBox;
        private TextBox NidTxtBox;
        private TextBox PhoneTxtBox;
        private TextBox PassTxtBox;
        private TextBox SalaryTxtBox;
        private TextBox AddressTxtBox;
        private Label label7;
        private Button SaveBtn;
        private TextBox CommentsTxtBox;
        private Label ComentTxtBox;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button CloseBtn;
        private Label label3;
    }
}