namespace BST.Forms
{
    partial class MyTicketsForm
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
            panel1 = new Panel();
            lblTitle = new Label();
            dgvTickets = new DataGridView();
            colTicketID = new DataGridViewTextBoxColumn();
            colTripID = new DataGridViewTextBoxColumn();
            colSeats = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 100);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(205, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(125, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "My Tickets";
            lblTitle.Click += lblTitle_Click;
            // 
            // dgvTickets
            // 
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Columns.AddRange(new DataGridViewColumn[] { colTicketID, colTripID, colSeats, colPrice, colStatus });
            dgvTickets.Dock = DockStyle.Fill;
            dgvTickets.Location = new Point(0, 100);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.Size = new Size(544, 310);
            dgvTickets.TabIndex = 1;
            // 
            // colTicketID
            // 
            colTicketID.DataPropertyName = "TicketID";
            colTicketID.HeaderText = "Ticket ID";
            colTicketID.Name = "colTicketID";
            // 
            // colTripID
            // 
            colTripID.DataPropertyName = "TripID";
            colTripID.HeaderText = "Trip";
            colTripID.Name = "colTripID";
            // 
            // colSeats
            // 
            colSeats.DataPropertyName = "SeatCount";
            colSeats.HeaderText = "Seats";
            colSeats.Name = "colSeats";
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "Price";
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            // 
            // MyTicketsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 410);
            Controls.Add(dgvTickets);
            Controls.Add(panel1);
            Name = "MyTicketsForm";
            Text = "MyTicketsForm";
            Load += MyTicketsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private DataGridView dgvTickets;
        private DataGridViewTextBoxColumn colTicketID;
        private DataGridViewTextBoxColumn colTripID;
        private DataGridViewTextBoxColumn colSeats;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colStatus;
    }
}