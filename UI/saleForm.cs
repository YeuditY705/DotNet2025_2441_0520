using BlApi;
using BO;
using DO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class saleForm : Form
    {
        static readonly IBL s_bl = Factory.Get();

        public saleForm()
        {
            InitializeComponent();


            listBoxInSide.DataSource = s_bl.Sale.ReadAll().SelectMany(s => s.ConvertToDOSale().ToStringProperty().Split("\n")).ToList();
            listBoxAllSales.DataSource = s_bl.Sale.ReadAll().SelectMany(c => c.ConvertToDOSale().ToStringProperty().Split("\n")).ToList();
        }

        private void chooseSaleId_Click(object sender, EventArgs e)
        {
            try
            {
                int saleId = (int)numericUpDownSaleId.Value;
                saleDetails.Items.Clear();
                saleDetails.Items.Add(s_bl.Sale.Read(saleId).ConvertToDOSale().ToStringProperty());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFilterSaleByName_Click(object sender, EventArgs e)
        {
            listBoxAllSales.DataSource = s_bl.Sale.ReadAll(s => s.IsForEveryOne == checkBoxIsForEveryOne.Checked).Select(s => s.ConvertToDOSale().ToStringProperty()).ToList();
        }

        private void addSaleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (productIdInput.Text == "" || salePriceInput.Text == "" || saleQuantityInput.Text == "")
                    MessageBox.Show("כל השדות חובה!");
                else
                {
                    BO.Sale sale = new BO.Sale
                    {
                        ProductId = (int)(int.TryParse(productIdInput.Text, out int ProductId) ? (int?)ProductId : null),
                        PriceInSale = (double)(double.TryParse(salePriceInput.Text, out double PriceInSale) ? (int?)PriceInSale : null),
                        QuantityForSale = (int)(int.TryParse(saleQuantityInput.Text, out int QuantityForSale) ? (int?)QuantityForSale : null),
                        IsForEveryOne = isForEveryone.Checked,
                        StartDateForSale = dateTimeStart.Value,
                        EndDateForSale = dateTimeEnd.Value,


                    };
                    productIdInput.Text = "";
                    productIdInput.Text = "";
                    salePriceInput.Text = "";
                    saleQuantityInput.Text = "";
                    isForEveryone.Checked = false;

                    dateTimeStart.Value = DateTime.Now;
                    dateTimeEnd.Value = DateTime.Now;
                    s_bl.Sale.Create(sale);
                    listBoxInSide.DataSource = s_bl.Sale.ReadAll().SelectMany(s => s.ConvertToDOSale().ToStringProperty().Split("\n")).ToList();
                    MessageBox.Show("המבצע נוסף בהצלחה");
                    upDateListBoxAllSales();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void upDateListBoxAllSales()
        {
            listBoxAllSalesInSide.DataSource = ""; // Update as needed
            listBoxInSide.DataSource = s_bl.Sale.ReadAll().SelectMany(s => s.ConvertToDOSale().ToStringProperty().Split("\n")).ToList();
        }

        private void buttonUpdateSale_Click(object sender, EventArgs e)
        {
            try
            {
                int saleId = int.Parse(saleIdUpdate.Text);
                BO.Sale sale = s_bl.Sale.Read(saleId);

                sale.ProductId = (int)(int.TryParse(productIdInputaUpdate.Text, out int p) ? (int?)p : null);
                sale.PriceInSale = (double)(double.TryParse(salePriceInputUpdate.Text, out double PriceInSale) ? (int?)PriceInSale : null);
                sale.QuantityForSale = (int)(int.TryParse(saleQuantityInputUpdate.Text, out int QuantityForSale) ? (int?)QuantityForSale : null);
                sale.IsForEveryOne = checkBoxIsForEveryOneUpdate.Checked;
                sale.StartDateForSale = dateTimeStartUpdate.Value;
                sale.EndDateForSale = dateTimeEndUpdate.Value;

                s_bl.Sale.Update(sale);
                listBoxInSide.DataSource = s_bl.Sale.ReadAll().SelectMany(s => s.ConvertToDOSale().ToStringProperty().Split("\n")).ToList();
                saleIdUpdate.Text = "";
                productIdInputaUpdate.Text = "";
                salePriceInputUpdate.Text = "";
                saleQuantityInputUpdate.Text = "";
                checkBoxIsForEveryOneUpdate.Checked = false;

                dateTimeStartUpdate.Value = DateTime.Now;
                dateTimeEndUpdate.Value = DateTime.Now;
                MessageBox.Show("המבצע עודכן בהצלחה");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void deleteSaleButton_Click(object sender, EventArgs e)
        {
            try
            {
                int saleId = int.Parse(saleID.Text);
                s_bl.Sale.Delete(saleId);
                listBoxInSide.DataSource = s_bl.Sale.ReadAll().SelectMany(s => s.ConvertToDOSale().ToStringProperty().Split("\n")).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InsertDetailOfSale(object sender, EventArgs e)
        {
            int saleId = int.Parse(saleIdUpdate.Text);
            BO.Sale sale = s_bl.Sale.Read(saleId);
            productIdInputaUpdate.Text = sale.ProductId.ToString();
            salePriceInputUpdate.Text = sale.PriceInSale.ToString();
            saleQuantityInputUpdate.Text = sale.QuantityForSale.ToString();
            checkBoxIsForEveryOneUpdate.Checked = sale.IsForEveryOne ?? false;

            dateTimeStartUpdate.Value = sale.StartDateForSale ?? DateTime.Now;
            dateTimeEndUpdate.Value = sale.EndDateForSale ?? DateTime.Now;



        }
    }
}
