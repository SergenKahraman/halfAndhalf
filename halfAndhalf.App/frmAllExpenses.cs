using halfAndhalf.App.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace halfAndhalf.App
{
    public partial class frmAllExpenses : Form
    {
        private BindingList<Expenses> myExpensesTumIslemler;
        public frmAllExpenses(BindingList<Expenses> myExpenses)
        {
            InitializeComponent();
            myExpensesTumIslemler = myExpenses;
        }

        private void frmAllExpenses_Load(object sender, EventArgs e)
        {
            lstDisplayAllExpenses.DataSource = myExpensesTumIslemler;
            lstDisplayAllExpenses.SelectedIndex = -1;
            grpDetailsOfExpense.Visible = false;
        }

        private void lstDisplayAllExpenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDisplayAllExpenses.SelectedIndex > -1)
            {

                var selectedExpense = lstDisplayAllExpenses.SelectedItem as Expenses;
                grpDetailsOfExpense.Visible = true;
                txtUserName.Text = selectedExpense.UserOwnExpense.ToString();
                txtExpenseNameD.Text = selectedExpense.ExpenseName;
                txtExpensePriceD.Text = selectedExpense.ExpensePrice.ToString();
                txtExpenseDateD.Text = selectedExpense.ExpenseDate.ToString();
                txtExplanationD.Text = selectedExpense.ExpenseExplanation;

            }
            

        }
    }
}
