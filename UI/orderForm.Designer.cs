namespace UI
{
    partial class orderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            allProductsInSide = new ListBox();
            productId = new Label();
            label1 = new Label();
            quantityInput = new NumericUpDown();
            productIdInput = new TextBox();
            addToOrderButton = new Button();
            productsInOrderListBox = new ListBox();
            label2 = new Label();
            finishOrder = new Button();
            label4 = new Label();
            finalPriceLabel = new Label();
            helloCustomerName = new Label();
            ((System.ComponentModel.ISupportInitialize)quantityInput).BeginInit();
            SuspendLayout();
            // 
            // allProductsInSide
            // 
            allProductsInSide.FormattingEnabled = true;
            allProductsInSide.ItemHeight = 15;
            allProductsInSide.Location = new Point(508, 5);
            allProductsInSide.Name = "allProductsInSide";
            allProductsInSide.Size = new Size(280, 454);
            allProductsInSide.TabIndex = 0;
            // 
            // productId
            // 
            productId.AutoSize = true;
            productId.Location = new Point(403, 76);
            productId.Name = "productId";
            productId.Size = new Size(52, 15);
            productId.TabIndex = 1;
            productId.Text = "קוד מוצר";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(403, 108);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "כמות";
            // 
            // quantityInput
            // 
            quantityInput.Location = new Point(288, 102);
            quantityInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            quantityInput.Name = "quantityInput";
            quantityInput.RightToLeft = RightToLeft.Yes;
            quantityInput.Size = new Size(100, 23);
            quantityInput.TabIndex = 3;
            quantityInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // productIdInput
            // 
            productIdInput.Location = new Point(288, 73);
            productIdInput.Name = "productIdInput";
            productIdInput.Size = new Size(100, 23);
            productIdInput.TabIndex = 4;
            // 
            // addToOrderButton
            // 
            addToOrderButton.Location = new Point(288, 131);
            addToOrderButton.Name = "addToOrderButton";
            addToOrderButton.Size = new Size(115, 23);
            addToOrderButton.TabIndex = 5;
            addToOrderButton.Text = "הוסף להזמנה";
            addToOrderButton.UseVisualStyleBackColor = true;
            addToOrderButton.Click += addToOrderButton_Click;
            // 
            // productsInOrderListBox
            // 
            productsInOrderListBox.FormattingEnabled = true;
            productsInOrderListBox.ItemHeight = 15;
            productsInOrderListBox.Location = new Point(12, 28);
            productsInOrderListBox.Name = "productsInOrderListBox";
            productsInOrderListBox.Size = new Size(243, 349);
            productsInOrderListBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 9);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 7;
            label2.Text = "מוצרים בהזמנה";
            // 
            // finishOrder
            // 
            finishOrder.Location = new Point(12, 432);
            finishOrder.Name = "finishOrder";
            finishOrder.Size = new Size(107, 23);
            finishOrder.TabIndex = 8;
            finishOrder.Text = "ביצוע הזמנה";
            finishOrder.UseVisualStyleBackColor = true;
            finishOrder.Click += finishOrder_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 406);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 12;
            label4.Text = "מחיר סופי";
            // 
            // finalPriceLabel
            // 
            finalPriceLabel.AutoSize = true;
            finalPriceLabel.Location = new Point(157, 406);
            finalPriceLabel.Name = "finalPriceLabel";
            finalPriceLabel.Size = new Size(0, 15);
            finalPriceLabel.TabIndex = 13;
            // 
            // helloCustomerName
            // 
            helloCustomerName.AutoSize = true;
            helloCustomerName.Location = new Point(350, 21);
            helloCustomerName.Name = "helloCustomerName";
            helloCustomerName.Size = new Size(0, 15);
            helloCustomerName.TabIndex = 14;
            // 
            // orderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 467);
            Controls.Add(helloCustomerName);
            Controls.Add(finalPriceLabel);
            Controls.Add(label4);
            Controls.Add(finishOrder);
            Controls.Add(label2);
            Controls.Add(productsInOrderListBox);
            Controls.Add(addToOrderButton);
            Controls.Add(productIdInput);
            Controls.Add(quantityInput);
            Controls.Add(label1);
            Controls.Add(productId);
            Controls.Add(allProductsInSide);
            Name = "orderForm";
            Text = "orderForm";
            ((System.ComponentModel.ISupportInitialize)quantityInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox allProductsInSide;
        private Label productId;
        private Label label1;
        private NumericUpDown quantityInput;
        private TextBox productIdInput;
        private Button addToOrderButton;
        private ListBox productsInOrderListBox;
        private Label label2;
        private Button finishOrder;
        private Label label4;
        private Label finalPriceLabel;
        private Label helloCustomerName;
    }
}