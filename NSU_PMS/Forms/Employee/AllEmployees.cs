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
    public partial class AllEmployees : Form
    {
        public AllEmployees()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void AllEmployees_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.dashboard.Show();
        }

        WinformDbContext _windb = new WinformDbContext();
        private async void AllEmployees_Load(object sender, EventArgs e)
        {
            var emps = await _windb.Employees.ToListAsync();

            foreach (var emp in emps)
            {

                ListViewItem newItem = new ListViewItem(new[]
                {
                        emp.Id, emp.Name, emp.Address, emp.Phone, emp.Email, emp.Nid
                });

                DetailsListView.Items.Add(newItem);
            }
        }
    }
}
