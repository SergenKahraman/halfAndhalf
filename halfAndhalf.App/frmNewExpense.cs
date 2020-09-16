using halfAndhalf.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Windows.Forms;

namespace halfAndhalf.App
{
    public partial class frmNewExpense : Form
    {
        public BindingList<Users> myUsers;
        public frmNewExpense(BindingList<Users> myUsers)
        {
            InitializeComponent();
            this.myUsers = myUsers;
        }

        private void frmNewExpense_Load(object sender, EventArgs e)
        {
            cmbUsers.DataSource = myUsers;
        }
    }
}
