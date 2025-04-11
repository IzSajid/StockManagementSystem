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

namespace NSU_PMS.Forms.General
{
    public partial class AllSales : Form
    {
        public AllSales()
        {
            InitializeComponent();
        }
        WinformDbContext _windb = new WinformDbContext();
        private async void AllSales_Load(object sender, EventArgs e)
        {
            var sales = await(
                        from s in _windb.Sales
                        join c in _windb.Clients on s.ClientID equals c.Id
                        select new
                        {
                            Sales = s,
                            ClientName = c.Name
                        }
                    ).ToListAsync();
            int quantity = 0; double price = 0, discount = 0;

            foreach (var sale in sales)
            {

                ListViewItem newItem = new ListViewItem(new[]
                {
                        sale.Sales.ID,sale.ClientName, sale.Sales.Total.ToString("F2"), sale.Sales.Discount.ToString("F2"), 
                    sale.Sales.Quantity.ToString(), sale.Sales.SubTotal.ToString("F2"), sale.Sales.DateTime.ToString()
                });


                DetailsListView.Items.Add(newItem);

                quantity += sale.Sales.Quantity;
                price += sale.Sales.Total;
                discount += sale.Sales.Discount;


            }

            TotalQuantityTxtBox.Text = quantity.ToString("F2");
            TotalTxtBox.Text = price.ToString("F2");
            DiscountTxtBox.Text = discount.ToString("F2");
            GrandTotalTxtBox.Text = (price - discount).ToString("F2");
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllSales_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.dashboard.Show();
        }
    }
}
