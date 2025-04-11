using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSU_PMS.Forms.Products
{
    public partial class AddCategory : Form
    {
        WinformDbContext _winDB = new WinformDbContext();

        public AddCategory()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                var cat = new Models.Category.Builder().WithID("Cat-" + random.Next(10000, 99999) + "-" + random.Next(10000, 99999) + "-" + random.Next(10000, 99999))
                            .WithName(CategoryTxtBox.Text)
                            .WithDescription(DescriptionTxtBox.Text)
                            .WithStatus("Active")
                            .WithDateTime(DateTime.Now)
                            .Build();

                await _winDB.Categories.AddAsync(cat);
                await _winDB.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
            finally
            {
                this.Enabled = true;
                FormFunctions.ClearForm(this.Controls);
                MessageBox.Show("Entered");
            }
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {

        }

        private void AddCategory_FormClosed(object sender, FormClosedEventArgs e)
        {

            Global.dashboard.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
