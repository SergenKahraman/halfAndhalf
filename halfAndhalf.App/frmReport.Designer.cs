namespace halfAndhalf.App
{
    partial class frmReport
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
            this.lstUserForReport = new System.Windows.Forms.ListBox();
            this.lstPriceForReport = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDisplayResult = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUserForReport
            // 
            this.lstUserForReport.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lstUserForReport.FormattingEnabled = true;
            this.lstUserForReport.Location = new System.Drawing.Point(27, 25);
            this.lstUserForReport.Name = "lstUserForReport";
            this.lstUserForReport.Size = new System.Drawing.Size(136, 316);
            this.lstUserForReport.TabIndex = 0;
            // 
            // lstPriceForReport
            // 
            this.lstPriceForReport.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lstPriceForReport.FormattingEnabled = true;
            this.lstPriceForReport.Location = new System.Drawing.Point(169, 25);
            this.lstPriceForReport.Name = "lstPriceForReport";
            this.lstPriceForReport.Size = new System.Drawing.Size(136, 316);
            this.lstPriceForReport.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstDisplayResult);
            this.groupBox1.Location = new System.Drawing.Point(326, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alacak Verecek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOPLAM";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(205, 389);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(83, 20);
            this.txtTotalPrice.TabIndex = 3;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TL";
            // 
            // lstDisplayResult
            // 
            this.lstDisplayResult.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lstDisplayResult.FormattingEnabled = true;
            this.lstDisplayResult.Location = new System.Drawing.Point(17, 34);
            this.lstDisplayResult.Name = "lstDisplayResult";
            this.lstDisplayResult.Size = new System.Drawing.Size(310, 160);
            this.lstDisplayResult.TabIndex = 0;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 504);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstPriceForReport);
            this.Controls.Add(this.lstUserForReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUserForReport;
        private System.Windows.Forms.ListBox lstPriceForReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDisplayResult;
    }
}