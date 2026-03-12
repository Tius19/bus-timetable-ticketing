using BST.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BST.Forms
{
    public partial class AddBusForm : Form
    {
        BusService busService = new BusService();

        public AddBusForm()
        {
            InitializeComponent();
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            string busNumber = txtBusNumber.Text;

            int seats = (int)numSeats.Value;

            if (busNumber == "")
            {
                MessageBox.Show("Enter Bus Number");
                return;
            }

            busService.AddBus(busNumber, seats);

            MessageBox.Show("Bus added successfully");

            this.Close();
        }
    }
}
