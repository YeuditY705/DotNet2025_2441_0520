namespace UI
{
    partial class saleForm
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
            saleQuantityInput = new TextBox();
            addSale = new TabPage();
            label16 = new Label();
            label13 = new Label();
            dateTimeEnd = new DateTimePicker();
            dateTimeStart = new DateTimePicker();
            isForEveryone = new CheckBox();
            label5 = new Label();
            label12 = new Label();
            listBoxAllSalesInSide = new ListBox();
            addSaleButton = new Button();
            salePriceInput = new TextBox();
            productIdInput = new TextBox();
            label7 = new Label();
            label6 = new Label();
            salesMenu = new TabControl();
            readSale = new TabPage();
            saleDetails = new ListBox();
            chooseSaleId = new Button();
            label1 = new Label();
            numericUpDownSaleId = new NumericUpDown();
            readAllSales = new TabPage();
            checkBoxIsForEveryOne = new CheckBox();
            buttonFilterSaleByName = new Button();
            label3 = new Label();
            label2 = new Label();
            listBoxAllSales = new ListBox();
            updateSale = new TabPage();
            label4 = new Label();
            saleIdUpdate = new TextBox();
            label10 = new Label();
            label9 = new Label();
            dateTimeEndUpdate = new DateTimePicker();
            productIdInputaUpdate = new TextBox();
            dateTimeStartUpdate = new DateTimePicker();
            saleQuantityInputUpdate = new TextBox();
            checkBoxIsForEveryOneUpdate = new CheckBox();
            label17 = new Label();
            label11 = new Label();
            label15 = new Label();
            label14 = new Label();
            salePriceInputUpdate = new TextBox();
            buttonUpdateSale = new Button();
            deleteSale = new TabPage();
            deleteSaleButton = new Button();
            saleID = new TextBox();
            label8 = new Label();
            listBoxInSide = new ListBox();
            addSale.SuspendLayout();
            salesMenu.SuspendLayout();
            readSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSaleId).BeginInit();
            readAllSales.SuspendLayout();
            updateSale.SuspendLayout();
            deleteSale.SuspendLayout();
            SuspendLayout();
            // 
            // saleQuantityInput
            // 
            saleQuantityInput.Location = new Point(169, 70);
            saleQuantityInput.Name = "saleQuantityInput";
            saleQuantityInput.Size = new Size(100, 23);
            saleQuantityInput.TabIndex = 0;
            // 
            // addSale
            // 
            addSale.Controls.Add(label16);
            addSale.Controls.Add(label13);
            addSale.Controls.Add(dateTimeEnd);
            addSale.Controls.Add(dateTimeStart);
            addSale.Controls.Add(isForEveryone);
            addSale.Controls.Add(label5);
            addSale.Controls.Add(label12);
            addSale.Controls.Add(listBoxAllSalesInSide);
            addSale.Controls.Add(addSaleButton);
            addSale.Controls.Add(salePriceInput);
            addSale.Controls.Add(productIdInput);
            addSale.Controls.Add(label7);
            addSale.Controls.Add(label6);
            addSale.Controls.Add(saleQuantityInput);
            addSale.Location = new Point(4, 24);
            addSale.Name = "addSale";
            addSale.Padding = new Padding(3);
            addSale.Size = new Size(458, 351);
            addSale.TabIndex = 0;
            addSale.Text = "הוספת מבצע";
            addSale.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(275, 189);
            label16.Name = "label16";
            label16.Size = new Size(69, 15);
            label16.TabIndex = 17;
            label16.Text = "תאריך סיום:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(275, 160);
            label13.Name = "label13";
            label13.Size = new Size(87, 15);
            label13.TabIndex = 16;
            label13.Text = "תאריך התחלה:";
            // 
            // dateTimeEnd
            // 
            dateTimeEnd.Location = new Point(69, 183);
            dateTimeEnd.Name = "dateTimeEnd";
            dateTimeEnd.Size = new Size(200, 23);
            dateTimeEnd.TabIndex = 15;
            // 
            // dateTimeStart
            // 
            dateTimeStart.Location = new Point(69, 154);
            dateTimeStart.Name = "dateTimeStart";
            dateTimeStart.Size = new Size(200, 23);
            dateTimeStart.TabIndex = 14;
            // 
            // isForEveryone
            // 
            isForEveryone.AutoSize = true;
            isForEveryone.Location = new Point(254, 134);
            isForEveryone.Name = "isForEveryone";
            isForEveryone.Size = new Size(15, 14);
            isForEveryone.TabIndex = 13;
            isForEveryone.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(275, 133);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 12;
            label5.Text = "האם לכולם:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(275, 70);
            label12.Name = "label12";
            label12.Size = new Size(76, 15);
            label12.TabIndex = 10;
            label12.Text = "כמות למבצע:";
            // 
            // listBoxAllSalesInSide
            // 
            listBoxAllSalesInSide.BackColor = Color.Red;
            listBoxAllSalesInSide.FormattingEnabled = true;
            listBoxAllSalesInSide.ItemHeight = 15;
            listBoxAllSalesInSide.Location = new Point(491, 151);
            listBoxAllSalesInSide.Margin = new Padding(3, 2, 3, 2);
            listBoxAllSalesInSide.Name = "listBoxAllSalesInSide";
            listBoxAllSalesInSide.Size = new Size(258, 364);
            listBoxAllSalesInSide.TabIndex = 1;
            // 
            // addSaleButton
            // 
            addSaleButton.Location = new Point(194, 229);
            addSaleButton.Name = "addSaleButton";
            addSaleButton.Size = new Size(75, 23);
            addSaleButton.TabIndex = 8;
            addSaleButton.Text = "הוספה";
            addSaleButton.UseVisualStyleBackColor = true;
            addSaleButton.Click += addSaleButton_Click;
            // 
            // salePriceInput
            // 
            salePriceInput.Location = new Point(169, 99);
            salePriceInput.Name = "salePriceInput";
            salePriceInput.Size = new Size(100, 23);
            salePriceInput.TabIndex = 7;
            // 
            // productIdInput
            // 
            productIdInput.Location = new Point(169, 38);
            productIdInput.Name = "productIdInput";
            productIdInput.Size = new Size(100, 23);
            productIdInput.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(275, 102);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 3;
            label7.Text = "מחיר לאחר המבצע:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(275, 41);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 1;
            label6.Text = "קוד מוצר";
            // 
            // salesMenu
            // 
            salesMenu.Controls.Add(readSale);
            salesMenu.Controls.Add(readAllSales);
            salesMenu.Controls.Add(addSale);
            salesMenu.Controls.Add(updateSale);
            salesMenu.Controls.Add(deleteSale);
            salesMenu.Location = new Point(2, 24);
            salesMenu.Name = "salesMenu";
            salesMenu.RightToLeft = RightToLeft.Yes;
            salesMenu.RightToLeftLayout = true;
            salesMenu.SelectedIndex = 0;
            salesMenu.Size = new Size(466, 379);
            salesMenu.TabIndex = 0;
            // 
            // readSale
            // 
            readSale.Controls.Add(saleDetails);
            readSale.Controls.Add(chooseSaleId);
            readSale.Controls.Add(label1);
            readSale.Controls.Add(numericUpDownSaleId);
            readSale.Location = new Point(4, 24);
            readSale.Name = "readSale";
            readSale.Size = new Size(458, 351);
            readSale.TabIndex = 2;
            readSale.Text = "פרטי מבצע";
            readSale.UseVisualStyleBackColor = true;
            // 
            // saleDetails
            // 
            saleDetails.Cursor = Cursors.IBeam;
            saleDetails.FormattingEnabled = true;
            saleDetails.ItemHeight = 15;
            saleDetails.Location = new Point(137, 98);
            saleDetails.Name = "saleDetails";
            saleDetails.Size = new Size(292, 169);
            saleDetails.TabIndex = 3;
            // 
            // chooseSaleId
            // 
            chooseSaleId.Location = new Point(43, 16);
            chooseSaleId.Name = "chooseSaleId";
            chooseSaleId.Size = new Size(75, 23);
            chooseSaleId.TabIndex = 2;
            chooseSaleId.Text = "אישור";
            chooseSaleId.UseVisualStyleBackColor = true;
            chooseSaleId.Click += chooseSaleId_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 25);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 1;
            label1.Text = "הכנס מזהה מבצע";
            // 
            // numericUpDownSaleId
            // 
            numericUpDownSaleId.Location = new Point(151, 20);
            numericUpDownSaleId.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownSaleId.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownSaleId.Name = "numericUpDownSaleId";
            numericUpDownSaleId.Size = new Size(120, 23);
            numericUpDownSaleId.TabIndex = 0;
            numericUpDownSaleId.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // readAllSales
            // 
            readAllSales.Controls.Add(checkBoxIsForEveryOne);
            readAllSales.Controls.Add(buttonFilterSaleByName);
            readAllSales.Controls.Add(label3);
            readAllSales.Controls.Add(label2);
            readAllSales.Controls.Add(listBoxAllSales);
            readAllSales.Location = new Point(4, 24);
            readAllSales.Name = "readAllSales";
            readAllSales.Size = new Size(458, 351);
            readAllSales.TabIndex = 3;
            readAllSales.Text = "פרטי כל המבצעים";
            readAllSales.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsForEveryOne
            // 
            checkBoxIsForEveryOne.AutoSize = true;
            checkBoxIsForEveryOne.Location = new Point(238, 58);
            checkBoxIsForEveryOne.Name = "checkBoxIsForEveryOne";
            checkBoxIsForEveryOne.Size = new Size(151, 19);
            checkBoxIsForEveryOne.TabIndex = 5;
            checkBoxIsForEveryOne.Text = "האם רק מבצעים למועדון";
            checkBoxIsForEveryOne.UseVisualStyleBackColor = true;
            // 
            // buttonFilterSaleByName
            // 
            buttonFilterSaleByName.Location = new Point(71, 54);
            buttonFilterSaleByName.Margin = new Padding(3, 2, 3, 2);
            buttonFilterSaleByName.Name = "buttonFilterSaleByName";
            buttonFilterSaleByName.Size = new Size(82, 22);
            buttonFilterSaleByName.TabIndex = 4;
            buttonFilterSaleByName.Text = "אישור";
            buttonFilterSaleByName.UseVisualStyleBackColor = true;
            buttonFilterSaleByName.Click += buttonFilterSaleByName_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 58);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(482, 66);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 1;
            label2.Text = "פרטי כל המבצעים:";
            // 
            // listBoxAllSales
            // 
            listBoxAllSales.FormattingEnabled = true;
            listBoxAllSales.ItemHeight = 15;
            listBoxAllSales.Location = new Point(19, 95);
            listBoxAllSales.Name = "listBoxAllSales";
            listBoxAllSales.Size = new Size(367, 229);
            listBoxAllSales.TabIndex = 0;
            // 
            // updateSale
            // 
            updateSale.Controls.Add(label4);
            updateSale.Controls.Add(saleIdUpdate);
            updateSale.Controls.Add(label10);
            updateSale.Controls.Add(label9);
            updateSale.Controls.Add(dateTimeEndUpdate);
            updateSale.Controls.Add(productIdInputaUpdate);
            updateSale.Controls.Add(dateTimeStartUpdate);
            updateSale.Controls.Add(saleQuantityInputUpdate);
            updateSale.Controls.Add(checkBoxIsForEveryOneUpdate);
            updateSale.Controls.Add(label17);
            updateSale.Controls.Add(label11);
            updateSale.Controls.Add(label15);
            updateSale.Controls.Add(label14);
            updateSale.Controls.Add(salePriceInputUpdate);
            updateSale.Controls.Add(buttonUpdateSale);
            updateSale.Location = new Point(4, 24);
            updateSale.Name = "updateSale";
            updateSale.Padding = new Padding(3);
            updateSale.Size = new Size(458, 351);
            updateSale.TabIndex = 1;
            updateSale.Text = "עדכון מבצע";
            updateSale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 236);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 30;
            label4.Text = "תאריך סיום:";
            // 
            // saleIdUpdate
            // 
            saleIdUpdate.Location = new Point(159, 36);
            saleIdUpdate.Name = "saleIdUpdate";
            saleIdUpdate.Size = new Size(100, 23);
            saleIdUpdate.TabIndex = 4;
            saleIdUpdate.Leave += InsertDetailOfSale;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(265, 207);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 29;
            label10.Text = "תאריך התחלה:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(265, 39);
            label9.Name = "label9";
            label9.Size = new Size(102, 15);
            label9.TabIndex = 3;
            label9.Text = "הכנס מזהה לעדכון";
            // 
            // dateTimeEndUpdate
            // 
            dateTimeEndUpdate.Location = new Point(59, 230);
            dateTimeEndUpdate.Name = "dateTimeEndUpdate";
            dateTimeEndUpdate.Size = new Size(200, 23);
            dateTimeEndUpdate.TabIndex = 28;
            // 
            // productIdInputaUpdate
            // 
            productIdInputaUpdate.Location = new Point(159, 85);
            productIdInputaUpdate.Name = "productIdInputaUpdate";
            productIdInputaUpdate.Size = new Size(100, 23);
            productIdInputaUpdate.TabIndex = 21;
            // 
            // dateTimeStartUpdate
            // 
            dateTimeStartUpdate.Location = new Point(59, 201);
            dateTimeStartUpdate.Name = "dateTimeStartUpdate";
            dateTimeStartUpdate.Size = new Size(200, 23);
            dateTimeStartUpdate.TabIndex = 27;
            // 
            // saleQuantityInputUpdate
            // 
            saleQuantityInputUpdate.Location = new Point(159, 117);
            saleQuantityInputUpdate.Name = "saleQuantityInputUpdate";
            saleQuantityInputUpdate.Size = new Size(100, 23);
            saleQuantityInputUpdate.TabIndex = 18;
            // 
            // checkBoxIsForEveryOneUpdate
            // 
            checkBoxIsForEveryOneUpdate.AutoSize = true;
            checkBoxIsForEveryOneUpdate.Location = new Point(244, 181);
            checkBoxIsForEveryOneUpdate.Name = "checkBoxIsForEveryOneUpdate";
            checkBoxIsForEveryOneUpdate.Size = new Size(15, 14);
            checkBoxIsForEveryOneUpdate.TabIndex = 26;
            checkBoxIsForEveryOneUpdate.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(265, 88);
            label17.Name = "label17";
            label17.Size = new Size(52, 15);
            label17.TabIndex = 19;
            label17.Text = "קוד מוצר";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(265, 180);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 25;
            label11.Text = "האם לכולם:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(265, 149);
            label15.Name = "label15";
            label15.Size = new Size(109, 15);
            label15.TabIndex = 20;
            label15.Text = "מחיר לאחר המבצע:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(265, 117);
            label14.Name = "label14";
            label14.Size = new Size(76, 15);
            label14.TabIndex = 24;
            label14.Text = "כמות למבצע:";
            // 
            // salePriceInputUpdate
            // 
            salePriceInputUpdate.Location = new Point(159, 146);
            salePriceInputUpdate.Name = "salePriceInputUpdate";
            salePriceInputUpdate.Size = new Size(100, 23);
            salePriceInputUpdate.TabIndex = 22;
            // 
            // buttonUpdateSale
            // 
            buttonUpdateSale.Location = new Point(184, 276);
            buttonUpdateSale.Name = "buttonUpdateSale";
            buttonUpdateSale.Size = new Size(75, 23);
            buttonUpdateSale.TabIndex = 23;
            buttonUpdateSale.Text = "עדכון";
            buttonUpdateSale.UseVisualStyleBackColor = true;
            buttonUpdateSale.Click += buttonUpdateSale_Click;
            // 
            // deleteSale
            // 
            deleteSale.Controls.Add(deleteSaleButton);
            deleteSale.Controls.Add(saleID);
            deleteSale.Controls.Add(label8);
            deleteSale.Location = new Point(4, 24);
            deleteSale.Name = "deleteSale";
            deleteSale.Size = new Size(458, 351);
            deleteSale.TabIndex = 4;
            deleteSale.Text = "מחיקת מבצע";
            deleteSale.UseVisualStyleBackColor = true;
            // 
            // deleteSaleButton
            // 
            deleteSaleButton.Location = new Point(62, 45);
            deleteSaleButton.Name = "deleteSaleButton";
            deleteSaleButton.Size = new Size(75, 23);
            deleteSaleButton.TabIndex = 2;
            deleteSaleButton.Text = "אישור";
            deleteSaleButton.UseVisualStyleBackColor = true;
            deleteSaleButton.Click += deleteSaleButton_Click;
            // 
            // saleID
            // 
            saleID.Location = new Point(163, 42);
            saleID.Name = "saleID";
            saleID.Size = new Size(100, 23);
            saleID.TabIndex = 1;
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
            // saleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 488);
            Controls.Add(listBoxInSide);
            Controls.Add(salesMenu);
            Name = "saleForm";
            Text = "saleForm";
            addSale.ResumeLayout(false);
            addSale.PerformLayout();
            salesMenu.ResumeLayout(false);
            readSale.ResumeLayout(false);
            readSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSaleId).EndInit();
            readAllSales.ResumeLayout(false);
            readAllSales.PerformLayout();
            updateSale.ResumeLayout(false);
            updateSale.PerformLayout();
            deleteSale.ResumeLayout(false);
            deleteSale.PerformLayout();
            ResumeLayout(false);
        }

        private TabControl salesMenu;
        private TabPage addSale;
        private TabPage updateSale;
        private TabPage readSale;
        private TabPage readAllSales;
        private TabPage deleteSale;
        private ListBox listBoxAllSales;
        private NumericUpDown numericUpDownSaleId;
        private Label label1;
        private Button chooseSaleId;
        private ListBox saleDetails;
        private Label label2;
        private Label label3;
        private Label label7;
        private Label label6;
        private TextBox salePriceInput;
        private TextBox productIdInput;
        private Button addSaleButton;
        private Button deleteSaleButton;
        private TextBox saleID;
        private Label label8;
        private ListBox listBoxAllSalesInSide;
        private ListBox listBoxInSide;
        private Button buttonFilterSaleByName;
        private TextBox saleQuantityInput;
        //private ComboBox categoryComboBox;
        private Label label12;
        private CheckBox checkBoxIsForEveryOne;
        private Label label16;
        private Label label13;
        private DateTimePicker dateTimeEnd;
        private DateTimePicker dateTimeStart;
        private CheckBox isForEveryone;
        private Label label5;
        private Label label4;
        private TextBox saleIdUpdate;
        private Label label10;
        private Label label9;
        private DateTimePicker dateTimeEndUpdate;
        private TextBox productIdInputaUpdate;
        private DateTimePicker dateTimeStartUpdate;
        private TextBox saleQuantityInputUpdate;
        private CheckBox checkBoxIsForEveryOneUpdate;
        private Label label17;
        private Label label11;
        private Label label15;
        private Label label14;
        private TextBox salePriceInputUpdate;
        private Button buttonUpdateSale;
    }
}
