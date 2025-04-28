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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class productForm : Form
    {
        static readonly IBL s_bl = Factory.Get();

        public productForm()
        {
            InitializeComponent();
            foreach (var c in Enum.GetValues(typeof(Categories)))
            {
                comboBoxCategory.Items.Add(c);
                comboBoxCategory2.Items.Add(c);

            }
            listBoxInSide.DataSource = s_bl.Product.ReadAll().SelectMany(p => p.ConvertToDOProduct().ToStringProperty().Split("\n")).ToList();
            listBoxAllProducts.DataSource = s_bl.Product.ReadAll().SelectMany(c => c.ConvertToDOProduct().ToStringProperty().Split("\n")).ToList();

        }

        private void chooseProductId_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = (int)numericUpDownProductId.Value;
                productDetails.Items.Clear();
                productDetails.Items.Add(s_bl.Product.Read(productId).ConvertToDOProduct().ToStringProperty());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFilterProductByName_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxAllProducts.DataSource = s_bl.Product.ReadAll(p => p.ProductName.Contains(filterProductValue.Text)).Select(p => p.ConvertToDOProduct().ToStringProperty()).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (productNameInput.Text == "" || productPriceInput.Text == "" || productQuantityInput.Text == "")
                    MessageBox.Show("כל השדות חובה!");
                else
                {
                    Product product = new BO.Product
                    {
                        ProductName = productNameInput.Text,
                        ProductPrice = double.TryParse(productPriceInput.Text, out double price) ? (double?)price : null,
                        ProductQuantity = int.TryParse(productQuantityInput.Text, out int quantity) ? (int?)quantity : null,
                        Category = (Categories)Enum.Parse(typeof(Categories), comboBoxCategory.SelectedItem.ToString())
                    };

                    s_bl.Product.Create(product);
                    listBoxInSide.DataSource = s_bl.Product.ReadAll().SelectMany(p => p.ConvertToDOProduct().ToStringProperty().Split("\n")).ToList();
                    productNameInput.Text = "";
                    productNameInput.Text = "";
                    productPriceInput.Text = "";
                    productQuantityInput.Text = "";
                    comboBoxCategory.SelectedIndex = -1;

                    MessageBox.Show("המוצר נוסף בהצלחה");
                    upDateListBoxAllProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void upDateListBoxAllProducts()
        {
            try
            {
                listBoxAllProductsInSide.DataSource = ""; // Update as needed
                listBoxInSide.DataSource = s_bl.Product.ReadAll().SelectMany(p => p.ConvertToDOProduct().ToStringProperty().Split("\n")).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(productIdUpdate.Text);
                BO.Product product = s_bl.Product.Read(productId);

                product.ProductName = productNameInputUpdate.Text != null ? productNameInputUpdate.Text : product.ProductName;
                product.ProductPrice = double.TryParse(productPriceInputUpdate.Text, out double price) ? (double?)price : product.ProductPrice;
                product.ProductQuantity = int.TryParse(productQuantityInputUpdate.Text, out int quantity) ? (int?)quantity : product.ProductQuantity;
                product.Category = (BO.Categories)Enum.Parse(typeof(BO.Categories), comboBoxCategory2.SelectedItem.ToString()); // Assuming you have a way to select the category

                s_bl.Product.Update(product);
                listBoxInSide.DataSource = s_bl.Product.ReadAll().SelectMany(p => p.ConvertToDOProduct().ToStringProperty().Split("\n")).ToList();
                productIdUpdate.Text = "";
                productNameInputUpdate.Text = "";
                productPriceInputUpdate.Text = "";
                productQuantityInputUpdate.Text = "";
                comboBoxCategory2.SelectedIndex = -1 ;
                MessageBox.Show("המוצר עודכן בהצלחה");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(productID.Text);
                s_bl.Product.Delete(productId);
                listBoxInSide.DataSource = s_bl.Product.ReadAll().SelectMany(p => p.ConvertToDOProduct().ToStringProperty().Split("\n")).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InsertDetailOfProduct(object sender, EventArgs e)
        {
            try
            {
                int id = (int)(int.TryParse(productIdUpdate.Text, out int quantity) ? (int?)quantity : null);
                BO.Product product = s_bl.Product.Read(id);
                productNameInputUpdate.Text = product.ProductName;
                productPriceInputUpdate.Text = product.ProductPrice.ToString();
                productQuantityInputUpdate.Text = product.ProductQuantity.ToString();
                comboBoxCategory2.SelectedIndex = (int)(product.Category.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}