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
using Microsoft.EntityFrameworkCore.InMemory;


namespace NSU_PMS.Forms.Client
{

    public class ClientService
    {
        private readonly WinformDbContext _context;

        public ClientService(WinformDbContext context)
        {
            _context = context;
        }

        public async Task<string> AddClientAsync(string name, string address, string phone, string email, string comments)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(phone) || !FormFunctions.IsAllDigits(phone) || !FormFunctions.IsEmailValid(email))
            {
                return "All fields are not correct";
            }

            var client = new Models.Client
            {
                Id = "CLI-" + Guid.NewGuid().ToString().Substring(0, 8),
                Name = name,
                Address = address,
                Phone = phone,
                Email = email,
                Comments = comments
            };

            await _context.Clients.AddAsync(client);
            await _context.SaveChangesAsync();

            return "Success";
        }
    }
    public static class ClientServiceTest
    {
        public static async Task RunBasicTests()
        {
            var options = new DbContextOptionsBuilder<WinformDbContext>()
                .UseInMemoryDatabase("TestDb") // ✅ In-memory database for testing
                .Options;

            using var context = new WinformDbContext(options);
            var service = new ClientService(context);

            var result1 = await service.AddClientAsync("Alice", "123 Road", "01812345678", "alice@example.com", "Testing");
            MessageBox.Show("Test 1: Correct - " + result1); // Expected: "Success"

            var result2 = await service.AddClientAsync("Bruto", "abc street", "asdf016354", "br@g.com", "bru123");
            MessageBox.Show("Test 2: Phone Fail - " + result2); 

            var result3 = await service.AddClientAsync("Ben", "abc street", "01634387858", "g.com", "bru123");
            MessageBox.Show("Test 3: Email Fail - " + result2); 

            var result4 = await service.AddClientAsync("", "", "", "", "");
            MessageBox.Show("Test 4: Null Fail - " + result2); 

        }
    }



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


                // same conditions to check as the test 
                if (string.IsNullOrWhiteSpace(NameTxtBox.Text) || string.IsNullOrWhiteSpace(AddressTxtBox.Text) ||
                string.IsNullOrWhiteSpace(PhoneTxtBox.Text) || !FormFunctions.IsAllDigits(PhoneTxtBox.Text) || !FormFunctions.IsEmailValid(EmailTxtBox.Text))

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

        private async void AddClient_Load(object sender, EventArgs e)
        {
#if DEBUG
            // going to test
            await ClientServiceTest.RunBasicTests();
#endif
        }

    }
}
