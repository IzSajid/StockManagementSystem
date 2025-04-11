using NSU_PMS.Forms.Client;
using NSU_PMS.Forms.Employee;
using NSU_PMS.Forms.Products;
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
    public partial class DashBoard : Form
    {

        public class FormNavigator
        {
            private static readonly FormNavigator _instance = new FormNavigator();

            private FormNavigator() { }

            public static FormNavigator Instance => _instance;

            public void OpenAddProduct(Form currentForm)
            {
                currentForm.Hide();
                new AddProduct().Show();
            }

            public void OpenAddCategory(Form currentForm)
            {
                currentForm.Hide();
                new AddCategory().Show();
            }

            public void OpenAddEmployee(Form currentForm)
            {
                currentForm.Hide();
                new AddEmployee().Show();
            }

            public void OpenAddClient(Form currentForm)
            {
                currentForm.Hide();
                new AddClient().Show();
            }

            public void OpenSales(Form currentForm)
            {
                currentForm.Hide();
                new Sales().Show();
            }

            public void OpenAllClients(Form currentForm)
            {
                currentForm.Hide();
                new AllClients().Show();
            }

            public void OpenAllEmployees(Form currentForm)
            {
                currentForm.Hide();
                new AllEmployees().Show();
            }

            public void OpenAllProducts(Form currentForm)
            {
                currentForm.Hide();
                new AllProducts().Show();
            }

            public void OpenAllSales(Form currentForm)
            {
                currentForm.Hide();
                new AllSales().Show();
            }

            public void ExitApplication(Form currentForm)
            {
                Global.signin.Close();
               // currentForm.Close();
            }
        }


        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            FormNavigator.Instance.OpenAddProduct(this);
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            FormNavigator.Instance.OpenAddCategory(this);
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            FormNavigator.Instance.OpenAddEmployee(this);
        }

        private void AddClientBtn_Click(object sender, EventArgs e)
        {
            FormNavigator.Instance.OpenAddClient(this);
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            FormNavigator.Instance.OpenSales(this);
        }

        private void SeeClientsBtn_Click(object sender, EventArgs e)
        {
            FormNavigator.Instance.OpenAllClients(this);
        }

        private void AllEmpBtn_Click(object sender, EventArgs e)
        {
            FormNavigator.Instance.OpenAllEmployees(this);
        }

        private void AllProductsBtn_Click(object sender, EventArgs e)
        {
            FormNavigator.Instance.OpenAllProducts(this);
        }

        private void SeeSalesBtn_Click(object sender, EventArgs e)
        {
            FormNavigator.Instance.OpenAllSales(this);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            FormNavigator.Instance.ExitApplication(this);
        }

        private void DashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormNavigator.Instance.ExitApplication(this);
        }

    }
}
