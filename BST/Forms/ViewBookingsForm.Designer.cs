namespace BST.Forms
{
    partial class ViewBookingsForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvBookings = new DataGridView();
            TicketID = new DataGridViewTextBoxColumn();
            User = new DataGridViewTextBoxColumn();
            Route = new DataGridViewTextBoxColumn();
            Departure = new DataGridViewTextBoxColumn();
            Seats = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Columns.AddRange(new DataGridViewColumn[] { TicketID, User, Route, Departure, Seats, Price, Status });
            dgvBookings.Dock = DockStyle.Fill;
            dgvBookings.Location = new Point(0, 76);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.Size = new Size(744, 303);
            dgvBookings.TabIndex = 0;
            // 
            // TicketID
            // 
            TicketID.DataPropertyName = "TicketId";
            TicketID.HeaderText = "TicketID";
            TicketID.Name = "TicketID";
            TicketID.ReadOnly = true;
            // 
            // User
            // 
            User.DataPropertyName = "User";
            User.HeaderText = "User";
            User.Name = "User";
            User.ReadOnly = true;
            // 
            // Route
            // 
            Route.DataPropertyName = "Route";
            Route.HeaderText = "Route";
            Route.Name = "Route";
            Route.ReadOnly = true;
            // 
            // Departure
            // 
            Departure.DataPropertyName = "Departure";
            dataGridViewCellStyle2.Format = "dd MMM yyyy HH:mm";
            Departure.DefaultCellStyle = dataGridViewCellStyle2;
            Departure.HeaderText = "Departure";
            Departure.Name = "Departure";
            Departure.ReadOnly = true;
            // 
            // Seats
            // 
            Seats.DataPropertyName = "Seats";
            Seats.HeaderText = "Seats";
            Seats.Name = "Seats";
            Seats.ReadOnly = true;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 76);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(281, 22);
            label1.Name = "label1";
            label1.Size = new Size(165, 30);
            label1.TabIndex = 0;
            label1.Text = "View Bookings";
            label1.Click += label1_Click;
            // 
            // ViewBookingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 379);
            Controls.Add(dgvBookings);
            Controls.Add(panel1);
            Name = "ViewBookingsForm";
            Text = "ViewBookingsForm";
            Load += ViewBookingsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBookings;
        private Panel panel1;
        private Label label1;
        private DataGridViewTextBoxColumn TicketID;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn Route;
        private DataGridViewTextBoxColumn Departure;
        private DataGridViewTextBoxColumn Seats;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Status;
    }
}