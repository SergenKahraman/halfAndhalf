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
            myUsers.Add(new Users { FirstName = "Emre", LastName = "Ertuğrul", Password = "eu1234" });
            myExpenses.Add(new Expenses("Ev Gideri", DateTime.Now.AddDays(-10), 225, "Sebze ve meyve aldım.", myUsers[0]));
            myExpenses.Add(new Expenses("Fatura", DateTime.Now.AddDays(-2), 100, "DOğalgaz ve Elektrik ödedim.", myUsers[1]));
            myExpenses.Add(new Expenses("Kafe", DateTime.Now.AddDays(-2), 175, "Starbucks' taki hesabı ödedim.", myUsers[2]));
            myExpenses.Add(new Expenses("Temizlik", DateTime.Now.AddDays(-15), 300, "Starbucks' taki hesabı ödedim.", myUsers[3]));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmAllExpensesHelper = new frmAllExpenses(myExpenses);
            frmAllExpensesHelper.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frmReportHelper = new frmReport(myExpenses, myUsers);
            frmReportHelper.ShowDialog();
        }
    }
}
