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
    public partial class PaymentForm : Form
    {
        PaymentService paymentService = new PaymentService();
        TicketService ticketService = new TicketService();

        int tripId;
        int userId;
        decimal amount;
        int seatCount;

        public PaymentForm(int tripId, int userId, decimal amount, int seatCount)
        {
            InitializeComponent();

            this.tripId = tripId;
            this.userId = userId;
            this.amount = amount;
            this.seatCount = seatCount;

            txtAmount.Text = amount.ToString();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            btnPay.Enabled = false;
            string name = txtCardName.Text.Trim();
            string card = txtCardNumber.Text.Replace(" ", "");
            string expiry = txtExpiry.Text.Trim();
            string cvv = txtCVV.Text.Trim();

            // Reset field colors
            txtCardName.BackColor = Color.White;
            txtCardNumber.BackColor = Color.White;
            txtExpiry.BackColor = Color.White;
            txtCVV.BackColor = Color.White;

            // Name validation
            if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                txtCardName.BackColor = Color.MistyRose;
                MessageBox.Show("Name on card should contain letters only.");
                txtCardName.Focus();
                btnPay.Enabled = true;
                return;
            }

            // Card number length
            if (card.Length != 16)
            {
                txtCardNumber.BackColor = Color.MistyRose;
                MessageBox.Show("Card number must contain exactly 16 digits.");
                txtCardNumber.Focus();
                btnPay.Enabled = true;
                return;
            }

            // Luhn card validation
            if (!IsValidCardNumber(card))
            {
                txtCardNumber.BackColor = Color.MistyRose;
                MessageBox.Show("Card number failed validation. Please check the digits.");
                txtCardNumber.Focus();
                btnPay.Enabled = true;
                return;
            }

            // Expiry format
            if (!System.Text.RegularExpressions.Regex.IsMatch(expiry, @"^(0[1-9]|1[0-2])\/\d{2}$"))
            {
                txtExpiry.BackColor = Color.MistyRose;
                MessageBox.Show("Expiry must be in MM/YY format (example: 09/28).");
                txtExpiry.Focus();
                btnPay.Enabled = true;
                return;
            }

            // Expiry date check
            string[] parts = expiry.Split('/');
            int month = int.Parse(parts[0]);
            int year = 2000 + int.Parse(parts[1]);

            DateTime expiryDate = new DateTime(year, month, 1).AddMonths(1).AddDays(-1);

            if (DateTime.Now > expiryDate)
            {
                txtExpiry.BackColor = Color.MistyRose;
                MessageBox.Show("This card has expired.");
                txtExpiry.Focus();
                btnPay.Enabled = true;
                return;
            }

            // CVV validation
            if (!System.Text.RegularExpressions.Regex.IsMatch(cvv, @"^\d{3}$"))
            {
                txtCVV.BackColor = Color.MistyRose;
                MessageBox.Show("CVV must contain exactly 3 digits.");
                txtCVV.Focus();
                btnPay.Enabled = true;
                return;
            }

            // Process dummy payment
            paymentService.ProcessPayment(userId, tripId, amount);

            bool success = ticketService.BookTicket(userId, tripId, seatCount, amount);

            if (success)
            {
                MessageBox.Show("Payment successful! Ticket booked.",
                                "Payment Completed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
                btnPay.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to cancel the payment?",
        "Cancel Payment",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtCVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtCardName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {

        }

        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {
            string digits = txtCardNumber.Text.Replace(" ", "");

            if (digits.Length > 16)
                digits = digits.Substring(0, 16);

            StringBuilder formatted = new StringBuilder();

            for (int i = 0; i < digits.Length; i++)
            {
                if (i > 0 && i % 4 == 0)
                    formatted.Append(" ");

                formatted.Append(digits[i]);
            }

            txtCardNumber.TextChanged -= txtCardNumber_TextChanged;
            txtCardNumber.Text = formatted.ToString();
            txtCardNumber.SelectionStart = txtCardNumber.Text.Length;
            txtCardNumber.TextChanged += txtCardNumber_TextChanged;
        }

        private void txtExpiry_TextChanged(object sender, EventArgs e)
        {
            string digits = txtExpiry.Text.Replace("/", "");

            if (digits.Length > 4)
                digits = digits.Substring(0, 4);

            if (digits.Length >= 3)
                txtExpiry.Text = digits.Insert(2, "/");
            else
                txtExpiry.Text = digits;

            txtExpiry.SelectionStart = txtExpiry.Text.Length;
        }

        private bool IsValidCardNumber(string cardNumber)
        {
            int sum = 0;
            bool alternate = false;

            for (int i = cardNumber.Length - 1; i >= 0; i--)
            {
                int n = int.Parse(cardNumber[i].ToString());

                if (alternate)
                {
                    n *= 2;
                    if (n > 9)
                        n -= 9;
                }

                sum += n;
                alternate = !alternate;
            }

            return (sum % 10 == 0);
        }
    }
}
