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
            txtBusNumber.Location = new Point(221, 169);
            txtBusNumber.Margin = new Padding(3, 4, 3, 4);
            txtBusNumber.Name = "txtBusNumber";
            txtBusNumber.Size = new Size(137, 27);
            txtBusNumber.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 101);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(121, 32);
            label1.Name = "label1";
            label1.Size = new Size(188, 36);
            label1.TabIndex = 0;
            label1.Text = "Add New Bus";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(83, 173);
            label2.Name = "label2";
            label2.Size = new Size(54, 19);
            label2.TabIndex = 3;
            label2.Text = "Bus No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 244);
            label3.Name = "label3";
            label3.Size = new Size(77, 19);
            label3.TabIndex = 4;
            label3.Text = "Total Seats";
            // 
            // numSeats
            // 
            numSeats.Location = new Point(219, 241);
            numSeats.Margin = new Padding(3, 4, 3, 4);
            numSeats.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSeats.Name = "numSeats";
            numSeats.Size = new Size(137, 27);
            numSeats.TabIndex = 5;
            numSeats.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddBus
            // 
            btnAddBus.Location = new Point(147, 321);
            btnAddBus.Margin = new Padding(3, 4, 3, 4);
            btnAddBus.Name = "btnAddBus";
            btnAddBus.Size = new Size(114, 31);
            btnAddBus.TabIndex = 6;
            btnAddBus.Text = "Add Bus";
            btnAddBus.UseVisualStyleBackColor = true;
            btnAddBus.Click += btnAddBus_Click;
            // 
            // AddBusForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 423);
            Controls.Add(btnAddBus);
            Controls.Add(numSeats);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(txtBusNumber);
            Margin = new Padding(3, 4, 3, 4);
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