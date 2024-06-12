using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FinanceTracker
{
    public partial class Form1 : Form
    {
        private List<Transaction> transactions = new List<Transaction>();

        public Form1()
        {
            InitializeComponent();
            dgvTransactions.AutoGenerateColumns = false;
            dgvTransactions.DataSource = bindingSource;
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount) && !string.IsNullOrEmpty(txtDescription.Text))
            {
                var transaction = new Transaction(amount, txtDescription.Text);
                transactions.Add(transaction);
                UpdateTransactionList();
                UpdateBalance();
            }
            else
            {
                MessageBox.Show("Please enter a valid amount and description.");
            }
        }

        private void UpdateTransactionList()
        {
            bindingSource.DataSource = null;
            bindingSource.DataSource = transactions.Select(t => new { t.Description, Amount = t.Amount.ToString("C") }).ToList();
        }

        private void UpdateBalance()
        {
            decimal balance = transactions.Sum(t => t.Amount);
            lblBalance.Text = $"Current Balance: {balance:C}";
        }
    }

    public class Transaction
    {
        public decimal Amount { get; set; }
        public string Description { get; set; }

        public Transaction(decimal amount, string description)
        {
            Amount = amount;
            Description = description;
        }
    }
}
