namespace BST.Forms
{
    partial class AddBusForm
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
            txtBusNumber = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numSeats = new NumericUpDown();
            btnAddBus = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSeats).BeginInit();
            SuspendLayout();
            // 
            // txtBusNumber
            // 
            txtBusNumber.Location = new Point(193, 127);
            txtBusNumber.Name = "txtBusNumber";
            txtBusNumber.Size = new Size(120, 23);
            txtBusNumber.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 76);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(106, 24);
            label1.Name = "label1";
            label1.Size = new Size(152, 30);
            label1.TabIndex = 0;
            label1.Text = "Add New Bus";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 130);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Bus No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 183);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 4;
            label3.Text = "Total Seats";
            // 
            // numSeats
            // 
            numSeats.Location = new Point(192, 181);
            numSeats.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSeats.Name = "numSeats";
            numSeats.Size = new Size(120, 23);
            numSeats.TabIndex = 5;
            numSeats.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddBus
            // 
            btnAddBus.Location = new Point(129, 241);
            btnAddBus.Name = "btnAddBus";
            btnAddBus.Size = new Size(100, 23);
            btnAddBus.TabIndex = 6;
            btnAddBus.Text = "Add Bus";
            btnAddBus.UseVisualStyleBackColor = true;
            btnAddBus.Click += btnAddBus_Click;
            // 
            // AddBusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 317);
            Controls.Add(btnAddBus);
            Controls.Add(numSeats);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(txtBusNumber);
            Name = "AddBusForm";
            Text = "AddBusForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSeats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBusNumber;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numSeats;
        private Button btnAddBus;
    }
}