using halfAndhalf.App.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace halfAndhalf.App
{
    public partial class frmUsers : Form
    {
        public BindingList<Users> myUsersKullanıcılar;
        public frmUsers(BindingList<Users> myUsers)
        {
            InitializeComponent();
            this.myUsersKullanıcılar = myUsers;
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            lstInfoUsers.DataSource = myUsersKullanıcılar;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var newUser = new Users
            {
                FirstName = txtUserFirstName.Text,
                LastName = txtUserLastName.Text,
                Password = txtUserPassword.Text
            };
            myUsersKullanıcılar.Add(newUser);
        }
    }
}
