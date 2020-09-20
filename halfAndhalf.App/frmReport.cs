using halfAndhalf.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace halfAndhalf.App
{
    public partial class frmReport : Form
    {
        private BindingList<Expenses> myExpensesRapor;
        private BindingList<Users> myUsersRapor;
        public frmReport(BindingList<Expenses> myExpenses, BindingList<Users> myUsers)
        {
            InitializeComponent();
            myExpensesRapor = myExpenses;
            myUsersRapor = myUsers;
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

       
    }
}
