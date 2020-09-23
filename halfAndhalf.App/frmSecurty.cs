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
    public partial class frmSecurty : Form
    {
        public BindingList<Users> myUsersSecurty;
        public bool IsIdPasswordTrue = false;
        public frmSecurty(BindingList<Users> myUsers)
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

            if (myUsersSecurty.Count == 0)
            {
                if (txtId.Text == "Admin" && txtPassword.Text == "Admin1234")
                {
                    IsIdPasswordTrue = true;
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Id veya Sifre YANLIŞ!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtId.Clear();
                    txtPassword.Clear();
                    return;
                }
            }
            else
            {
                foreach (var user in myUsersSecurty)
                {
                    if (user.ToString() == txtId.Text && user.Password == txtPassword.Text)
                    {
                        IsIdPasswordTrue = true;
                        this.Close();
                        return;
                    }
                }
                MessageBox.Show("Id veya Sifre YANLIŞ!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Clear();
                txtPassword.Clear();
            }
        }
    }
}
