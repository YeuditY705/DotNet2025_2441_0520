using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlApi;
using BO;


namespace UI
{
    public partial class orderForm : Form
    {
        static readonly IBL s_bl = Factory.Get();
        Order order;
        List<SaleInProduct> sales = new List<SaleInProduct>();
        public int CustomerId { get; set; }
        public orderForm()
        {
            InitializeComponent();
            allProductsInSide.DataSource = s_bl.Product.ReadAll().SelectMany(p => p.ConvertToDOProduct().ToStringProperty().Split("\n")).ToList();
            order = new Order(s_bl.Customer.IsExistsCustomer(CustomerId));

        }
        public void InitializeOrder()
        {
            if (s_bl.Customer.IsExistsCustomer(CustomerId))
            {
                order = new Order(s_bl.Customer.IsExistsCustomer(CustomerId));
                if (order.IsPreferredCustomer)
                {
                    String customerName = s_bl.Customer.Read(CustomerId).CustomerName;
                    helloCustomerName.Text = $" hello {customerName}";
                }
            }
            else
            {
                MessageBox.Show("😒חבל שאתה לא חבר מועדון😒");
            }
        }
       

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(productIdInput.Text);
            int count = int.Parse(quantityInput.Text);
            sales = s_bl.Order.AddProductToOrder(order, productId, count);
            productsInOrderListBox.DataSource = order.ProductInOrder.SelectMany(p => p.ToStringProperty().Split("\n")).ToList();
            finalPriceLabel.Text = order.FinalPrice.ToString();


        }

        private void finishOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("הזמנתך נקלטה בהצלחה!!!");

        }

    }
}

