using halfAndhalf.App.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace halfAndhalf.App
{
    public partial class frmPersons : Form
    {
        public BindingList<Persons> myUsersKullanıcılar;
        public BindingList<Expenses> myExpensesKullanıcılar;
        public frmPersons(BindingList<Persons> myUsers, BindingList<Expenses> myExpenses)
        {
            InitializeComponent();
            this.myUsersKullanıcılar = myUsers;
            myExpensesKullanıcılar = myExpenses;
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            lstInfoUsers.DataSource = myUsersKullanıcılar;
            lstInfoUsers.SelectedIndex = -1;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var newUser = new Persons
            {
                FirstName = txtUserFirstName.Text,
                LastName = txtUserLastName.Text,
            };
            myUsersKullanıcılar.Add(newUser);
            txtUserFirstName.Clear();
            txtUserLastName.Clear();
            txtUserFirstName.Focus();
        }

        private void lstInfoUsers_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                lstInfoUsers.SelectedIndex = lstInfoUsers.IndexFromPoint(e.X, e.Y);
                if (lstInfoUsers.SelectedItem == null)
                {
                    ctxUsers.Close();
                }
            }
        }

        private void ctxButtonDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Emin misin?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var selectedUser = lstInfoUsers.SelectedItem as Persons;
                var myExpensesKullanıcılarCopy = new Expenses[myExpensesKullanıcılar.Count];
                myExpensesKullanıcılar.CopyTo(myExpensesKullanıcılarCopy, 0);
                foreach (var expense in myExpensesKullanıcılarCopy)
                {
                    if (expense.UserOwnExpense == selectedUser)
                    {
                        myExpensesKullanıcılar.Remove(expense);
                    }
                }
                myUsersKullanıcılar.Remove(selectedUser);
            }
            
        }
    }
}
