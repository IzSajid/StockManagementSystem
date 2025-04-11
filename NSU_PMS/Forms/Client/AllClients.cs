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

namespace NSU_PMS.Forms.Client
{
    public partial class AllClients : Form
    {
        public AllClients()
        {
            InitializeComponent();
        }
        WinformDbContext _windb = new WinformDbContext();

        private async void AllClients_Load(object sender, EventArgs e)
        {
            var client = await _windb.Clients.ToListAsync();

            foreach (Models.Client cl in client)
            {

                ListViewItem newItem = new ListViewItem(new[]
                {
                        cl.Id, cl.Name, cl.Address, cl.Phone, cl.Email, cl.Comments
                });

                DetailsListView.Items.Add(newItem);
            }
        }

        private void AllClients_FormClosed(object sender, FormClosedEventArgs e)
        {

            Global.dashboard.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetailsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
