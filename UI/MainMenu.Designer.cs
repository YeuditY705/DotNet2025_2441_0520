namespace UI
{
    partial class MainMenu
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
            customersButton = new Button();
            salesButton = new Button();
            productsButton = new Button();
            orderButton = new Button();
            SuspendLayout();
            // 
            // customersButton
            // 
            customersButton.Location = new Point(589, 40);
            customersButton.Name = "customersButton";
            customersButton.Size = new Size(154, 98);
            customersButton.TabIndex = 0;
            customersButton.Text = "לקוחות";
            customersButton.UseVisualStyleBackColor = true;
            customersButton.Click += customersButton_Click_1;
            // 
            // salesButton
            // 
            salesButton.Location = new Point(123, 40);
            salesButton.Name = "salesButton";
            salesButton.Size = new Size(154, 98);
            salesButton.TabIndex = 1;
            salesButton.Text = "מבצעים";
            salesButton.UseVisualStyleBackColor = true;
            salesButton.Click += salesButton_Click;
            // 
            // productsButton
            // 
            productsButton.Location = new Point(361, 40);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(154, 98);
            productsButton.TabIndex = 2;
            productsButton.Text = "מוצרים";
            productsButton.UseVisualStyleBackColor = true;
            productsButton.Click += productsButton_Click;
            // 
            // orderButton
            // 
            orderButton.Location = new Point(123, 317);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(154, 61);
            orderButton.TabIndex = 3;
            orderButton.Text = "ביצוע הזמנה";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(orderButton);
            Controls.Add(productsButton);
            Controls.Add(salesButton);
            Controls.Add(customersButton);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button customersButton;
        private Button salesButton;
        private Button productsButton;
        private Button orderButton;
    }
}