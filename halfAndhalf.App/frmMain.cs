using halfAndhalf.App.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace halfAndhalf.App
{
    public partial class frmMain : Form
    {
        public BindingList<Persons> myUsers;
        public BindingList<Expenses> myExpenses;
        public frmMain()
        {
            InitializeComponent();
            myUsers = new BindingList<Persons>();
            myExpenses = new BindingList<Expenses>();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            GetLoad();
            var frmSecurtyHelper = new frmSecurty(myUsers);
            frmSecurtyHelper.ShowDialog();
            //test amaçlıdır
        }

        private void btnOpenThe_frmNewExpense_Click(object sender, EventArgs e)
        {
            var frmNewExpense_Helper = new frmNewExpense(myUsers, myExpenses);
            frmNewExpense_Helper.ShowDialog();
        }

        private void btnOpenThe_frmUsers_Click(object sender, EventArgs e)
        {
            var frmUsersHelper = new frmPersons(myUsers, myExpenses);
            frmUsersHelper.ShowDialog();
        }



        
        /// <summary>
        /// GetLoad
        /// </summary>
        ///     . Bu Method test amaçlı veri kaynağıdır..
        private void GetLoad()
        {
            myUsers.Add(new Persons { FirstName = "Gamze", LastName = "Uysal (me)"});
            myUsers.Add(new Persons { FirstName = "Sergen", LastName = "Kahraman"});
            myUsers.Add(new Persons { FirstName = "Hami", LastName = "Aktaş"});
            myUsers.Add(new Persons { FirstName = "Emre", LastName = "Ertuğrul"});
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
