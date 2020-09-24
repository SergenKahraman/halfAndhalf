using halfAndhalf.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace halfAndhalf.App
{
    public partial class frmReport : Form
    {
        private BindingList<Expenses> myExpensesRapor;
        private BindingList<Persons> myUsersRapor;

        private Button NewButton;
        public frmReport(BindingList<Expenses> myExpenses, BindingList<Persons> myUsers)
        {
            InitializeComponent();
            myExpensesRapor = myExpenses;
            myUsersRapor = myUsers;
            NewButton = new Button()
            {
                Size = new Size(18, 18),
                Visible = false,
                //BackgroundImage = Image.FromFile("c:\\users\\sergen\\desktop\\halfandhalf\\halfandhalf.app\\bin\\debug\\go.png"),
                //BackgroundImageLayout = ImageLayout.Stretch
                ImageList = ımageList1,
                ImageIndex = 0
            };
            
            Controls.Add(NewButton);
            NewButton.Click += NewButton_Click;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            double totalPrice = 0;
            foreach (var ex in myExpensesRapor)
            {
                lstUserForReport.Items.Add($"{ex.UserOwnExpense}");
                lstPriceForReport.Items.Add($"{ex.ExpensePrice} TL");
                totalPrice += ex.ExpensePrice;
            }

            txtTotalPrice.Text = totalPrice.ToString();

            
            var RaporTextStringList = CalculateAllExpenses(totalPrice).ToList();
            
            foreach (var tx in RaporTextStringList)
            {
                lstDisplayResult.Items.Add(tx);
            }
            
        }



        private IEnumerable<string> CalculateAllExpenses(double totalPrice)
        {
            var arg = totalPrice / myUsersRapor.Count;

            foreach (var us in myUsersRapor)
            {
                if (us.TotalPrice < arg)
                {
                    yield return $"{us}     {arg - us.TotalPrice}TL  kadar borçludur";
                }
                else
                {
                    yield return $"{us}     {us.TotalPrice - arg}TL  kadar alacaklıdır";
                }
            }
        }

        

        private void NewButton_Click(object sender, EventArgs e)
        {
            var frmAllExpensesHelper2 = new frmAllExpenses(myExpensesRapor);
            frmAllExpensesHelper2.DesiredSelectedIndex = lstPriceForReport.SelectedIndex;
            frmAllExpensesHelper2.ShowDialog();
        }

        private void lstUserForReport_MouseMove(object sender, MouseEventArgs e)
        {
            var indexWeAreOn = lstUserForReport.IndexFromPoint(e.X, e.Y);
            lstUserForReport.SelectedIndex = indexWeAreOn;
            lstPriceForReport.SelectedIndex = indexWeAreOn;
            if (indexWeAreOn > -1)
            {
                NewButton.Location = new Point(8, 24 + indexWeAreOn * 13);
                NewButton.Visible = true;
            }
            else
            {
                NewButton.Visible = false;
            }
           
        }
    }
}
