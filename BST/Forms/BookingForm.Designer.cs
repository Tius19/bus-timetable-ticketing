namespace BST.Forms
{
    partial class BookingForm
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
            label1 = new Label();
            numSeats = new NumericUpDown();
            btnConfirm = new Button();
            panel1 = new Panel();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)numSeats).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 130);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Number of Seats";
            // 
            // numSeats
            // 
            numSeats.Location = new Point(224, 128);
            numSeats.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numSeats.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSeats.Name = "numSeats";
            numSeats.Size = new Size(120, 23);
            numSeats.TabIndex = 1;
            numSeats.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(150, 201);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Confirm Booking";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 84);
            panel1.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(108, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(175, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Booking Details";
            lblTitle.Click += lblTitle_Click;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 297);
            Controls.Add(panel1);
            Controls.Add(btnConfirm);
            Controls.Add(numSeats);
            Controls.Add(label1);
            Name = "BookingForm";
            Text = "BookingForm";
            Load += BookingForm_Load;
            ((System.ComponentModel.ISupportInitialize)numSeats).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numSeats;
        private Button btnConfirm;
        private Panel panel1;
        private Label lblTitle;
    }
}