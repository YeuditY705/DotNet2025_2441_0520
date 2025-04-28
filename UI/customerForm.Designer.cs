namespace UI
{
    partial class customerForm
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
            customersMenu = new TabControl();
            readCustomer = new TabPage();
            customerDetails = new ListBox();
            chooseCustomerId = new Button();
            label1 = new Label();
            numericUpDownCustomerId = new NumericUpDown();
            readAllCustomers = new TabPage();
            buttonFilterCustomerByName = new Button();
            filterCustomerValue = new TextBox();
            label3 = new Label();
            label2 = new Label();
            listBoxAllCustomers = new ListBox();
            addCustomer = new TabPage();
            listBoxAllCustomersInSide = new ListBox();
            addCustomerButton = new Button();
            customerPhoneInput = new TextBox();
            customerAddressInput = new TextBox();
            customerNameInput = new TextBox();
            customerIdInput = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            updateCustomer = new TabPage();
            buttonUpdateCustomer = new Button();
            customerPhoneInputUpdate = new TextBox();
            customerAddressInputUpdate = new TextBox();
            customerNameInputUpdate = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            customerIdUpdate = new TextBox();
            label9 = new Label();
            deleteCustomer = new TabPage();
            deleteCustomerButton = new Button();
            customerID = new TextBox();
            label8 = new Label();
            listBoxInSide = new ListBox();
            customersMenu.SuspendLayout();
            readCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCustomerId).BeginInit();
            readAllCustomers.SuspendLayout();
            addCustomer.SuspendLayout();
            updateCustomer.SuspendLayout();
            deleteCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // customersMenu
            // 
            customersMenu.Controls.Add(readCustomer);
            customersMenu.Controls.Add(readAllCustomers);
            customersMenu.Controls.Add(addCustomer);
            customersMenu.Controls.Add(updateCustomer);
            customersMenu.Controls.Add(deleteCustomer);
            customersMenu.Location = new Point(2, 24);
            customersMenu.Name = "customersMenu";
            customersMenu.RightToLeft = RightToLeft.Yes;
            customersMenu.RightToLeftLayout = true;
            customersMenu.SelectedIndex = 0;
            customersMenu.Size = new Size(466, 379);
            customersMenu.TabIndex = 0;
            // 
            // readCustomer
            // 
            readCustomer.Controls.Add(customerDetails);
            readCustomer.Controls.Add(chooseCustomerId);
            readCustomer.Controls.Add(label1);
            readCustomer.Controls.Add(numericUpDownCustomerId);
            readCustomer.Location = new Point(4, 24);
            readCustomer.Name = "readCustomer";
            readCustomer.Size = new Size(458, 351);
            readCustomer.TabIndex = 2;
            readCustomer.Text = "פרטי לקוח";
            readCustomer.UseVisualStyleBackColor = true;
            // 
            // customerDetails
            // 
            customerDetails.Cursor = Cursors.IBeam;
            customerDetails.FormattingEnabled = true;
            customerDetails.ItemHeight = 15;
            customerDetails.Location = new Point(137, 98);
            customerDetails.Name = "customerDetails";
            customerDetails.RightToLeft = RightToLeft.No;
            customerDetails.Size = new Size(292, 169);
            customerDetails.TabIndex = 3;
            // 
            // chooseCustomerId
            // 
            chooseCustomerId.Location = new Point(43, 16);
            chooseCustomerId.Name = "chooseCustomerId";
            chooseCustomerId.Size = new Size(75, 23);
            chooseCustomerId.TabIndex = 2;
            chooseCustomerId.Text = "אישור";
            chooseCustomerId.UseVisualStyleBackColor = true;
            chooseCustomerId.Click += chooseCustomerId_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 25);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 1;
            label1.Text = "הכנס מזהה לקוח";
            // 
            // numericUpDownCustomerId
            // 
            numericUpDownCustomerId.Location = new Point(151, 20);
            numericUpDownCustomerId.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownCustomerId.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownCustomerId.Name = "numericUpDownCustomerId";
            numericUpDownCustomerId.Size = new Size(120, 23);
            numericUpDownCustomerId.TabIndex = 0;
            numericUpDownCustomerId.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // readAllCustomers
            // 
            readAllCustomers.Controls.Add(buttonFilterCustomerByName);
            readAllCustomers.Controls.Add(filterCustomerValue);
            readAllCustomers.Controls.Add(label3);
            readAllCustomers.Controls.Add(label2);
            readAllCustomers.Controls.Add(listBoxAllCustomers);
            readAllCustomers.Location = new Point(4, 24);
            readAllCustomers.Name = "readAllCustomers";
            readAllCustomers.Size = new Size(458, 351);
            readAllCustomers.TabIndex = 3;
            readAllCustomers.Text = "פרטי כל הלקוחות";
            readAllCustomers.UseVisualStyleBackColor = true;
            // 
            // buttonFilterCustomerByName
            // 
            buttonFilterCustomerByName.Location = new Point(71, 54);
            buttonFilterCustomerByName.Margin = new Padding(3, 2, 3, 2);
            buttonFilterCustomerByName.Name = "buttonFilterCustomerByName";
            buttonFilterCustomerByName.Size = new Size(82, 22);
            buttonFilterCustomerByName.TabIndex = 4;
            buttonFilterCustomerByName.Text = "אישור";
            buttonFilterCustomerByName.UseVisualStyleBackColor = true;
            buttonFilterCustomerByName.Click += buttonFilterCustomerByName_Click;
            // 
            // filterCustomerValue
            // 
            filterCustomerValue.Location = new Point(177, 56);
            filterCustomerValue.Name = "filterCustomerValue";
            filterCustomerValue.Size = new Size(100, 23);
            filterCustomerValue.TabIndex = 3;
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
            label2.Size = new Size(102, 15);
            label2.TabIndex = 1;
            label2.Text = "פרטי כל הלקוחות:";
            // 
            // listBoxAllCustomers
            // 
            listBoxAllCustomers.FormattingEnabled = true;
            listBoxAllCustomers.ItemHeight = 15;
            listBoxAllCustomers.Location = new Point(19, 95);
            listBoxAllCustomers.Name = "listBoxAllCustomers";
            listBoxAllCustomers.RightToLeft = RightToLeft.No;
            listBoxAllCustomers.Size = new Size(367, 229);
            listBoxAllCustomers.TabIndex = 0;
            // 
            // addCustomer
            // 
            addCustomer.Controls.Add(listBoxAllCustomersInSide);
            addCustomer.Controls.Add(addCustomerButton);
            addCustomer.Controls.Add(customerPhoneInput);
            addCustomer.Controls.Add(customerAddressInput);
            addCustomer.Controls.Add(customerNameInput);
            addCustomer.Controls.Add(customerIdInput);
            addCustomer.Controls.Add(label7);
            addCustomer.Controls.Add(label6);
            addCustomer.Controls.Add(label5);
            addCustomer.Controls.Add(label4);
            addCustomer.Location = new Point(4, 24);
            addCustomer.Name = "addCustomer";
            addCustomer.Padding = new Padding(3);
            addCustomer.Size = new Size(458, 351);
            addCustomer.TabIndex = 0;
            addCustomer.Text = "הוספת לקוח";
            addCustomer.UseVisualStyleBackColor = true;
            // 
            // listBoxAllCustomersInSide
            // 
            listBoxAllCustomersInSide.BackColor = Color.Red;
            listBoxAllCustomersInSide.FormattingEnabled = true;
            listBoxAllCustomersInSide.ItemHeight = 15;
            listBoxAllCustomersInSide.Location = new Point(491, 151);
            listBoxAllCustomersInSide.Margin = new Padding(3, 2, 3, 2);
            listBoxAllCustomersInSide.Name = "listBoxAllCustomersInSide";
            listBoxAllCustomersInSide.Size = new Size(258, 364);
            listBoxAllCustomersInSide.TabIndex = 1;
            // 
            // addCustomerButton
            // 
            addCustomerButton.Location = new Point(163, 193);
            addCustomerButton.Name = "addCustomerButton";
            addCustomerButton.Size = new Size(75, 23);
            addCustomerButton.TabIndex = 8;
            addCustomerButton.Text = "הוספה";
            addCustomerButton.UseVisualStyleBackColor = true;
            addCustomerButton.Click += addCustomerButton_Click;
            // 
            // customerPhoneInput
            // 
            customerPhoneInput.Location = new Point(163, 151);
            customerPhoneInput.Name = "customerPhoneInput";
            customerPhoneInput.Size = new Size(100, 23);
            customerPhoneInput.TabIndex = 7;
            // 
            // customerAddressInput
            // 
            customerAddressInput.Location = new Point(163, 109);
            customerAddressInput.Name = "customerAddressInput";
            customerAddressInput.Size = new Size(100, 23);
            customerAddressInput.TabIndex = 6;
            // 
            // customerNameInput
            // 
            customerNameInput.Location = new Point(163, 68);
            customerNameInput.Name = "customerNameInput";
            customerNameInput.Size = new Size(100, 23);
            customerNameInput.TabIndex = 5;
            // 
            // customerIdInput
            // 
            customerIdInput.Location = new Point(163, 31);
            customerIdInput.Name = "customerIdInput";
            customerIdInput.Size = new Size(100, 23);
            customerIdInput.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(269, 154);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 3;
            label7.Text = "טלפון:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(269, 112);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 2;
            label6.Text = "כתובת:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(269, 71);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 1;
            label5.Text = "שם:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 31);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 0;
            label4.Text = "מספר מזהה:";
            // 
            // updateCustomer
            // 
            updateCustomer.Controls.Add(buttonUpdateCustomer);
            updateCustomer.Controls.Add(customerPhoneInputUpdate);
            updateCustomer.Controls.Add(customerAddressInputUpdate);
            updateCustomer.Controls.Add(customerNameInputUpdate);
            updateCustomer.Controls.Add(label10);
            updateCustomer.Controls.Add(label11);
            updateCustomer.Controls.Add(label12);
            updateCustomer.Controls.Add(customerIdUpdate);
            updateCustomer.Controls.Add(label9);
            updateCustomer.Location = new Point(4, 24);
            updateCustomer.Name = "updateCustomer";
            updateCustomer.Padding = new Padding(3);
            updateCustomer.Size = new Size(458, 351);
            updateCustomer.TabIndex = 1;
            updateCustomer.Text = "עדכון לקוח";
            updateCustomer.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateCustomer
            // 
            buttonUpdateCustomer.Location = new Point(159, 217);
            buttonUpdateCustomer.Name = "buttonUpdateCustomer";
            buttonUpdateCustomer.Size = new Size(75, 23);
            buttonUpdateCustomer.TabIndex = 17;
            buttonUpdateCustomer.Text = "עדכון";
            buttonUpdateCustomer.UseVisualStyleBackColor = true;
            buttonUpdateCustomer.Click += buttonUpdateCustomer_Click;
            // 
            // customerPhoneInputUpdate
            // 
            customerPhoneInputUpdate.Location = new Point(159, 175);
            customerPhoneInputUpdate.Name = "customerPhoneInputUpdate";
            customerPhoneInputUpdate.Size = new Size(100, 23);
            customerPhoneInputUpdate.TabIndex = 16;
            // 
            // customerAddressInputUpdate
            // 
            customerAddressInputUpdate.Location = new Point(159, 133);
            customerAddressInputUpdate.Name = "customerAddressInputUpdate";
            customerAddressInputUpdate.Size = new Size(100, 23);
            customerAddressInputUpdate.TabIndex = 15;
            // 
            // customerNameInputUpdate
            // 
            customerNameInputUpdate.Location = new Point(159, 93);
            customerNameInputUpdate.Name = "customerNameInputUpdate";
            customerNameInputUpdate.Size = new Size(100, 23);
            customerNameInputUpdate.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(266, 178);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 12;
            label10.Text = "טלפון:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(266, 136);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 11;
            label11.Text = "כתובת:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(266, 96);
            label12.Name = "label12";
            label12.Size = new Size(27, 15);
            label12.TabIndex = 10;
            label12.Text = "שם:";
            // 
            // customerIdUpdate
            // 
            customerIdUpdate.Location = new Point(159, 36);
            customerIdUpdate.Name = "customerIdUpdate";
            customerIdUpdate.Size = new Size(100, 23);
            customerIdUpdate.TabIndex = 4;
            customerIdUpdate.Leave += InsertDetailOfCustomer;
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
            // deleteCustomer
            // 
            deleteCustomer.Controls.Add(deleteCustomerButton);
            deleteCustomer.Controls.Add(customerID);
            deleteCustomer.Controls.Add(label8);
            deleteCustomer.Location = new Point(4, 24);
            deleteCustomer.Name = "deleteCustomer";
            deleteCustomer.Size = new Size(458, 351);
            deleteCustomer.TabIndex = 4;
            deleteCustomer.Text = "מחיקת לקוח";
            deleteCustomer.UseVisualStyleBackColor = true;
            // 
            // deleteCustomerButton
            // 
            deleteCustomerButton.Location = new Point(62, 45);
            deleteCustomerButton.Name = "deleteCustomerButton";
            deleteCustomerButton.Size = new Size(75, 23);
            deleteCustomerButton.TabIndex = 2;
            deleteCustomerButton.Text = "אישור";
            deleteCustomerButton.UseVisualStyleBackColor = true;
            deleteCustomerButton.Click += deleteCustomerButton_Click;
            // 
            // customerID
            // 
            customerID.Location = new Point(163, 42);
            customerID.Name = "customerID";
            customerID.Size = new Size(100, 23);
            customerID.TabIndex = 1;
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
            // customerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 488);
            Controls.Add(listBoxInSide);
            Controls.Add(customersMenu);
            Name = "customerForm";
            Text = "customerForm";
            customersMenu.ResumeLayout(false);
            readCustomer.ResumeLayout(false);
            readCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCustomerId).EndInit();
            readAllCustomers.ResumeLayout(false);
            readAllCustomers.PerformLayout();
            addCustomer.ResumeLayout(false);
            addCustomer.PerformLayout();
            updateCustomer.ResumeLayout(false);
            updateCustomer.PerformLayout();
            deleteCustomer.ResumeLayout(false);
            deleteCustomer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl customersMenu;
        private TabPage addCustomer;
        private TabPage updateCustomer;
        private TabPage readCustomer;
        private TabPage readAllCustomers;
        private TabPage deleteCustomer;
        private ListBox listBoxAllCustomers;
        private NumericUpDown numericUpDownCustomerId;
        private Label label1;
        private Button chooseCustomerId;
        private ListBox customerDetails;
        private Label label2;
        private Label label3;
        private TextBox filterCustomerValue;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox customerPhoneInput;
        private TextBox customerAddressInput;
        private TextBox customerNameInput;
        private TextBox customerIdInput;
        private Button addCustomerButton;
        private TextBox customerIdUpdate;
        private Label label9;
        private Button deleteCustomerButton;
        private TextBox customerID;
        private Label label8;
        private Button buttonUpdateCustomer;
        private TextBox customerPhoneInputUpdate;
        private TextBox customerAddressInputUpdate;
        private TextBox customerNameInputUpdate;
        private Label label10;
        private Label label11;
        private Label label12;
        private ListBox listBoxAllCustomersInSide;
        private ListBox listBoxInSide;
        private Button buttonFilterCustomerByName;
    }
}