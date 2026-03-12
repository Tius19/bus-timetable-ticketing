namespace BST.Forms
{
    partial class UserDashboardForm
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
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            btnViewTrips = new Button();
            btnMyTickets = new Button();
            lblWelcome = new Label();
            lblTitle = new Label();
            panelSearch = new Panel();
            btnSearch = new Button();
            numPassengers = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            dtTripDate = new DateTimePicker();
            cmbTo = new ComboBox();
            label2 = new Label();
            cmbFrom = new ComboBox();
            label1 = new Label();
            panelOptions = new Panel();
            btnCancelledTrips = new Button();
            btnBookTrip = new Button();
            btnPastTrips = new Button();
            dgvTrips = new DataGridView();
            TripID = new DataGridViewTextBoxColumn();
            BusNo = new DataGridViewTextBoxColumn();
            colFrom = new DataGridViewTextBoxColumn();
            colTo = new DataGridViewTextBoxColumn();
            colDeparture = new DataGridViewTextBoxColumn();
            colArrival = new DataGridViewTextBoxColumn();
            SeatsLeft = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colBook = new DataGridViewButtonColumn();
            panelHeader.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPassengers).BeginInit();
            panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrips).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(btnViewTrips);
            panelHeader.Controls.Add(btnMyTickets);
            panelHeader.Controls.Add(lblWelcome);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1042, 80);
            panelHeader.TabIndex = 0;
            // 
            // btnViewTrips
            // 
            btnViewTrips.Location = new Point(722, 48);
            btnViewTrips.Name = "btnViewTrips";
            btnViewTrips.Size = new Size(100, 23);
            btnViewTrips.TabIndex = 1;
            btnViewTrips.Text = "View All Trips";
            btnViewTrips.UseVisualStyleBackColor = true;
            btnViewTrips.Click += btnViewTrips_Click;
            // 
            // btnMyTickets
            // 
            btnMyTickets.Location = new Point(876, 48);
            btnMyTickets.Name = "btnMyTickets";
            btnMyTickets.Size = new Size(100, 23);
            btnMyTickets.TabIndex = 2;
            btnMyTickets.Text = "View My Tickets";
            btnMyTickets.UseVisualStyleBackColor = true;
            btnMyTickets.Click += btnMyTickets_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblWelcome.Location = new Point(30, 46);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(106, 19);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome User";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(380, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(297, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CatanBus - User Dashboard";
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Controls.Add(numPassengers);
            panelSearch.Controls.Add(label4);
            panelSearch.Controls.Add(label3);
            panelSearch.Controls.Add(dtTripDate);
            panelSearch.Controls.Add(cmbTo);
            panelSearch.Controls.Add(label2);
            panelSearch.Controls.Add(cmbFrom);
            panelSearch.Controls.Add(label1);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 80);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1042, 80);
            panelSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(875, 41);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // numPassengers
            // 
            numPassengers.Location = new Point(664, 39);
            numPassengers.Name = "numPassengers";
            numPassengers.Size = new Size(120, 23);
            numPassengers.TabIndex = 7;
            numPassengers.ValueChanged += numPassengers_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(679, 12);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 6;
            label4.Text = "Passengers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 12);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "Date";
            // 
            // dtTripDate
            // 
            dtTripDate.Location = new Point(395, 39);
            dtTripDate.Name = "dtTripDate";
            dtTripDate.Size = new Size(200, 23);
            dtTripDate.TabIndex = 4;
            // 
            // cmbTo
            // 
            cmbTo.FormattingEnabled = true;
            cmbTo.Location = new Point(209, 39);
            cmbTo.Name = "cmbTo";
            cmbTo.Size = new Size(121, 23);
            cmbTo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 12);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 2;
            label2.Text = "To Location";
            label2.Click += label2_Click;
            // 
            // cmbFrom
            // 
            cmbFrom.FormattingEnabled = true;
            cmbFrom.Location = new Point(11, 39);
            cmbFrom.Name = "cmbFrom";
            cmbFrom.Size = new Size(121, 23);
            cmbFrom.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 12);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "From Location";
            // 
            // panelOptions
            // 
            panelOptions.Controls.Add(btnCancelledTrips);
            panelOptions.Controls.Add(btnBookTrip);
            panelOptions.Controls.Add(btnPastTrips);
            panelOptions.Dock = DockStyle.Top;
            panelOptions.Location = new Point(0, 160);
            panelOptions.Name = "panelOptions";
            panelOptions.Size = new Size(1042, 60);
            panelOptions.TabIndex = 2;
            // 
            // btnCancelledTrips
            // 
            btnCancelledTrips.Location = new Point(876, 19);
            btnCancelledTrips.Name = "btnCancelledTrips";
            btnCancelledTrips.Size = new Size(100, 23);
            btnCancelledTrips.TabIndex = 4;
            btnCancelledTrips.Text = "My Cancelled Logs";
            btnCancelledTrips.UseVisualStyleBackColor = true;
            // 
            // btnBookTrip
            // 
            btnBookTrip.Location = new Point(96, 19);
            btnBookTrip.Name = "btnBookTrip";
            btnBookTrip.Size = new Size(100, 23);
            btnBookTrip.TabIndex = 3;
            btnBookTrip.Text = "Book a New Trip";
            btnBookTrip.UseVisualStyleBackColor = true;
            btnBookTrip.Click += btnBookTrip_Click;
            // 
            // btnPastTrips
            // 
            btnPastTrips.Location = new Point(472, 19);
            btnPastTrips.Name = "btnPastTrips";
            btnPastTrips.Size = new Size(100, 23);
            btnPastTrips.TabIndex = 2;
            btnPastTrips.Text = "My Past Trips";
            btnPastTrips.UseVisualStyleBackColor = true;
            // 
            // dgvTrips
            // 
            dgvTrips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrips.Columns.AddRange(new DataGridViewColumn[] { TripID, BusNo, colFrom, colTo, colDeparture, colArrival, SeatsLeft, Price, colStatus, colBook });
            dgvTrips.Dock = DockStyle.Fill;
            dgvTrips.Location = new Point(0, 220);
            dgvTrips.Name = "dgvTrips";
            dgvTrips.Size = new Size(1042, 303);
            dgvTrips.TabIndex = 3;
            dgvTrips.CellContentClick += dgvTrips_CellContentClick;
            // 
            // TripID
            // 
            TripID.DataPropertyName = "TripID";
            TripID.HeaderText = "TripID";
            TripID.Name = "TripID";
            // 
            // BusNo
            // 
            BusNo.DataPropertyName = "BusNumber";
            BusNo.HeaderText = "BusNo";
            BusNo.Name = "BusNo";
            // 
            // colFrom
            // 
            colFrom.DataPropertyName = "FromLocation";
            colFrom.HeaderText = "From";
            colFrom.Name = "colFrom";
            // 
            // colTo
            // 
            colTo.DataPropertyName = "ToLocation";
            colTo.HeaderText = "To";
            colTo.Name = "colTo";
            // 
            // colDeparture
            // 
            colDeparture.DataPropertyName = "Departure";
            dataGridViewCellStyle15.Format = "dd MMM yyyy HH:mm";
            colDeparture.DefaultCellStyle = dataGridViewCellStyle15;
            colDeparture.HeaderText = "Departure";
            colDeparture.Name = "colDeparture";
            // 
            // colArrival
            // 
            colArrival.DataPropertyName = "Arrival";
            dataGridViewCellStyle16.Format = "dd MMM yyyy HH:mm";
            colArrival.DefaultCellStyle = dataGridViewCellStyle16;
            colArrival.HeaderText = "Arrival";
            colArrival.Name = "colArrival";
            // 
            // SeatsLeft
            // 
            SeatsLeft.DataPropertyName = "SeatsAvailable";
            SeatsLeft.HeaderText = "SeatsLeft";
            SeatsLeft.Name = "SeatsLeft";
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            // 
            // colBook
            // 
            colBook.HeaderText = "BOOK NOW";
            colBook.Name = "colBook";
            colBook.Text = "BOOK NOW";
            colBook.UseColumnTextForButtonValue = true;
            // 
            // UserDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 523);
            Controls.Add(dgvTrips);
            Controls.Add(panelOptions);
            Controls.Add(panelSearch);
            Controls.Add(panelHeader);
            Name = "UserDashboardForm";
            Text = "UserDashboardForm";
            Load += UserDashboardForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPassengers).EndInit();
            panelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTrips).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Button btnViewTrips;
        private Label lblWelcome;
        private Label lblTitle;
        private Button btnMyTickets;
        private Panel panelSearch;
        private DateTimePicker dtTripDate;
        private ComboBox cmbTo;
        private Label label2;
        private ComboBox cmbFrom;
        private Label label1;
        private Label label3;
        private NumericUpDown numPassengers;
        private Label label4;
        private Button btnSearch;
        private Panel panelOptions;
        private Button btnCancelledTrips;
        private Button btnBookTrip;
        private Button btnPastTrips;
        private DataGridView dgvTrips;
        private DataGridViewTextBoxColumn TripID;
        private DataGridViewTextBoxColumn BusNo;
        private DataGridViewTextBoxColumn colFrom;
        private DataGridViewTextBoxColumn colTo;
        private DataGridViewTextBoxColumn colDeparture;
        private DataGridViewTextBoxColumn colArrival;
        private DataGridViewTextBoxColumn SeatsLeft;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn colBook;
    }
}