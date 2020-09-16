using halfAndhalf.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace halfAndhalf.App
{
    public partial class frmMain : Form
    {
        public BindingList<Users> myUsers;
        public frmMain()
        {
            InitializeComponent();
            myUsers = new BindingList<Users>();
        }

       

        private void btnOpenThe_frmNewExpense_Click(object sender, EventArgs e)
        {
            var frmNewExpense_Helper = new frmNewExpense(myUsers);
            frmNewExpense_Helper.ShowDialog();
        }

        private void btnOpenThe_frmUsers_Click(object sender, EventArgs e)
        {
            var frmUsersHelper = new frmUsers(myUsers);
            frmUsersHelper.ShowDialog();
        }
    }
}
