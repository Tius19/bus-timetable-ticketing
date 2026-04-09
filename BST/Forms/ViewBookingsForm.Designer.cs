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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            dgvBookings.Location = new Point(0, 101);
            dgvBookings.Margin = new Padding(3, 4, 3, 4);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersWidth = 51;
            dgvBookings.Size = new Size(850, 404);
            dgvBookings.TabIndex = 0;
            // 
            // TicketID
            // 
            TicketID.DataPropertyName = "TicketId";
            TicketID.HeaderText = "TicketID";
            TicketID.MinimumWidth = 6;
            TicketID.Name = "TicketID";
            TicketID.ReadOnly = true;
            TicketID.Width = 125;
            // 
            // User
            // 
            User.DataPropertyName = "User";
            User.HeaderText = "User";
            User.MinimumWidth = 6;
            User.Name = "User";
            User.ReadOnly = true;
            User.Width = 125;
            // 
            // Route
            // 
            Route.DataPropertyName = "Route";
            Route.HeaderText = "Route";
            Route.MinimumWidth = 6;
            Route.Name = "Route";
            Route.ReadOnly = true;
            Route.Width = 125;
            // 
            // Departure
            // 
            Departure.DataPropertyName = "Departure";
            dataGridViewCellStyle1.Format = "dd MMM yyyy HH:mm";
            Departure.DefaultCellStyle = dataGridViewCellStyle1;
            Departure.HeaderText = "Departure";
            Departure.MinimumWidth = 6;
            Departure.Name = "Departure";
            Departure.ReadOnly = true;
            Departure.Width = 125;
            // 
            // Seats
            // 
            Seats.DataPropertyName = "Seats";
            Seats.HeaderText = "Seats";
            Seats.MinimumWidth = 6;
            Seats.Name = "Seats";
            Seats.ReadOnly = true;
            Seats.Width = 125;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 125;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 101);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(321, 29);
            label1.Name = "label1";
            label1.Size = new Size(205, 36);
            label1.TabIndex = 0;
            label1.Text = "View Bookings";
            label1.Click += label1_Click;
            // 
            // ViewBookingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 505);
            Controls.Add(dgvBookings);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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