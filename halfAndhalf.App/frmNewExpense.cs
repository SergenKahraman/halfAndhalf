﻿using halfAndhalf.App.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace halfAndhalf.App
{
    public partial class frmNewExpense : Form
    {
        public BindingList<Persons> myUsersYeniIslem;
        public BindingList<Expenses> myExpensesYeniIslem;
        public frmNewExpense(BindingList<Persons> myUsers, BindingList<Expenses> myExpenses)
        {
            InitializeComponent();
            this.myUsersYeniIslem = myUsers;
            this.myExpensesYeniIslem = myExpenses;
            
        }

        private void frmNewExpense_Load(object sender, EventArgs e)
        {
            cmbUsers.DataSource = myUsersYeniIslem;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newExpenses = new Expenses(txtExpenseName.Text, dtpExpenseDate.Value, (double)nudExpensePrice.Value, txtExplanation.Text, (Persons)cmbUsers.SelectedItem);

            myExpensesYeniIslem.Add(newExpenses);
            this.Close();
        }
    }
}
