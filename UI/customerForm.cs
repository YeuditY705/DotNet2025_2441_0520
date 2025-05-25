using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class customerForm : Form
    {
        static readonly IBL s_bl = Factory.Get();

        public customerForm()
        {
          
                InitializeComponent();
                listBoxInSide.DataSource = s_bl.Customer.ReadAll().SelectMany(c => c.ToStringProperty().Split("\n")).ToList();
                listBoxAllCustomers.DataSource = s_bl.Customer.ReadAll().SelectMany(c => c.ToStringProperty().Split("\n")).ToList();
           
        }



        private void chooseCustomerId_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId = (int)numericUpDownCustomerId.Value;
                customerDetails.Items.Clear();
                List<Customer> customers = new List<Customer>();
                customers.Add(s_bl.Customer.Read(customerId));
                customerDetails.DataSource = (customers.SelectMany(p => p.ConvertToDOCustomer().ToStringProperty().Split("\n")).ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFilterCustomerByName_Click(object sender, EventArgs e)
        {
            listBoxAllCustomers.DataSource = s_bl.Customer.ReadAll(c => c.CustomerName.Contains(filterCustomerValue.Text)).SelectMany(c => c.ToStringProperty().Split("\n")).ToList();
        }
        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerIdInput.Text == "0" || customerNameInput.Text == "" || customerPhoneInput.Text == "" || customerAddressInput.Text == "")
                    MessageBox.Show("כל השדות חובה!");

                else
                {
                    //addCustomerButton.BackColor = Color.Red;
                    BO.Customer customer = new BO.Customer();
                    customer.CustomerName = customerNameInput.Text;
                    int customerId;
                    int.TryParse(customerIdInput.Text, out customerId);
                    customer.CustomerId = customerId;
                    customer.CustomerAddress = customerAddressInput.Text;
                    customer.CustomerPhone = customerPhoneInput.Text;
                    s_bl.Customer.Create(customer);
                    listBoxInSide.DataSource = s_bl.Customer.ReadAll().SelectMany(c => c.ToStringProperty().Split("\n")).ToList();
                    customerIdInput.Text = "";
                    customerNameInput.Text = "";
                    customerAddressInput.Text = "";
                    customerPhoneInput.Text = "";
                    MessageBox.Show("הלקוח נוסף בהצלחה");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId;
                int.TryParse(customerIdUpdate.Text, out customerId);
                BO.Customer customer = s_bl.Customer.Read(customerId);
                customer.CustomerName = customerNameInputUpdate.Text != null ? customerNameInputUpdate.Text : customer.CustomerName;
                customer.CustomerAddress = customerAddressInputUpdate.Text != null ? customerAddressInputUpdate.Text : customer.CustomerAddress;
                customer.CustomerPhone = customerPhoneInputUpdate.Text != null ? customerPhoneInputUpdate.Text : customer.CustomerPhone;
                s_bl.Customer.Update(customer);
                listBoxInSide.DataSource = s_bl.Customer.ReadAll().SelectMany(c => c.ToStringProperty().Split("\n")).ToList();
                customerIdUpdate.Text = "";
                customerNameInputUpdate.Text = "";
                customerAddressInputUpdate.Text = "";
                customerPhoneInputUpdate.Text = "";
                MessageBox.Show("הלקוח עודכן בהצלחה");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {

                int customerId;
                int.TryParse(customerID.Text, out customerId);
                s_bl.Customer.Delete(customerId);
                listBoxInSide.DataSource = s_bl.Customer.ReadAll().SelectMany(c => c.ToStringProperty().Split("\n")).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void InsertDetailOfCustomer(object sender, EventArgs e)
        {
            try
            {
                int customerId;
                int.TryParse(customerIdUpdate.Text, out customerId);
                BO.Customer customer = s_bl.Customer.Read(customerId);
                customerNameInputUpdate.Text = customer.CustomerName;
                customerAddressInputUpdate.Text = customer.CustomerAddress;
                customerPhoneInputUpdate.Text = customer.CustomerPhone;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
