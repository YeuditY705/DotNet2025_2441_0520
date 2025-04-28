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
    public partial class startOrder : Form
    {
        public startOrder()
        {


            InitializeComponent();
        }

        private void startOrderButton_Click(object sender, EventArgs e)
        {
            int id = (int)(int.TryParse(customerIdInput.Text, out int customerid) ? (int?)customerid : null);

            orderForm form = new orderForm();
            form.CustomerId = id;
            form.InitializeOrder(); // קריאה למתודה ליצירת ההזמנה
            form.Show();
        }
    }
    }
