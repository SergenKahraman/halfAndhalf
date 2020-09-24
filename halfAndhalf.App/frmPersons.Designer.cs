namespace halfAndhalf.App
{
    partial class frmPersons
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
            this.components = new System.ComponentModel.Container();
            this.lstInfoUsers = new System.Windows.Forms.ListBox();
            this.ctxUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxButtonDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtUserLastName = new System.Windows.Forms.TextBox();
            this.txtUserFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctxUsers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstInfoUsers
            // 
            this.lstInfoUsers.ContextMenuStrip = this.ctxUsers;
            this.lstInfoUsers.FormattingEnabled = true;
            this.lstInfoUsers.Location = new System.Drawing.Point(332, 41);
            this.lstInfoUsers.Name = "lstInfoUsers";
            this.lstInfoUsers.Size = new System.Drawing.Size(263, 355);
            this.lstInfoUsers.TabIndex = 0;
            this.lstInfoUsers.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstInfoUsers_MouseUp);
            // 
            // ctxUsers
            // 
            this.ctxUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxButtonDelete});
            this.ctxUsers.Name = "ctxUsers";
            this.ctxUsers.Size = new System.Drawing.Size(144, 26);
            // 
            // ctxButtonDelete
            // 
            this.ctxButtonDelete.Name = "ctxButtonDelete";
            this.ctxButtonDelete.Size = new System.Drawing.Size(143, 22);
            this.ctxButtonDelete.Text = "Kullanıcıyı Sil";
            this.ctxButtonDelete.Click += new System.EventHandler(this.ctxButtonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddUser);
            this.groupBox1.Controls.Add(this.txtUserLastName);
            this.groupBox1.Controls.Add(this.txtUserFirstName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 151);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kişi Ekle";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(154, 114);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "EKLE";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtUserLastName
            // 
            this.txtUserLastName.Location = new System.Drawing.Point(73, 73);
            this.txtUserLastName.Name = "txtUserLastName";
            this.txtUserLastName.Size = new System.Drawing.Size(156, 20);
            this.txtUserLastName.TabIndex = 1;
            // 
            // txtUserFirstName
            // 
            this.txtUserFirstName.Location = new System.Drawing.Point(73, 40);
            this.txtUserFirstName.Name = "txtUserFirstName";
            this.txtUserFirstName.Size = new System.Drawing.Size(156, 20);
            this.txtUserFirstName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soy Adı";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 411);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstInfoUsers);
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kullancılar";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.ctxUsers.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstInfoUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtUserLastName;
        private System.Windows.Forms.TextBox txtUserFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip ctxUsers;
        private System.Windows.Forms.ToolStripMenuItem ctxButtonDelete;
    }
}