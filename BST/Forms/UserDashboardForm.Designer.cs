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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboardForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            btnViewTrips = new Button();
            btnMyTickets = new Button();
            lblWelcome = new Label();
            lblTitle = new Label();
            panelSearch = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPassengers).BeginInit();
            panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrips).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 64, 0);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(btnLogout);
            panelHeader.Controls.Add(btnViewTrips);
            panelHeader.Controls.Add(btnMyTickets);
            panelHeader.Controls.Add(lblWelcome);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1191, 107);
            panelHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(316, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(465, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(18, 64);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(114, 31);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnViewTrips
            // 
            btnViewTrips.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewTrips.Location = new Point(882, 64);
            btnViewTrips.Margin = new Padding(3, 4, 3, 4);
            btnViewTrips.Name = "btnViewTrips";
            btnViewTrips.Size = new Size(114, 31);
            btnViewTrips.TabIndex = 1;
            btnViewTrips.Text = "View All Trips";
            btnViewTrips.UseVisualStyleBackColor = true;
            btnViewTrips.Click += btnViewTrips_Click;
            // 
            // btnMyTickets
            // 
            btnMyTickets.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMyTickets.Location = new Point(1018, 64);
            btnMyTickets.Margin = new Padding(3, 4, 3, 4);
            btnMyTickets.Name = "btnMyTickets";
            btnMyTickets.Size = new Size(136, 31);
            btnMyTickets.TabIndex = 2;
            btnMyTickets.Text = "View My Tickets";
            btnMyTickets.UseVisualStyleBackColor = true;
            btnMyTickets.Click += btnMyTickets_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(13, 21);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(128, 22);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome User";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(904, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(215, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "User Dashboard";
            lblTitle.Click += lblTitle_Click;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.Beige;
            panelSearch.Controls.Add(pictureBox5);
            panelSearch.Controls.Add(pictureBox4);
            panelSearch.Controls.Add(pictureBox3);
            panelSearch.Controls.Add(pictureBox2);
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
            panelSearch.Location = new Point(0, 107);
            panelSearch.Margin = new Padding(3, 4, 3, 4);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1191, 289);
            panelSearch.TabIndex = 1;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(847, 102);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(182, 170);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(599, 102);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(182, 170);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(339, 102);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(182, 170);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(87, 102);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(182, 170);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkSeaGreen;
            btnSearch.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(1001, 48);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(114, 31);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // numPassengers
            // 
            numPassengers.Location = new Point(759, 52);
            numPassengers.Margin = new Padding(3, 4, 3, 4);
            numPassengers.Name = "numPassengers";
            numPassengers.Size = new Size(137, 27);
            numPassengers.TabIndex = 7;
            numPassengers.ValueChanged += numPassengers_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(776, 16);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 6;
            label4.Text = "Passengers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(539, 16);
            label3.Name = "label3";
            label3.Size = new Size(39, 19);
            label3.TabIndex = 5;
            label3.Text = "Date";
            // 
            // dtTripDate
            // 
            dtTripDate.Location = new Point(451, 52);
            dtTripDate.Margin = new Padding(3, 4, 3, 4);
            dtTripDate.Name = "dtTripDate";
            dtTripDate.Size = new Size(228, 27);
            dtTripDate.TabIndex = 4;
            // 
            // cmbTo
            // 
            cmbTo.FormattingEnabled = true;
            cmbTo.Location = new Point(239, 52);
            cmbTo.Margin = new Padding(3, 4, 3, 4);
            cmbTo.Name = "cmbTo";
            cmbTo.Size = new Size(138, 28);
            cmbTo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(263, 16);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 2;
            label2.Text = "To Location";
            label2.Click += label2_Click;
            // 
            // cmbFrom
            // 
            cmbFrom.FormattingEnabled = true;
            cmbFrom.Location = new Point(13, 52);
            cmbFrom.Margin = new Padding(3, 4, 3, 4);
            cmbFrom.Name = "cmbFrom";
            cmbFrom.Size = new Size(138, 28);
            cmbFrom.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 16);
            label1.Name = "label1";
            label1.Size = new Size(98, 19);
            label1.TabIndex = 0;
            label1.Text = "From Location";
            // 
            // panelOptions
            // 
            panelOptions.Controls.Add(btnCancelledTrips);
            panelOptions.Controls.Add(btnBookTrip);
            panelOptions.Controls.Add(btnPastTrips);
            panelOptions.Dock = DockStyle.Top;
            panelOptions.Location = new Point(0, 396);
            panelOptions.Margin = new Padding(3, 4, 3, 4);
            panelOptions.Name = "panelOptions";
            panelOptions.Size = new Size(1191, 80);
            panelOptions.TabIndex = 2;
            // 
            // btnCancelledTrips
            // 
            btnCancelledTrips.BackColor = Color.Beige;
            btnCancelledTrips.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelledTrips.Location = new Point(1001, 25);
            btnCancelledTrips.Margin = new Padding(3, 4, 3, 4);
            btnCancelledTrips.Name = "btnCancelledTrips";
            btnCancelledTrips.Size = new Size(114, 31);
            btnCancelledTrips.TabIndex = 4;
            btnCancelledTrips.Text = "My Cancelled Logs";
            btnCancelledTrips.UseVisualStyleBackColor = false;
            btnCancelledTrips.Click += btnCancelledTrips_Click;
            // 
            // btnBookTrip
            // 
            btnBookTrip.BackColor = Color.Beige;
            btnBookTrip.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBookTrip.Location = new Point(110, 25);
            btnBookTrip.Margin = new Padding(3, 4, 3, 4);
            btnBookTrip.Name = "btnBookTrip";
            btnBookTrip.Size = new Size(114, 31);
            btnBookTrip.TabIndex = 3;
            btnBookTrip.Text = "Book a New Trip";
            btnBookTrip.UseVisualStyleBackColor = false;
            btnBookTrip.Click += btnBookTrip_Click;
            // 
            // btnPastTrips
            // 
            btnPastTrips.BackColor = Color.Beige;
            btnPastTrips.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPastTrips.Location = new Point(539, 25);
            btnPastTrips.Margin = new Padding(3, 4, 3, 4);
            btnPastTrips.Name = "btnPastTrips";
            btnPastTrips.Size = new Size(114, 31);
            btnPastTrips.TabIndex = 2;
            btnPastTrips.Text = "My Past Trips";
            btnPastTrips.UseVisualStyleBackColor = false;
            btnPastTrips.Click += btnPastTrips_Click;
            // 
            // dgvTrips
            // 
            dgvTrips.BackgroundColor = Color.FromArgb(0, 64, 0);
            dgvTrips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrips.Columns.AddRange(new DataGridViewColumn[] { TripID, BusNo, colFrom, colTo, colDeparture, colArrival, SeatsLeft, Price, colStatus, colBook });
            dgvTrips.Dock = DockStyle.Fill;
            dgvTrips.Location = new Point(0, 476);
            dgvTrips.Margin = new Padding(3, 4, 3, 4);
            dgvTrips.Name = "dgvTrips";
            dgvTrips.RowHeadersWidth = 51;
            dgvTrips.Size = new Size(1191, 221);
            dgvTrips.TabIndex = 3;
            dgvTrips.CellContentClick += dgvTrips_CellContentClick;
            // 
            // TripID
            // 
            TripID.DataPropertyName = "TripID";
            TripID.HeaderText = "TripID";
            TripID.MinimumWidth = 6;
            TripID.Name = "TripID";
            TripID.Width = 125;
            // 
            // BusNo
            // 
            BusNo.DataPropertyName = "BusNumber";
            BusNo.HeaderText = "BusNo";
            BusNo.MinimumWidth = 6;
            BusNo.Name = "BusNo";
            BusNo.Width = 125;
            // 
            // colFrom
            // 
            colFrom.DataPropertyName = "FromLocation";
            colFrom.HeaderText = "From";
            colFrom.MinimumWidth = 6;
            colFrom.Name = "colFrom";
            colFrom.Width = 125;
            // 
            // colTo
            // 
            colTo.DataPropertyName = "ToLocation";
            colTo.HeaderText = "To";
            colTo.MinimumWidth = 6;
            colTo.Name = "colTo";
            colTo.Width = 125;
            // 
            // colDeparture
            // 
            colDeparture.DataPropertyName = "Departure";
            dataGridViewCellStyle1.Format = "dd MMM yyyy HH:mm";
            colDeparture.DefaultCellStyle = dataGridViewCellStyle1;
            colDeparture.HeaderText = "Departure";
            colDeparture.MinimumWidth = 6;
            colDeparture.Name = "colDeparture";
            colDeparture.Width = 125;
            // 
            // colArrival
            // 
            colArrival.DataPropertyName = "Arrival";
            dataGridViewCellStyle2.Format = "dd MMM yyyy HH:mm";
            colArrival.DefaultCellStyle = dataGridViewCellStyle2;
            colArrival.HeaderText = "Arrival";
            colArrival.MinimumWidth = 6;
            colArrival.Name = "colArrival";
            colArrival.Width = 125;
            // 
            // SeatsLeft
            // 
            SeatsLeft.DataPropertyName = "SeatsAvailable";
            SeatsLeft.HeaderText = "SeatsLeft";
            SeatsLeft.MinimumWidth = 6;
            SeatsLeft.Name = "SeatsLeft";
            SeatsLeft.Width = 125;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price (Euros)";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.Width = 125;
            // 
            // colBook
            // 
            colBook.HeaderText = "BOOK NOW";
            colBook.MinimumWidth = 6;
            colBook.Name = "colBook";
            colBook.Text = "BOOK NOW";
            colBook.UseColumnTextForButtonValue = true;
            colBook.Width = 125;
            // 
            // UserDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 697);
            Controls.Add(dgvTrips);
            Controls.Add(panelOptions);
            Controls.Add(panelSearch);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserDashboardForm";
            Text = "UserDashboardForm";
            Load += UserDashboardForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPassengers).EndInit();
            panelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTrips).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Button btnLogout;
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
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