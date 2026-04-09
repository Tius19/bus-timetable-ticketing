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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            btnLogout = new Button();
            btnViewBookings = new Button();
            btnManageSchedules = new Button();
            lblTitle = new Label();
            panel1 = new Panel();
            dtArrivalDate = new DateTimePicker();
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
            label9 = new Label();
            panelHeader.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 64, 0);
            panelHeader.Controls.Add(btnLogout);
            panelHeader.Controls.Add(btnViewBookings);
            panelHeader.Controls.Add(btnManageSchedules);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(929, 128);
            panelHeader.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(661, 79);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(114, 31);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnViewBookings
            // 
            btnViewBookings.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewBookings.Location = new Point(123, 79);
            btnViewBookings.Margin = new Padding(3, 4, 3, 4);
            btnViewBookings.Name = "btnViewBookings";
            btnViewBookings.Size = new Size(114, 31);
            btnViewBookings.TabIndex = 1;
            btnViewBookings.Text = "View Bookings";
            btnViewBookings.UseVisualStyleBackColor = true;
            btnViewBookings.Click += btnViewBookings_Click;
            // 
            // btnManageSchedules
            // 
            btnManageSchedules.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageSchedules.Location = new Point(387, 79);
            btnManageSchedules.Margin = new Padding(3, 4, 3, 4);
            btnManageSchedules.Name = "btnManageSchedules";
            btnManageSchedules.Size = new Size(137, 31);
            btnManageSchedules.TabIndex = 2;
            btnManageSchedules.Text = "Manage Schedules";
            btnManageSchedules.UseVisualStyleBackColor = true;
            btnManageSchedules.Click += btnManageSchedules_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(294, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(390, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CatanBus - Admin Dashboard";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(dtArrivalDate);
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
            panel1.Location = new Point(0, 128);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(929, 269);
            panel1.TabIndex = 2;
            // 
            // dtArrivalDate
            // 
            dtArrivalDate.Location = new Point(717, 73);
            dtArrivalDate.Name = "dtArrivalDate";
            dtArrivalDate.Size = new Size(162, 27);
            dtArrivalDate.TabIndex = 19;
            // 
            // btnAddBus
            // 
            btnAddBus.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBus.Location = new Point(661, 207);
            btnAddBus.Margin = new Padding(3, 4, 3, 4);
            btnAddBus.Name = "btnAddBus";
            btnAddBus.Size = new Size(114, 31);
            btnAddBus.TabIndex = 18;
            btnAddBus.Text = "Add Bus";
            btnAddBus.UseVisualStyleBackColor = true;
            btnAddBus.Click += btnAddBus_Click;
            // 
            // dtArrival
            // 
            dtArrival.Format = DateTimePickerFormat.Time;
            dtArrival.Location = new Point(440, 132);
            dtArrival.Margin = new Padding(3, 4, 3, 4);
            dtArrival.Name = "dtArrival";
            dtArrival.ShowUpDown = true;
            dtArrival.Size = new Size(156, 27);
            dtArrival.TabIndex = 17;
            // 
            // dtDeparture
            // 
            dtDeparture.Format = DateTimePickerFormat.Time;
            dtDeparture.Location = new Point(131, 132);
            dtDeparture.Margin = new Padding(3, 4, 3, 4);
            dtDeparture.Name = "dtDeparture";
            dtDeparture.ShowUpDown = true;
            dtDeparture.Size = new Size(156, 27);
            dtDeparture.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(24, 189);
            label8.Name = "label8";
            label8.Size = new Size(31, 19);
            label8.TabIndex = 15;
            label8.Text = "Bus";
            // 
            // cmbBus
            // 
            cmbBus.FormattingEnabled = true;
            cmbBus.Location = new Point(131, 189);
            cmbBus.Margin = new Padding(3, 4, 3, 4);
            cmbBus.Name = "cmbBus";
            cmbBus.Size = new Size(138, 28);
            cmbBus.TabIndex = 4;
            // 
            // btnAddSchedule
            // 
            btnAddSchedule.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddSchedule.Location = new Point(410, 207);
            btnAddSchedule.Margin = new Padding(3, 4, 3, 4);
            btnAddSchedule.Name = "btnAddSchedule";
            btnAddSchedule.Size = new Size(114, 31);
            btnAddSchedule.TabIndex = 3;
            btnAddSchedule.Text = "Add Schedule";
            btnAddSchedule.UseVisualStyleBackColor = true;
            btnAddSchedule.Click += btnAddSchedule_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(697, 131);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(114, 27);
            txtPrice.TabIndex = 14;
            // 
            // dtDate
            // 
            dtDate.Location = new Point(516, 73);
            dtDate.Margin = new Padding(3, 4, 3, 4);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(168, 27);
            dtDate.TabIndex = 12;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(334, 73);
            txtTo.Margin = new Padding(3, 4, 3, 4);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(114, 27);
            txtTo.TabIndex = 10;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(107, 73);
            txtFrom.Margin = new Padding(3, 4, 3, 4);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(114, 27);
            txtFrom.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(618, 136);
            label7.Name = "label7";
            label7.Size = new Size(40, 19);
            label7.TabIndex = 9;
            label7.Text = "Price";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(325, 136);
            label6.Name = "label6";
            label6.Size = new Size(85, 19);
            label6.TabIndex = 8;
            label6.Text = "Arrival Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 135);
            label5.Name = "label5";
            label5.Size = new Size(105, 19);
            label5.TabIndex = 7;
            label5.Text = "Departure Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(541, 53);
            label4.Name = "label4";
            label4.Size = new Size(105, 19);
            label4.TabIndex = 6;
            label4.Text = "Departure Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(245, 75);
            label3.Name = "label3";
            label3.Size = new Size(83, 19);
            label3.TabIndex = 5;
            label3.Text = "To Location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 73);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 4;
            label2.Text = "From Location";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(355, 15);
            label1.Name = "label1";
            label1.Size = new Size(217, 32);
            label1.TabIndex = 3;
            label1.Text = "Add New Schedule";
            // 
            // dgvSchedules
            // 
            dgvSchedules.AllowUserToAddRows = false;
            dgvSchedules.AllowUserToDeleteRows = false;
            dgvSchedules.BackgroundColor = Color.FromArgb(0, 64, 0);
            dgvSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedules.Columns.AddRange(new DataGridViewColumn[] { TripID, Route, Date, Bookings, Status, CancelTrip, Delete });
            dgvSchedules.Dock = DockStyle.Fill;
            dgvSchedules.Location = new Point(0, 397);
            dgvSchedules.Margin = new Padding(3, 4, 3, 4);
            dgvSchedules.Name = "dgvSchedules";
            dgvSchedules.ReadOnly = true;
            dgvSchedules.RowHeadersWidth = 51;
            dgvSchedules.Size = new Size(929, 203);
            dgvSchedules.TabIndex = 3;
            dgvSchedules.CellContentClick += dgvSchedules_CellContentClick;
            // 
            // TripID
            // 
            TripID.DataPropertyName = "TripID";
            TripID.HeaderText = "TripID";
            TripID.MinimumWidth = 6;
            TripID.Name = "TripID";
            TripID.ReadOnly = true;
            TripID.Width = 125;
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
            // Date
            // 
            Date.DataPropertyName = "Departure";
            dataGridViewCellStyle2.Format = "dd MMM yyyy HH:mm";
            Date.DefaultCellStyle = dataGridViewCellStyle2;
            Date.HeaderText = "Departure Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 125;
            // 
            // Bookings
            // 
            Bookings.DataPropertyName = "Bookings";
            Bookings.HeaderText = "Bookings";
            Bookings.MinimumWidth = 6;
            Bookings.Name = "Bookings";
            Bookings.ReadOnly = true;
            Bookings.Width = 125;
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
            // CancelTrip
            // 
            CancelTrip.HeaderText = "CancelTrip";
            CancelTrip.MinimumWidth = 6;
            CancelTrip.Name = "CancelTrip";
            CancelTrip.ReadOnly = true;
            CancelTrip.Text = "Cancel";
            CancelTrip.UseColumnTextForButtonValue = true;
            CancelTrip.Width = 125;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 125;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(755, 53);
            label9.Name = "label9";
            label9.Size = new Size(85, 19);
            label9.TabIndex = 20;
            label9.Text = "Arrival Date";
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 600);
            Controls.Add(dgvSchedules);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
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
        private DateTimePicker dtArrivalDate;
        private Label label9;
    }
}