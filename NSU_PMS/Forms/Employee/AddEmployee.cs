using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSU_PMS.Forms.Employee
{
    public partial class AddEmployee : Form
    {
        WinformDbContext _windb = new WinformDbContext();
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                if (!FormFunctions.IsEmailValid(EmailTxtBox.Text))
                {
                    MessageBox.Show("The Email is invalid");
                    return;
                }

                if (!FormFunctions.IsAllDigits(PhoneTxtBox.Text))
                {
                    MessageBox.Show("The Phone is invalid");
                    return;
                }


                if (!FormFunctions.IsAllDigits(NidTxtBox.Text))
                {
                    MessageBox.Show("The Phone is invalid");
                    return;
                }

                double result;
                if (!double.TryParse(SalaryTxtBox.Text, out result))
                {
                    MessageBox.Show("Enter decimal value in Salary");
                    return;
                }

                if (FormFunctions.AreAllInputsValid(this.Controls))
                {
                    Random random = new Random();

                    await _windb.Employees.AddAsync(new Models.Employee
                    {
                        Id = "Emp-" + random.Next(10000, 99999) + "-" + random.Next(10000, 99999) + "-" + random.Next(10000, 99999),
                        Name = NameTxtBox.Text,
                        Email = EmailTxtBox.Text,
                        Phone = PhoneTxtBox.Text,
                        Address = AddressTxtBox.Text,
                        Nid = NidTxtBox.Text,
                        Password = PassTxtBox.Text,
                        Salary = result,
                        DateTime = DateTime.Now,
                        Status = "Active",
                    });

                    await _windb.SaveChangesAsync();

                }

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

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void AddEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {

            Global.dashboard.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
