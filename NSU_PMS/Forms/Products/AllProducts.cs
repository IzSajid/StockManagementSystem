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

namespace NSU_PMS.Forms.Products
{
    public class ProductListViewItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string Discount { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public string Status { get; set; }

        public ListViewItem ToListViewItem()
        {
            // converting step 2 
            return new ListViewItem(new[]{
                ID, Name, Description, CategoryName, Discount, Quantity, Price, Status
            });
        }
    }


    public class ProductAdapter
    {
        public static ProductListViewItem Adapt(Models.Product product, string categoryName)
        {
            //converting step 1 
            return new ProductListViewItem
            {
                ID = product.ID,
                Name = product.Name,
                Description = product.Description,
                CategoryName = categoryName,
                Discount = product.Discount.ToString("F2"),
                Quantity = product.Quantity.ToString(),
                Price = product.Price.ToString("F2"),
                Status = product.Status
            };
        }
    }


    public partial class AllProducts : Form
    {
        public AllProducts()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        WinformDbContext _windb = new WinformDbContext();
        private async void AllProducts_Load(object sender, EventArgs e)
        {
            int quantity = 0;
            double price = 0;

            // getting product and category name 
            var prods = await (
                from p in _windb.Products
                join c in _windb.Categories on p.Category equals c.ID
                select new { Product = p, CategoryName = c.Name } 
            ).ToListAsync();


            foreach (var prod in prods)
            {

                // converting step 1 
                ProductListViewItem adapted = ProductAdapter.Adapt(prod.Product, prod.CategoryName);

                // converting step 2 
                ListViewItem lvi = adapted.ToListViewItem();
                DetailsListView.Items.Add(lvi);

                quantity += prod.Product.Quantity;
                price += prod.Product.Price * prod.Product.Quantity;
            }

            TotalQuantityTxtBox.Text = quantity.ToString("F2");
            TotalPriceTxtBox.Text = price.ToString("F2");
        }


        private void AllProducts_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.dashboard.Show();
        }

        private void DetailsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
