namespace halfAndhalf.App
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnOpenThe_frmNewExpense = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnOpenThe_frmUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenThe_frmNewExpense
            // 
            this.btnOpenThe_frmNewExpense.Location = new System.Drawing.Point(169, 40);
            this.btnOpenThe_frmNewExpense.Name = "btnOpenThe_frmNewExpense";
            this.btnOpenThe_frmNewExpense.Size = new System.Drawing.Size(183, 106);
            this.btnOpenThe_frmNewExpense.TabIndex = 0;
            this.btnOpenThe_frmNewExpense.Text = "Yeni İşlem Ekle";
            this.btnOpenThe_frmNewExpense.UseVisualStyleBackColor = true;
            this.btnOpenThe_frmNewExpense.Click += new System.EventHandler(this.btnOpenThe_frmNewExpense_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 106);
            this.button2.TabIndex = 1;
            this.button2.Text = "Tüm İşlemler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 106);
            this.button3.TabIndex = 2;
            this.button3.Text = "Rapor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnOpenThe_frmUsers
            // 
            this.btnOpenThe_frmUsers.Location = new System.Drawing.Point(12, 472);
            this.btnOpenThe_frmUsers.Name = "btnOpenThe_frmUsers";
            this.btnOpenThe_frmUsers.Size = new System.Drawing.Size(208, 60);
            this.btnOpenThe_frmUsers.TabIndex = 3;
            this.btnOpenThe_frmUsers.Text = "Kullanıcılar";
            this.btnOpenThe_frmUsers.UseVisualStyleBackColor = true;
            this.btnOpenThe_frmUsers.Click += new System.EventHandler(this.btnOpenThe_frmUsers_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 544);
            this.Controls.Add(this.btnOpenThe_frmUsers);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOpenThe_frmNewExpense);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Half&half";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenThe_frmNewExpense;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnOpenThe_frmUsers;
    }
}

