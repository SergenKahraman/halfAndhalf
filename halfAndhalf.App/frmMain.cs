using halfAndhalf.App.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace halfAndhalf.App
{
    public partial class frmMain : Form
    {
        public BindingList<Users> myUsers;
        public BindingList<Expenses> myExpenses;
        public frmMain()
        {
            InitializeComponent();
            myUsers = new BindingList<Users>();
            myExpenses = new BindingList<Expenses>();
        }

        private void btnOpenThe_frmNewExpense_Click(object sender, EventArgs e)
        {
            var frmNewExpense_Helper = new frmNewExpense(myUsers, myExpenses);
            frmNewExpense_Helper.ShowDialog();
        }

        private void btnOpenThe_frmUsers_Click(object sender, EventArgs e)
        {
            var frmUsersHelper = new frmUsers(myUsers);
            frmUsersHelper.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            GetLoad(); //test amaçlıdır
        }


        
        /// <summary>
        /// GetLoad
        /// </summary>
        ///     . Bu Method test amaçlı veri kaynağıdır..
        private void GetLoad()
        {
            myUsers.Add(new Users { FirstName = "Sergen", LastName = "Kahraman", Password = "sk1234" });
            myUsers.Add(new Users { FirstName = "Hami", LastName = "Aktaş", Password = "ha1234" });
            myUsers.Add(new Users { FirstName = "Gamze", LastName = "Uysal", Password = "gu1234" });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmAllExpensesHelper = new frmAllExpenses(myExpenses);
            frmAllExpensesHelper.ShowDialog();
        }
    }
}
