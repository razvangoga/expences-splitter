using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DomainModel;

namespace WinForms.UI
{
    public partial class MainForm : Form
    {
        private List<Person> _persons = new List<Person>();
        private AccountingSession _accountingSession = new AccountingSession();

        private Receipt _lastReceipt = null;

        public MainForm()
        {
            InitializeComponent();

            _persons.Add(new Person() { Name = "Emma" });
            _persons.Add(new Person() { Name = "Andrei" });
            _persons.Add(new Person() { Name = "Razvan" });

            this.loadFromFileOpenFileDialog.Filter = string.Format("accountig session files|*.{0}", AccountingSession.STR_FILE_EXTENSION);
            this.saveFileDialog.Filter = string.Format("accountig session files|*.{0}", AccountingSession.STR_FILE_EXTENSION);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.payedByBindingSource.DataSource = this._persons;

            this.expensesForCheckedListBox.DisplayMember = "Name";

            foreach (Person person in this._persons)
                this.expensesForCheckedListBox.Items.Add(person, false);
        }

        private void addReceiptButton_Click(object sender, EventArgs e)
        {
            this.AddReceipt(false);
        }

        private void showReportToolStripButton_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm(this._accountingSession);
            reportForm.ShowDialog(this);
        }

        private void addExpenseButton_Click(object sender, EventArgs e)
        {
            this.AddExpense(false);
        }

        private void BuildSessionReceiptsTree()
        {
            this.overviewTreeView.Visible = false;

            this.overviewTreeView.Nodes.Clear();

            foreach (Receipt receipt in this._accountingSession.Receipts)
            {
                TreeNode receiptNode = new TreeNode(string.Format("{0} payed by {1}",
                    receipt.TotalAmount, receipt.PayedBy.Name));

                foreach (Expense expense in receipt.Expenses)
                {
                    string persons = string.Empty;

                    foreach (Person person in expense.Persons)
	                    persons+= string.Format("{0} ", person.Name);

                    receiptNode.Nodes.Add(string.Format("{0} for {1}", expense.Amount,persons));
                }

                this.overviewTreeView.Nodes.Add(receiptNode);
            }

            this.overviewTreeView.ExpandAll();
            this._accountingSession.SaveToFile();

            this.overviewTreeView.Visible = true;
        }

        private void loadFromFileToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = this.loadFromFileOpenFileDialog.ShowDialog(this);

            if (dialogResult == DialogResult.OK)
            {
                this._accountingSession = AccountingSession.LoadFromFile(this.loadFromFileOpenFileDialog.FileName);
                this.BuildSessionReceiptsTree();
                MessageBox.Show("Session loaded");
            }
        }

        private void saveToFileToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = this.saveFileDialog.ShowDialog(this);

            if (dialogResult == DialogResult.OK)
            {
                this._accountingSession.SaveToFile(this.saveFileDialog.FileName);
                MessageBox.Show("Session saved");
            }
        }

        private void addReceiptWithSplitToAllButton_Click(object sender, EventArgs e)
        {
            this.AddReceipt(true);
        }

        private void AddReceipt(bool addToAll)
        {
            if (string.IsNullOrEmpty(this.receiptValueTextBox.Text))
            {
                MessageBox.Show("Receipt value is empty");
                return;
            }

            decimal amount = 0;

            try
            {
                amount = Convert.ToDecimal(this.receiptValueTextBox.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Receipt value is not a number");
                return;
            }

            Receipt receipt = new Receipt()
            {
                PayedBy = this.payedByBindingSource.Current as Person,
                TotalAmount = amount
            };

            if (addToAll)
            {
                Expense expense = new Expense()
                {
                    Amount = amount,
                    Persons = this._persons
                };

                receipt.Expenses.Add(expense);
            }

            this._lastReceipt = receipt;
            this._accountingSession.Receipts.Add(receipt);

            this.BuildSessionReceiptsTree();

            this.receiptValueTextBox.Text = string.Empty;
        }

        private void AddExpense(bool addRemainder)
        {
            if (!addRemainder && string.IsNullOrEmpty(this.expenseValueTextBox.Text))
            {
                MessageBox.Show("Expese value is empty");
                return;
            }

            if (this.expensesForCheckedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Select for who the expense is");
                return;
            }

            decimal amount = 0;

            if (addRemainder)
            {
                amount = this._lastReceipt.Remainder;
            }
            else
            {
                try
                {
                    amount = Convert.ToDecimal(this.expenseValueTextBox.Text);
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Expense value is not a number");
                    return;
                }
            }

            Expense expense = new Expense()
            {
                Amount = amount
            };

            this._lastReceipt.Expenses.Add(expense);

            foreach (object item in this.expensesForCheckedListBox.CheckedItems)
                expense.Persons.Add(item as Person);

            this.BuildSessionReceiptsTree();

            this.expenseValueTextBox.Text = string.Empty;

            this.expensesForCheckedListBox.SetItemChecked(0, false);
            this.expensesForCheckedListBox.SetItemChecked(1, false);
            this.expensesForCheckedListBox.SetItemChecked(2, false);
        }

        private void addRemainderButton_Click(object sender, EventArgs e)
        {
            this.AddExpense(true);
        }
    }
}
