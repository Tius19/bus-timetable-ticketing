namespace BST.Forms
{
    partial class PaymentForm
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
            panelHeader = new Panel();
            lblTitle = new Label();
            label1 = new Label();
            txtAmount = new TextBox();
            txtCardName = new TextBox();
            txtCardNumber = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtExpiry = new TextBox();
            txtCVV = new TextBox();
            label5 = new Label();
            btnPay = new Button();
            btnCancel = new Button();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(451, 80);
            panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(169, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(104, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Payment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 133);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 2;
            label1.Text = "Total Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(169, 130);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(226, 23);
            txtAmount.TabIndex = 3;
            // 
            // txtCardName
            // 
            txtCardName.Location = new Point(169, 183);
            txtCardName.Name = "txtCardName";
            txtCardName.Size = new Size(226, 23);
            txtCardName.TabIndex = 4;
            txtCardName.KeyPress += txtCardName_KeyPress;
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(169, 231);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(226, 23);
            txtCardNumber.TabIndex = 5;
            txtCardNumber.TextChanged += txtCardNumber_TextChanged;
            txtCardNumber.KeyPress += txtCardNumber_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 186);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 6;
            label2.Text = "Name On Card";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 234);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 7;
            label3.Text = "Card Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 277);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 9;
            label4.Text = "Expiry";
            // 
            // txtExpiry
            // 
            txtExpiry.Location = new Point(169, 274);
            txtExpiry.Name = "txtExpiry";
            txtExpiry.Size = new Size(226, 23);
            txtExpiry.TabIndex = 8;
            txtExpiry.TextChanged += txtExpiry_TextChanged;
            // 
            // txtCVV
            // 
            txtCVV.Location = new Point(169, 319);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(226, 23);
            txtCVV.TabIndex = 10;
            txtCVV.KeyPress += txtCVV_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 322);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 11;
            label5.Text = "CVV";
            // 
            // btnPay
            // 
            btnPay.Location = new Point(169, 380);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(75, 23);
            btnPay.TabIndex = 12;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(293, 380);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 456);
            Controls.Add(btnCancel);
            Controls.Add(btnPay);
            Controls.Add(label5);
            Controls.Add(txtCVV);
            Controls.Add(label4);
            Controls.Add(txtExpiry);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCardNumber);
            Controls.Add(txtCardName);
            Controls.Add(txtAmount);
            Controls.Add(label1);
            Controls.Add(panelHeader);
            Name = "PaymentForm";
            Text = "PaymentForm";
            Load += PaymentForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label label1;
        private TextBox txtAmount;
        private TextBox txtCardName;
        private TextBox txtCardNumber;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtExpiry;
        private TextBox txtCVV;
        private Label label5;
        private Button btnPay;
        private Button btnCancel;
    }
}