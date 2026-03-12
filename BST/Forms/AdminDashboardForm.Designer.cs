namespace BST.Forms
{
    partial class AdminDashboardForm
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
            panelHeader = new Panel();
            btnLogout = new Button();
            btnViewBookings = new Button();
            btnManageSchedules = new Button();
            lblTitle = new Label();
            panel1 = new Panel();
            btnAddBus = new Button();
            dtArrival = new DateTimePicker();
            dtDeparture = new DateTimePicker();
            label8 = new Label();
            cmbBus = new ComboBox();
            btnAddSchedule = new Button();
            txtPrice = new TextBox();
            dtDate = new DateTimePicker();
            txtTo = new TextBox();
            txtFrom = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvSchedules = new DataGridView();
            TripID = new DataGridViewTextBoxColumn();
            Route = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Bookings = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            CancelTrip = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            panelHeader.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(btnLogout);
            panelHeader.Controls.Add(btnViewBookings);
            panelHeader.Controls.Add(btnManageSchedules);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 96);
            panelHeader.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(578, 59);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 23);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnViewBookings
            // 
            btnViewBookings.Location = new Point(108, 59);
            btnViewBookings.Name = "btnViewBookings";
            btnViewBookings.Size = new Size(100, 23);
            btnViewBookings.TabIndex = 1;
            btnViewBookings.Text = "View Bookings";
            btnViewBookings.UseVisualStyleBackColor = true;
            btnViewBookings.Click += btnViewBookings_Click;
            // 
            // btnManageSchedules
            // 
            btnManageSchedules.Location = new Point(339, 59);
            btnManageSchedules.Name = "btnManageSchedules";
            btnManageSchedules.Size = new Size(120, 23);
            btnManageSchedules.TabIndex = 2;
            btnManageSchedules.Text = "Manage Schedules";
            btnManageSchedules.UseVisualStyleBackColor = true;
            btnManageSchedules.Click += btnManageSchedules_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(257, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(318, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CatanBus - Admin Dashboard";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddBus);
            panel1.Controls.Add(dtArrival);
            panel1.Controls.Add(dtDeparture);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cmbBus);
            panel1.Controls.Add(btnAddSchedule);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(dtDate);
            panel1.Controls.Add(txtTo);
            panel1.Controls.Add(txtFrom);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 202);
            panel1.TabIndex = 2;
            // 
            // btnAddBus
            // 
            btnAddBus.Location = new Point(578, 155);
            btnAddBus.Name = "btnAddBus";
            btnAddBus.Size = new Size(100, 23);
            btnAddBus.TabIndex = 18;
            btnAddBus.Text = "Add Bus";
            btnAddBus.UseVisualStyleBackColor = true;
            btnAddBus.Click += btnAddBus_Click;
            // 
            // dtArrival
            // 
            dtArrival.Location = new Point(385, 99);
            dtArrival.Name = "dtArrival";
            dtArrival.Size = new Size(137, 23);
            dtArrival.TabIndex = 17;
            // 
            // dtDeparture
            // 
            dtDeparture.Location = new Point(115, 99);
            dtDeparture.Name = "dtDeparture";
            dtDeparture.Size = new Size(137, 23);
            dtDeparture.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 142);
            label8.Name = "label8";
            label8.Size = new Size(26, 15);
            label8.TabIndex = 15;
            label8.Text = "Bus";
            // 
            // cmbBus
            // 
            cmbBus.FormattingEnabled = true;
            cmbBus.Location = new Point(115, 142);
            cmbBus.Name = "cmbBus";
            cmbBus.Size = new Size(121, 23);
            cmbBus.TabIndex = 4;
            // 
            // btnAddSchedule
            // 
            btnAddSchedule.Location = new Point(359, 155);
            btnAddSchedule.Name = "btnAddSchedule";
            btnAddSchedule.Size = new Size(100, 23);
            btnAddSchedule.TabIndex = 3;
            btnAddSchedule.Text = "Add Schedule";
            btnAddSchedule.UseVisualStyleBackColor = true;
            btnAddSchedule.Click += btnAddSchedule_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(610, 98);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 14;
            // 
            // dtDate
            // 
            dtDate.Location = new Point(608, 49);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(148, 23);
            dtDate.TabIndex = 12;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(386, 50);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(100, 23);
            txtTo.TabIndex = 10;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(115, 52);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(100, 23);
            txtFrom.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(541, 102);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 9;
            label7.Text = "Price";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(278, 103);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 8;
            label6.Text = "Arrival";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 101);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 7;
            label5.Text = "Departure";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(542, 54);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 6;
            label4.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 55);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 5;
            label3.Text = "To Location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 4;
            label2.Text = "From Location";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(311, 11);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 3;
            label1.Text = "Add New Schedule";
            // 
            // dgvSchedules
            // 
            dgvSchedules.AllowUserToAddRows = false;
            dgvSchedules.AllowUserToDeleteRows = false;
            dgvSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedules.Columns.AddRange(new DataGridViewColumn[] { TripID, Route, Date, Bookings, Status, CancelTrip, Delete });
            dgvSchedules.Dock = DockStyle.Fill;
            dgvSchedules.Location = new Point(0, 298);
            dgvSchedules.Name = "dgvSchedules";
            dgvSchedules.ReadOnly = true;
            dgvSchedules.Size = new Size(800, 152);
            dgvSchedules.TabIndex = 3;
            dgvSchedules.CellContentClick += dgvSchedules_CellContentClick;
            // 
            // TripID
            // 
            TripID.DataPropertyName = "TripID";
            TripID.HeaderText = "TripID";
            TripID.Name = "TripID";
            TripID.ReadOnly = true;
            // 
            // Route
            // 
            Route.DataPropertyName = "Route";
            Route.HeaderText = "Route";
            Route.Name = "Route";
            Route.ReadOnly = true;
            // 
            // Date
            // 
            Date.DataPropertyName = "Departure";
            dataGridViewCellStyle1.Format = "dd MMM yyyy HH:mm";
            Date.DefaultCellStyle = dataGridViewCellStyle1;
            Date.HeaderText = "Departure Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Bookings
            // 
            Bookings.DataPropertyName = "Bookings";
            Bookings.HeaderText = "Bookings";
            Bookings.Name = "Bookings";
            Bookings.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // CancelTrip
            // 
            CancelTrip.HeaderText = "CancelTrip";
            CancelTrip.Name = "CancelTrip";
            CancelTrip.ReadOnly = true;
            CancelTrip.Text = "Cancel";
            CancelTrip.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSchedules);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            Load += AdminDashboardForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Button btnLogout;
        private Button btnViewBookings;
        private Button btnManageSchedules;
        private Label lblTitle;
        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnAddSchedule;
        private Label label7;
        private Label label6;
        private TextBox txtPrice;
        private DateTimePicker dtDate;
        private TextBox txtTo;
        private TextBox txtFrom;
        private Label label8;
        private ComboBox cmbBus;
        private DataGridView dgvSchedules;
        private DateTimePicker dtArrival;
        private DateTimePicker dtDeparture;
        private DataGridViewTextBoxColumn TripID;
        private DataGridViewTextBoxColumn Route;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Bookings;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn CancelTrip;
        private DataGridViewButtonColumn Delete;
        private Button btnAddBus;
    }
}