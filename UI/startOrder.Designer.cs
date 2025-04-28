namespace UI
{
    partial class startOrder
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
            startOrderButton = new Button();
            customerIdInput = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // startOrderButton
            // 
            startOrderButton.Location = new Point(338, 126);
            startOrderButton.Name = "startOrderButton";
            startOrderButton.Size = new Size(115, 23);
            startOrderButton.TabIndex = 14;
            startOrderButton.Text = "התחל הזמנה";
            startOrderButton.UseVisualStyleBackColor = true;
            startOrderButton.Click += startOrderButton_Click;
            // 
            // customerIdInput
            // 
            customerIdInput.Location = new Point(302, 88);
            customerIdInput.Name = "customerIdInput";
            customerIdInput.Size = new Size(100, 23);
            customerIdInput.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(408, 91);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 12;
            label3.Text = "הכנס מזהה לקוח";
            // 
            // startOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(startOrderButton);
            Controls.Add(customerIdInput);
            Controls.Add(label3);
            Name = "startOrder";
            Text = "startOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startOrderButton;
        private TextBox customerIdInput;
        private Label label3;
    }
}