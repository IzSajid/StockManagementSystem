using Microsoft.EntityFrameworkCore;
using NSU_PMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSU_PMS.Forms.General
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            KeyPreview = true;
        }
        WinformDbContext _windb = new WinformDbContext();
        private async void Sales_Load(object sender, EventArgs e)
        {
            ClientComboBox.DataSource = await _windb.Clients.ToListAsync();
            ClientComboBox.DisplayMember = "Name";
            ClientComboBox.SelectedIndex = -1;
            ClientComboBox.ValueMember = "ID";

            CategoryComboBox.DataSource = await _windb.Categories.ToListAsync();
            CategoryComboBox.DisplayMember = "Name";
            CategoryComboBox.SelectedIndex = -1;
            CategoryComboBox.ValueMember = "ID";


            this.ProductNameComboBox.Enabled = false;
            this.QuantityTxtBox.Enabled = false;
            this.button1.Enabled = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ClientComboBox.Enabled = false;
            if (FormFunctions.IsAllDigits(QuantityTxtBox.Text))
            {
                var product = await _windb.Products.Where(c => c.ID == ProductNameComboBox.SelectedValue).FirstOrDefaultAsync();
                var client = await _windb.Clients.Where(c => c.Id == ClientComboBox.SelectedValue).FirstOrDefaultAsync();

                var DecoProduct = new DiscountStrategy.Product
                {
                    ID = product.ID,
                    Name = product.Name,
                    Description = product.Description,
                    Category = product.Category,
                    Discount = product.Discount,
                    Quantity = product.Quantity,
                    Price = product.Price,
                    TotalValuation = product.TotalValuation,
                    Status = product.Status,
                    DateTime = product.DateTime,
                };

                if (DecoProduct != null)
                {
                    // Apply base discount if any
                    DiscountStrategy.IDiscount discountStrategy = new DiscountStrategy.NoDiscount();

                    // Apply product discount
                    if (DecoProduct.Discount > 0)
                    {
                        discountStrategy = new DiscountStrategy.PercentageDiscountDecorator(discountStrategy, DecoProduct.Discount);
                    }

                    // Apply client-specific discount
                    if (client != null)
                    {
                        discountStrategy = new DiscountStrategy.ClientDiscountDecorator(discountStrategy, 5);
                    }

                    // Set the discount strategy for the product
                    DecoProduct.SetDiscount(discountStrategy);
                    double disc = (DecoProduct.Price - DecoProduct.GetDiscountedPrice()) * int.Parse(QuantityTxtBox.Text);
                    double discPrice = (DecoProduct.GetDiscountedPrice() * int.Parse(QuantityTxtBox.Text));
                    double price = (DecoProduct.Price * int.Parse(QuantityTxtBox.Text));

                    ListViewItem newItem = new ListViewItem(new[]
                    {
                        DecoProduct.ID, DecoProduct.Name, QuantityTxtBox.Text,
                        disc.ToString(),
                        discPrice.ToString()
                });

                    DetailsListView.Items.Add(newItem);

                    CategoryComboBox.SelectedIndex = -1;
                    ProductNameComboBox.SelectedIndex = -1;
                    this.ProductNameComboBox.Enabled = false;
                    this.QuantityTxtBox.Enabled = false;
                    this.button1.Enabled = false;


                    if (!string.IsNullOrEmpty(TotalTxtBox.Text))
                    {
                        TotalTxtBox.Text = (double.Parse(TotalTxtBox.Text) + price).ToString();
                    }
                    else
                    {
                        TotalTxtBox.Text = price.ToString();
                    }

                    if (!string.IsNullOrEmpty(DiscountTxtBox.Text))
                    {
                        DiscountTxtBox.Text = (double.Parse(DiscountTxtBox.Text) + disc).ToString();
                    }
                    else
                    {
                        DiscountTxtBox.Text = disc.ToString();
                    }


                    if (!string.IsNullOrEmpty(GrandTotalTxtBox.Text))
                    {
                        GrandTotalTxtBox.Text = (double.Parse(GrandTotalTxtBox.Text) + discPrice).ToString();
                    }
                    else
                    {
                        GrandTotalTxtBox.Text = discPrice.ToString();
                    }


                    // Get the discounted price
                    double discountedPrice = DecoProduct.GetDiscountedPrice();
                    MessageBox.Show($"Original Price: {DecoProduct.Price}, Discounted Price: {discountedPrice}");
                }
            }
            else
            {
                MessageBox.Show("Quantity must be a whole Number");
            }
        }

        private void Sales_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.dashboard.Show();
        }


        private async void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex != -1)
            {
                try
                {
                    ProductNameComboBox.Enabled = false;
                    QuantityTxtBox.Enabled = false;
                    button1.Enabled = false;

                    var selectedCategory = CategoryComboBox.SelectedValue?.ToString();

                    if (!string.IsNullOrEmpty(selectedCategory))
                    {
                        // Use a new context instance to avoid concurrency issues
                        
                        {
                            var products = await _windb.Products
                                .Where(p => p.Category == selectedCategory)
                                .ToListAsync();

                            ProductNameComboBox.DataSource = products;
                            ProductNameComboBox.DisplayMember = "Name";
                            ProductNameComboBox.ValueMember = "ID";
                            ProductNameComboBox.SelectedIndex = -1;
                        }

                        ProductNameComboBox.Enabled = true;
                        QuantityTxtBox.Enabled = true;
                        button1.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading products: " + ex.Message);
                }
            }
            else
            {
                ProductNameComboBox.SelectedIndex = -1;
                ProductNameComboBox.Enabled = false;
                QuantityTxtBox.Enabled = false;
                button1.Enabled = false;
            }
        }


        private async void ClientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClientComboBox.SelectedIndex != -1)
            {
                try
                {
                    // Disable ComboBox to avoid multiple triggers while processing
                    ClientComboBox.Enabled = false;

                    var selectedId = ClientComboBox.SelectedValue?.ToString();

                    if (!string.IsNullOrEmpty(selectedId))
                    {
                        // Create a new DbContext instance
                        
                        {
                            var client = await _windb.Clients
                                .Where(c => c.Id == selectedId)
                                .FirstOrDefaultAsync();

                            if (client != null)
                            {
                                ClientInfoTxtBox.Text = $"Name: {client.Name}\r\nPhone: {client.Phone}\r\nEmail: {client.Email}";
                            }
                            else
                            {
                                ClientInfoTxtBox.Text = "Client not found.";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading client: " + ex.Message);
                }
                finally
                {
                    ClientComboBox.Enabled = true;
                }
            }
        }


        private void DetailsListView_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                foreach (ListViewItem List in DetailsListView.SelectedItems)
                {
                    double discount = double.Parse(List.SubItems[3].Text);
                    double discountPrice = double.Parse(List.SubItems[4].Text);
                    double price = discount + discountPrice;

                    DiscountTxtBox.Text = (double.Parse(DiscountTxtBox.Text) - discount).ToString();
                    GrandTotalTxtBox.Text = (double.Parse(GrandTotalTxtBox.Text) - discountPrice).ToString();
                    TotalTxtBox.Text = (double.Parse(TotalTxtBox.Text) - price).ToString();

                    List.Remove();
                }
            }
        }

        private async void SalesBtn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            double result;
            try
            {

                if (GrandTotalTxtBox.Text != null || GrandTotalTxtBox.Text != "")
                {
                    Random random = new Random();
                    string mid = "Sales-" + random.Next(10000, 99999) + "-" + random.Next(10000, 99999) + "-" + random.Next(10000, 99999);

                    string cid = "";
                    if (ClientComboBox.SelectedIndex != -1)
                    {
                        cid = ClientComboBox.SelectedValue.ToString();
                    }

                    await _windb.Sales.AddAsync(new Models.Sale
                    {
                        ID = mid,
                        ClientID = cid,
                        Quantity = int.Parse(ListViewFunctions.CalculateColumnSum(DetailsListView, 2).ToString()),
                        Total = double.Parse(TotalTxtBox.Text),
                        Discount = double.Parse(DiscountTxtBox.Text),
                        SubTotal = double.Parse(GrandTotalTxtBox.Text),
                        Status = "Active",
                        DateTime = DateTime.Now,

                    });


                    foreach (ListViewItem lv in DetailsListView.Items)
                    {
                        var product = await _windb.Products.Where(c => c.ID == lv.SubItems[0].Text).FirstOrDefaultAsync();
                        int quantitySold = int.Parse(lv.SubItems[2].Text);
                        product.Quantity -= quantitySold;
                        int q = quantitySold;
                                          

                        if (quantitySold > product.Quantity)
                        {
                            MessageBox.Show("Not Enough Products");
                            return;
                        }


                        double discount = double.Parse(lv.SubItems[3].Text);
                        double discountPrice = double.Parse(lv.SubItems[4].Text);
                        double price = discount + discountPrice;

                        await _windb.SalesDetails.AddAsync(new Models.SalesDetail
                        {
                            ID = "SalesDetails-" + random.Next(10000, 99999) + "-" + random.Next(10000, 99999) + "-" + random.Next(10000, 99999),
                            ProductID = mid,
                            Price = price,
                            Discount = discount,
                            Quantity = q,
                        });
                    }
                }

                await _windb.SaveChangesAsync();

                FormFunctions.ClearForm(this.Controls);
                MessageBox.Show("Product Added");
                DetailsListView.Items.Clear();
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

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
