namespace NSU_PMS.Forms.Employee
{
    partial class SignIn
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
            PassTxtBox = new TextBox();
            EmailTxtBox = new TextBox();
            LoginBtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            CloseBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // PassTxtBox
            // 
            PassTxtBox.BorderStyle = BorderStyle.None;
            PassTxtBox.Font = new Font("Antipasto Pro Bold", 12F, FontStyle.Bold);
            PassTxtBox.Location = new Point(719, 295);
            PassTxtBox.Multiline = true;
            PassTxtBox.Name = "PassTxtBox";
            PassTxtBox.PasswordChar = '*';
            PassTxtBox.PlaceholderText = " Enter Your Password";
            PassTxtBox.Size = new Size(362, 23);
            PassTxtBox.TabIndex = 15;
            // 
            // EmailTxtBox
            // 
            EmailTxtBox.BorderStyle = BorderStyle.None;
            EmailTxtBox.Font = new Font("Antipasto Pro Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailTxtBox.Location = new Point(719, 188);
            EmailTxtBox.Multiline = true;
            EmailTxtBox.Name = "EmailTxtBox";
            EmailTxtBox.PlaceholderText = " Enter Your Email";
            EmailTxtBox.Size = new Size(362, 23);
            EmailTxtBox.TabIndex = 13;
            // 
            // LoginBtn
            // 
            LoginBtn.FlatStyle = FlatStyle.Popup;
            LoginBtn.Font = new Font("Antipasto Pro DemiBold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.Location = new Point(769, 395);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(230, 51);
            LoginBtn.TabIndex = 19;
            LoginBtn.Text = "Log In";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tiny_pharmacist_with_medicine_drug_pill_vitamin_vector_40268939;
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(613, 582);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._5087579;
            pictureBox2.Location = new Point(653, 165);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(719, 216);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 1);
            panel1.TabIndex = 22;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._1000915;
            pictureBox3.Location = new Point(653, 269);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(719, 324);
            panel2.Name = "panel2";
            panel2.Size = new Size(362, 1);
            panel2.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Antipasto Pro ", 47.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(779, 32);
            label3.Name = "label3";
            label3.Size = new Size(198, 74);
            label3.TabIndex = 26;
            label3.Text = "Sign In";
            // 
            // CloseBtn
            // 
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Font = new Font("Antipasto Pro DemiBold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseBtn.ForeColor = Color.IndianRed;
            CloseBtn.Location = new Point(769, 469);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(230, 51);
            CloseBtn.TabIndex = 27;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1156, 582);
            Controls.Add(CloseBtn);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(LoginBtn);
            Controls.Add(PassTxtBox);
            Controls.Add(EmailTxtBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignIn";
            FormClosed += SignIn_FormClosed;
            Load += SignIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox PassTxtBox;
        private TextBox EmailTxtBox;
        private Button LoginBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Label label3;
        private Button CloseBtn;
    }
}