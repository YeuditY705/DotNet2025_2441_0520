using BlApi;
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
    public partial class MainMenu : Form
    {
        static readonly IBL s_bl = Factory.Get();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void customersButton_Click_1(object sender, EventArgs e)
        {
            customerForm form = new customerForm();
            form.Show();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            productForm form = new productForm();
            form.Show();
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            saleForm form = new saleForm();
            form.Show();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            startOrder form = new startOrder();
            form.Show();
        }
    }
}
