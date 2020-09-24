using halfAndhalf.App.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace halfAndhalf.App
{
    public partial class frmSecurty : Form
    {
        public BindingList<Persons> myUsersSecurty;
        public bool IsIdPasswordTrue = false;
        public static string Password = "1234";
        public frmSecurty(BindingList<Persons> myUsers)
        {
            InitializeComponent();
            myUsersSecurty = myUsers;
        }

        private void frmSecurty_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsIdPasswordTrue == false)
            {
                Application.Exit();
            }
        }

        private void btnEnterance_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text == Password)
            {
                IsIdPasswordTrue = true;
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Şifre Yanlış!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEnterance_Click(null, null);
            }
        }
    }
}
