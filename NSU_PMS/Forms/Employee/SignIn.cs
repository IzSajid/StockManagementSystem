using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSU_PMS.Forms.Employee
{
    public partial class SignIn : Form
    {
        public static bool login = false;
        public SignIn()
        {
            InitializeComponent();
        }
        WinformDbContext _windb = new WinformDbContext();
        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                var user = await _windb.Employees.Where(c => c.Email == EmailTxtBox.Text &&
                c.Password == PassTxtBox.Text).ToListAsync();

                if (user.Count() < 1)
                {
                    MessageBox.Show("Invalid Login");
                    return;
                }

                MessageBox.Show("Login Successful");
                login = true;
                Global.dashboard.Show();
                this.Hide();
                FormFunctions.ClearForm(this.Controls);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                this.Enabled = true;
            }
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void SignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (login)
            {
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
