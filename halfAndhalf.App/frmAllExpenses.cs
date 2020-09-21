using halfAndhalf.App.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace halfAndhalf.App
{
    public partial class frmAllExpenses : Form
    {
        private BindingList<Expenses> myExpensesTumIslemler;
        public int DesiredSelectedIndex { get; set; }
        
        public frmAllExpenses(BindingList<Expenses> myExpenses)
        {
            InitializeComponent();
            myExpensesTumIslemler = myExpenses;
            DesiredSelectedIndex = -1;
        }

        private void frmAllExpenses_Load(object sender, EventArgs e)
        {
            
            lstDisplayAllExpenses.DataSource = myExpensesTumIslemler;
            lstDisplayAllExpenses.SelectedIndex = DesiredSelectedIndex;
            grpDetailsOfExpense.Visible = false;



            if (DesiredSelectedIndex > -1)
            {
                lstDisplayAllExpenses_SelectedIndexChanged(null, null);
            }
            
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
