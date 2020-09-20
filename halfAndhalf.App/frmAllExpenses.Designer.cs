namespace halfAndhalf.App
{
    partial class frmAllExpenses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstDisplayAllExpenses = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDetailsOfExpense = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExplanationD = new System.Windows.Forms.TextBox();
            this.txtExpensePriceD = new System.Windows.Forms.TextBox();
            this.txtExpenseDateD = new System.Windows.Forms.TextBox();
            this.txtExpenseNameD = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpDetailsOfExpense.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDisplayAllExpenses
            // 
            this.lstDisplayAllExpenses.FormattingEnabled = true;
            this.lstDisplayAllExpenses.Location = new System.Drawing.Point(29, 27);
            this.lstDisplayAllExpenses.Name = "lstDisplayAllExpenses";
            this.lstDisplayAllExpenses.Size = new System.Drawing.Size(271, 498);
            this.lstDisplayAllExpenses.TabIndex = 0;
            this.lstDisplayAllExpenses.SelectedIndexChanged += new System.EventHandler(this.lstDisplayAllExpenses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(128, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "İşlemler";
            // 
            // grpDetailsOfExpense
            // 
            this.grpDetailsOfExpense.Controls.Add(this.label7);
            this.grpDetailsOfExpense.Controls.Add(this.txtExplanationD);
            this.grpDetailsOfExpense.Controls.Add(this.txtExpensePriceD);
            this.grpDetailsOfExpense.Controls.Add(this.txtExpenseDateD);
            this.grpDetailsOfExpense.Controls.Add(this.txtExpenseNameD);
            this.grpDetailsOfExpense.Controls.Add(this.txtUserName);
            this.grpDetailsOfExpense.Controls.Add(this.label5);
            this.grpDetailsOfExpense.Controls.Add(this.label3);
            this.grpDetailsOfExpense.Controls.Add(this.label4);
            this.grpDetailsOfExpense.Controls.Add(this.label2);
            this.grpDetailsOfExpense.Controls.Add(this.label6);
            this.grpDetailsOfExpense.Location = new System.Drawing.Point(326, 27);
            this.grpDetailsOfExpense.Name = "grpDetailsOfExpense";
            this.grpDetailsOfExpense.Size = new System.Drawing.Size(403, 371);
            this.grpDetailsOfExpense.TabIndex = 2;
            this.grpDetailsOfExpense.TabStop = false;
            this.grpDetailsOfExpense.Text = "Detaylar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(323, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "TL";
            // 
            // txtExplanationD
            // 
            this.txtExplanationD.Location = new System.Drawing.Point(126, 234);
            this.txtExplanationD.Multiline = true;
            this.txtExplanationD.Name = "txtExplanationD";
            this.txtExplanationD.ReadOnly = true;
            this.txtExplanationD.Size = new System.Drawing.Size(223, 79);
            this.txtExplanationD.TabIndex = 18;
            // 
            // txtExpensePriceD
            // 
            this.txtExpensePriceD.Location = new System.Drawing.Point(126, 186);
            this.txtExpensePriceD.Name = "txtExpensePriceD";
            this.txtExpensePriceD.ReadOnly = true;
            this.txtExpensePriceD.Size = new System.Drawing.Size(196, 20);
            this.txtExpensePriceD.TabIndex = 18;
            this.txtExpensePriceD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtExpenseDateD
            // 
            this.txtExpenseDateD.Location = new System.Drawing.Point(126, 136);
            this.txtExpenseDateD.Name = "txtExpenseDateD";
            this.txtExpenseDateD.ReadOnly = true;
            this.txtExpenseDateD.Size = new System.Drawing.Size(223, 20);
            this.txtExpenseDateD.TabIndex = 18;
            // 
            // txtExpenseNameD
            // 
            this.txtExpenseNameD.Location = new System.Drawing.Point(126, 89);
            this.txtExpenseNameD.Name = "txtExpenseNameD";
            this.txtExpenseNameD.ReadOnly = true;
            this.txtExpenseNameD.Size = new System.Drawing.Size(223, 20);
            this.txtExpenseNameD.TabIndex = 18;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(126, 39);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(223, 20);
            this.txtUserName.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(45, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "İşlem Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "İşlem Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(47, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Açıklama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kullanıcı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(29, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "İşlem Tutarı";
            // 
            // frmAllExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 552);
            this.Controls.Add(this.grpDetailsOfExpense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDisplayAllExpenses);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAllExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tüm İşlemler";
            this.Load += new System.EventHandler(this.frmAllExpenses_Load);
            this.grpDetailsOfExpense.ResumeLayout(false);
            this.grpDetailsOfExpense.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDisplayAllExpenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDetailsOfExpense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtExplanationD;
        private System.Windows.Forms.TextBox txtExpensePriceD;
        private System.Windows.Forms.TextBox txtExpenseDateD;
        private System.Windows.Forms.TextBox txtExpenseNameD;
        private System.Windows.Forms.Label label7;
    }
}