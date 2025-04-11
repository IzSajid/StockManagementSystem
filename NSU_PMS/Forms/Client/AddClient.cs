using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSU_PMS.Forms.Client
{
    public partial class AddClient : Form
    {
        WinformDbContext _windb = new WinformDbContext();
        public AddClient()
        {
            InitializeComponent();
        }

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                if (!FormFunctions.AreAllInputsValid(this.Controls))
                {
                    MessageBox.Show("Enter all information");
                    return;
                }
                Random random = new Random();
                await _windb.Clients.AddAsync(new Models.Client
                {
                    Id = "CLI-" + random.Next(10000, 99999) + "-" + random.Next(10000, 99999) + "-" + random.Next(10000, 99999),
                    Name = NameTxtBox.Text,
                    Address = AddressTxtBox.Text,
                    Phone = PhoneTxtBox.Text,
                    Email = EmailTxtBox.Text,
                    Comments = CommentsTxtBox.Text,
                });
                await _windb.SaveChangesAsync();
                FormFunctions.ClearForm(this.Controls);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
            finally
            {
                this.Enabled = true;
                MessageBox.Show("Entered");
            }
        }

        private void AddClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.dashboard.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
