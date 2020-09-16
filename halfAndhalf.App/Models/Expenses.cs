﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halfAndhalf.App.Models
{
    public class Expenses
    {
        public Expenses(string expenseName, DateTime expenseDate, double expensePrice, string expenseExplanation, Users userOwnExpense)
        {
            ExpenseName = expenseName;
            ExpenseDate = expenseDate;
            ExpensePrice = expensePrice;
            ExpenseExplanation = expenseExplanation;
            UserOwnExpense = userOwnExpense;
        }
        public string ExpenseName { get; set; }
        public DateTime ExpenseDate { get; set; }
        public double ExpensePrice { get; set; }
        public string ExpenseExplanation { get; set; }
        public Users UserOwnExpense { get; set; }

    }



}
