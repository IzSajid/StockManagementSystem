using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NSU_PMS.Models;
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
    // File: Factories/ProductFactory.cs
   
        public static class ProductFactory
        {
            private static readonly Random _random = new Random();

            public static Product CreateProduct(string name, string description, string categoryId, double discount, double price, int quantity)
            {
                return new Product
                {
                    ID = GenerateProductId(),
                    Name = name,
                    Description = description,
                    Category = categoryId,
                    Discount = discount,
                    Quantity = quantity,
                    Price = price,
                    TotalValuation = price * quantity,
                    Status = "Active",
                    DateTime = DateTime.Now
                };
            }

            private static string GenerateProductId()
            {
                return "Prod-" + _random.Next(10000, 99999) + "-" +
                       _random.Next(10000, 99999) + "-" +
                       _random.Next(10000, 99999);
            }
        }
    


    public partial class AddProduct : Form
    {
        WinformDbContext _winDB = new WinformDbContext();
        public AddProduct()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private async void AddProduct_Load(object sender, EventArgs e)
        {
            CategoryComboBox.DataSource = await _winDB.Categories.ToListAsync();
            CategoryComboBox.DisplayMember = "Name";
            CategoryComboBox.ValueMember = "ID";
            CategoryComboBox.SelectedIndex = -1;
        }


        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                if (!double.TryParse(DiscountTxtBox.Text, out double discount))
                {
                    MessageBox.Show("Enter decimal value in Discount");
                    return;
                }

                if (!double.TryParse(PriceTxtBox.Text, out double price))
                {
                    MessageBox.Show("Enter decimal value in Price");
                    return;
                }

                if (!int.TryParse(QuantityTxtBox.Text, out int quantity))
                {
                    MessageBox.Show("Enter integer value in Quantity");
                    return;
                }

                var product = ProductFactory.CreateProduct(
                    ProductNameTxtBox.Text,
                    DescriptionTxtBox.Text,
                    CategoryComboBox.SelectedValue.ToString(),
                    discount,
                    price,
                    quantity
                );

                await _winDB.Products.AddAsync(product);
                await _winDB.SaveChangesAsync();

                FormFunctions.ClearForm(this.Controls);
                MessageBox.Show("Product Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
            finally
            {
                this.Enabled = true;
            }
        }
        Random random = new Random();

       


        private void AddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.dashboard.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
