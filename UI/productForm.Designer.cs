namespace UI
{
    partial class productForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            productQuantityInput = new TextBox();
            addProduct = new TabPage();
            label13 = new Label();
            comboBoxCategory = new ComboBox();
            label12 = new Label();
            listBoxAllProductsInSide = new ListBox();
            addProductButton = new Button();
            productPriceInput = new TextBox();
            productNameInput = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            productsMenu = new TabControl();
            readProduct = new TabPage();
            productDetails = new ListBox();
            chooseProductId = new Button();
            label1 = new Label();
            numericUpDownProductId = new NumericUpDown();
            readAllProducts = new TabPage();
            buttonFilterProductByName = new Button();
            filterProductValue = new TextBox();
            label3 = new Label();
            label2 = new Label();
            listBoxAllProducts = new ListBox();
            updateProduct = new TabPage();
            label14 = new Label();
            comboBoxCategory2 = new ComboBox();
            label15 = new Label();
            productQuantityInputUpdate = new TextBox();
            buttonUpdateProduct = new Button();
            productPriceInputUpdate = new TextBox();
            productNameInputUpdate = new TextBox();
            label10 = new Label();
            label11 = new Label();
            productIdUpdate = new TextBox();
            label9 = new Label();
            deleteProduct = new TabPage();
            deleteProductButton = new Button();
            productID = new TextBox();
            label8 = new Label();
            listBoxInSide = new ListBox();
            addProduct.SuspendLayout();
            productsMenu.SuspendLayout();
            readProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductId).BeginInit();
            readAllProducts.SuspendLayout();
            updateProduct.SuspendLayout();
            deleteProduct.SuspendLayout();
            SuspendLayout();
            // 
            // productQuantityInput
            // 
            productQuantityInput.Location = new Point(163, 121);
            productQuantityInput.Name = "productQuantityInput";
            productQuantityInput.Size = new Size(100, 23);
            productQuantityInput.TabIndex = 0;
            // 
            // addProduct
            // 
            addProduct.Controls.Add(label13);
            addProduct.Controls.Add(comboBoxCategory);
            addProduct.Controls.Add(label12);
            addProduct.Controls.Add(listBoxAllProductsInSide);
            addProduct.Controls.Add(addProductButton);
            addProduct.Controls.Add(productPriceInput);
            addProduct.Controls.Add(productNameInput);
            addProduct.Controls.Add(label7);
            addProduct.Controls.Add(label6);
            addProduct.Controls.Add(label4);
            addProduct.Controls.Add(productQuantityInput);
            addProduct.Location = new Point(4, 24);
            addProduct.Name = "addProduct";
            addProduct.Padding = new Padding(3);
            addProduct.Size = new Size(458, 351);
            addProduct.TabIndex = 0;
            addProduct.Text = "הוספת מוצר";
            addProduct.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(269, 100);
            label13.Name = "label13";
            label13.Size = new Size(52, 15);
            label13.TabIndex = 12;
            label13.Text = "קטגוריה:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(163, 97);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(100, 23);
            comboBoxCategory.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(269, 124);
            label12.Name = "label12";
            label12.Size = new Size(37, 15);
            label12.TabIndex = 10;
            label12.Text = "כמות:";
            // 
            // listBoxAllProductsInSide
            // 
            listBoxAllProductsInSide.BackColor = Color.Red;
            listBoxAllProductsInSide.FormattingEnabled = true;
            listBoxAllProductsInSide.ItemHeight = 15;
            listBoxAllProductsInSide.Location = new Point(491, 151);
            listBoxAllProductsInSide.Margin = new Padding(3, 2, 3, 2);
            listBoxAllProductsInSide.Name = "listBoxAllProductsInSide";
            listBoxAllProductsInSide.Size = new Size(258, 364);
            listBoxAllProductsInSide.TabIndex = 1;
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(163, 193);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(75, 23);
            addProductButton.TabIndex = 8;
            addProductButton.Text = "הוספה";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click;
            // 
            // productPriceInput
            // 
            productPriceInput.Location = new Point(163, 151);
            productPriceInput.Name = "productPriceInput";
            productPriceInput.Size = new Size(100, 23);
            productPriceInput.TabIndex = 7;
            // 
            // productNameInput
            // 
            productNameInput.Location = new Point(163, 68);
            productNameInput.Name = "productNameInput";
            productNameInput.Size = new Size(100, 23);
            productNameInput.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(269, 154);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 3;
            label7.Text = "מחיר:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(269, 71);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 1;
            label6.Text = "שם:";
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 9;
            // 
            // productsMenu
            // 
            productsMenu.Controls.Add(readProduct);
            productsMenu.Controls.Add(readAllProducts);
            productsMenu.Controls.Add(addProduct);
            productsMenu.Controls.Add(updateProduct);
            productsMenu.Controls.Add(deleteProduct);
            productsMenu.Location = new Point(2, 24);
            productsMenu.Name = "productsMenu";
            productsMenu.RightToLeft = RightToLeft.Yes;
            productsMenu.RightToLeftLayout = true;
            productsMenu.SelectedIndex = 0;
            productsMenu.Size = new Size(466, 379);
            productsMenu.TabIndex = 0;
            // 
            // readProduct
            // 
            readProduct.Controls.Add(productDetails);
            readProduct.Controls.Add(chooseProductId);
            readProduct.Controls.Add(label1);
            readProduct.Controls.Add(numericUpDownProductId);
            readProduct.Location = new Point(4, 24);
            readProduct.Name = "readProduct";
            readProduct.Size = new Size(458, 351);
            readProduct.TabIndex = 2;
            readProduct.Text = "פרטי מוצר";
            readProduct.UseVisualStyleBackColor = true;
            // 
            // productDetails
            // 
            productDetails.Cursor = Cursors.IBeam;
            productDetails.FormattingEnabled = true;
            productDetails.ItemHeight = 15;
            productDetails.Location = new Point(137, 98);
            productDetails.Name = "productDetails";
            productDetails.Size = new Size(292, 169);
            productDetails.TabIndex = 3;
            // 
            // chooseProductId
            // 
            chooseProductId.Location = new Point(43, 16);
            chooseProductId.Name = "chooseProductId";
            chooseProductId.Size = new Size(75, 23);
            chooseProductId.TabIndex = 2;
            chooseProductId.Text = "אישור";
            chooseProductId.UseVisualStyleBackColor = true;
            chooseProductId.Click += chooseProductId_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 25);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "הכנס מזהה מוצר";
            // 
            // numericUpDownProductId
            // 
            numericUpDownProductId.Location = new Point(151, 20);
            numericUpDownProductId.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownProductId.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownProductId.Name = "numericUpDownProductId";
            numericUpDownProductId.Size = new Size(120, 23);
            numericUpDownProductId.TabIndex = 0;
            numericUpDownProductId.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // readAllProducts
            // 
            readAllProducts.Controls.Add(buttonFilterProductByName);
            readAllProducts.Controls.Add(filterProductValue);
            readAllProducts.Controls.Add(label3);
            readAllProducts.Controls.Add(label2);
            readAllProducts.Controls.Add(listBoxAllProducts);
            readAllProducts.Location = new Point(4, 24);
            readAllProducts.Name = "readAllProducts";
            readAllProducts.Size = new Size(458, 351);
            readAllProducts.TabIndex = 3;
            readAllProducts.Text = "פרטי כל המוצרים";
            readAllProducts.UseVisualStyleBackColor = true;
            // 
            // buttonFilterProductByName
            // 
            buttonFilterProductByName.Location = new Point(71, 54);
            buttonFilterProductByName.Margin = new Padding(3, 2, 3, 2);
            buttonFilterProductByName.Name = "buttonFilterProductByName";
            buttonFilterProductByName.Size = new Size(82, 22);
            buttonFilterProductByName.TabIndex = 4;
            buttonFilterProductByName.Text = "אישור";
            buttonFilterProductByName.UseVisualStyleBackColor = true;
            buttonFilterProductByName.Click += buttonFilterProductByName_Click;
            // 
            // filterProductValue
            // 
            filterProductValue.Location = new Point(177, 56);
            filterProductValue.Name = "filterProductValue";
            filterProductValue.Size = new Size(100, 23);
            filterProductValue.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 58);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 2;
            label3.Text = "הכנס שם לסינון";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(482, 66);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 1;
            label2.Text = "פרטי כל המוצרים:";
            // 
            // listBoxAllProducts
            // 
            listBoxAllProducts.FormattingEnabled = true;
            listBoxAllProducts.ItemHeight = 15;
            listBoxAllProducts.Location = new Point(19, 95);
            listBoxAllProducts.Name = "listBoxAllProducts";
            listBoxAllProducts.Size = new Size(367, 229);
            listBoxAllProducts.TabIndex = 0;
            // 
            // updateProduct
            // 
            updateProduct.Controls.Add(label14);
            updateProduct.Controls.Add(comboBoxCategory2);
            updateProduct.Controls.Add(label15);
            updateProduct.Controls.Add(productQuantityInputUpdate);
            updateProduct.Controls.Add(buttonUpdateProduct);
            updateProduct.Controls.Add(productPriceInputUpdate);
            updateProduct.Controls.Add(productNameInputUpdate);
            updateProduct.Controls.Add(label10);
            updateProduct.Controls.Add(label11);
            updateProduct.Controls.Add(productIdUpdate);
            updateProduct.Controls.Add(label9);
            updateProduct.Location = new Point(4, 24);
            updateProduct.Name = "updateProduct";
            updateProduct.Padding = new Padding(3);
            updateProduct.Size = new Size(458, 351);
            updateProduct.TabIndex = 1;
            updateProduct.Text = "עדכון מוצר";
            updateProduct.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(265, 125);
            label14.Name = "label14";
            label14.Size = new Size(52, 15);
            label14.TabIndex = 21;
            label14.Text = "קטגוריה:";
            // 
            // comboBoxCategory2
            // 
            comboBoxCategory2.FormattingEnabled = true;
            comboBoxCategory2.Location = new Point(159, 122);
            comboBoxCategory2.Name = "comboBoxCategory2";
            comboBoxCategory2.Size = new Size(100, 23);
            comboBoxCategory2.TabIndex = 20;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(265, 149);
            label15.Name = "label15";
            label15.Size = new Size(37, 15);
            label15.TabIndex = 19;
            label15.Text = "כמות:";
            // 
            // productQuantityInputUpdate
            // 
            productQuantityInputUpdate.Location = new Point(159, 146);
            productQuantityInputUpdate.Name = "productQuantityInputUpdate";
            productQuantityInputUpdate.Size = new Size(100, 23);
            productQuantityInputUpdate.TabIndex = 18;
            // 
            // buttonUpdateProduct
            // 
            buttonUpdateProduct.Location = new Point(159, 217);
            buttonUpdateProduct.Name = "buttonUpdateProduct";
            buttonUpdateProduct.Size = new Size(75, 23);
            buttonUpdateProduct.TabIndex = 17;
            buttonUpdateProduct.Text = "עדכון";
            buttonUpdateProduct.UseVisualStyleBackColor = true;
            buttonUpdateProduct.Click += buttonUpdateProduct_Click;
            // 
            // productPriceInputUpdate
            // 
            productPriceInputUpdate.Location = new Point(159, 175);
            productPriceInputUpdate.Name = "productPriceInputUpdate";
            productPriceInputUpdate.Size = new Size(100, 23);
            productPriceInputUpdate.TabIndex = 16;
            // 
            // productNameInputUpdate
            // 
            productNameInputUpdate.Location = new Point(159, 93);
            productNameInputUpdate.Name = "productNameInputUpdate";
            productNameInputUpdate.Size = new Size(100, 23);
            productNameInputUpdate.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(266, 178);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 12;
            label10.Text = "מחיר:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(266, 96);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 10;
            label11.Text = "שם:";
            // 
            // productIdUpdate
            // 
            productIdUpdate.Location = new Point(159, 36);
            productIdUpdate.Name = "productIdUpdate";
            productIdUpdate.Size = new Size(100, 23);
            productIdUpdate.TabIndex = 4;
            productIdUpdate.Leave += InsertDetailOfProduct;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(295, 44);
            label9.Name = "label9";
            label9.Size = new Size(102, 15);
            label9.TabIndex = 3;
            label9.Text = "הכנס מזהה לעדכון";
            // 
            // deleteProduct
            // 
            deleteProduct.Controls.Add(deleteProductButton);
            deleteProduct.Controls.Add(productID);
            deleteProduct.Controls.Add(label8);
            deleteProduct.Location = new Point(4, 24);
            deleteProduct.Name = "deleteProduct";
            deleteProduct.Size = new Size(458, 351);
            deleteProduct.TabIndex = 4;
            deleteProduct.Text = "מחיקת מוצר";
            deleteProduct.UseVisualStyleBackColor = true;
            // 
            // deleteProductButton
            // 
            deleteProductButton.Location = new Point(62, 45);
            deleteProductButton.Name = "deleteProductButton";
            deleteProductButton.Size = new Size(75, 23);
            deleteProductButton.TabIndex = 2;
            deleteProductButton.Text = "אישור";
            deleteProductButton.UseVisualStyleBackColor = true;
            deleteProductButton.Click += deleteProductButton_Click;
            // 
            // productID
            // 
            productID.Location = new Point(163, 42);
            productID.Name = "productID";
            productID.Size = new Size(100, 23);
            productID.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(282, 45);
            label8.Name = "label8";
            label8.Size = new Size(111, 15);
            label8.TabIndex = 0;
            label8.Text = "הכנס מזהה למחיקה";
            // 
            // listBoxInSide
            // 
            listBoxInSide.BackColor = SystemColors.Window;
            listBoxInSide.BorderStyle = BorderStyle.FixedSingle;
            listBoxInSide.Cursor = Cursors.Hand;
            listBoxInSide.Font = new Font("Segoe UI", 9F);
            listBoxInSide.ForeColor = SystemColors.WindowText;
            listBoxInSide.FormattingEnabled = true;
            listBoxInSide.ItemHeight = 15;
            listBoxInSide.Location = new Point(481, 53);
            listBoxInSide.Margin = new Padding(3, 2, 3, 2);
            listBoxInSide.Name = "listBoxInSide";
            listBoxInSide.Size = new Size(308, 347);
            listBoxInSide.TabIndex = 1;
            listBoxInSide.Tag = "";
            // 
            // productForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 488);
            Controls.Add(listBoxInSide);
            Controls.Add(productsMenu);
            Name = "productForm";
            Text = "productForm";
            addProduct.ResumeLayout(false);
            addProduct.PerformLayout();
            productsMenu.ResumeLayout(false);
            readProduct.ResumeLayout(false);
            readProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductId).EndInit();
            readAllProducts.ResumeLayout(false);
            readAllProducts.PerformLayout();
            updateProduct.ResumeLayout(false);
            updateProduct.PerformLayout();
            deleteProduct.ResumeLayout(false);
            deleteProduct.PerformLayout();
            ResumeLayout(false);
        }

        private TabControl productsMenu;
        private TabPage addProduct;
        private TabPage updateProduct;
        private TabPage readProduct;
        private TabPage readAllProducts;
        private TabPage deleteProduct;
        private ListBox listBoxAllProducts;
        private NumericUpDown numericUpDownProductId;
        private Label label1;
        private Button chooseProductId;
        private ListBox productDetails;
        private Label label2;
        private Label label3;
        private TextBox filterProductValue;
        private Label label7;
        private Label label6;
        private Label label4;
        private TextBox productPriceInput;
        private TextBox productNameInput;
        private Button addProductButton;
        private TextBox productIdUpdate;
        private Label label9;
        private Button deleteProductButton;
        private TextBox productID;
        private Label label8;
        private Button buttonUpdateProduct;
        private TextBox productPriceInputUpdate;
        private TextBox productNameInputUpdate;
        private Label label10;
        private Label label11;
        private ListBox listBoxAllProductsInSide;
        private ListBox listBoxInSide;
        private Button buttonFilterProductByName;
        private TextBox productQuantityInput;
        //private ComboBox categoryComboBox;
        private Label label12;
        private Label label13;
        private ComboBox comboBoxCategory;
        private Label label14;
        private ComboBox comboBoxCategory2;
        private Label label15;
        private TextBox productQuantityInputUpdate;
    }
}