namespace StoreManagementSoftware
{
    partial class AccountPage
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
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.grblistofaccount = new System.Windows.Forms.GroupBox();
            this.btreset = new System.Windows.Forms.Button();
            this.btsearch = new System.Windows.Forms.Button();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.lbfind = new System.Windows.Forms.Label();
            this.dataaccount = new System.Windows.Forms.DataGridView();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lbpassword = new System.Windows.Forms.Label();
            this.lbusername = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.grbaccountinformation = new System.Windows.Forms.GroupBox();
            this.grbfunction = new System.Windows.Forms.GroupBox();
            this.btdelete = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btrefresh = new System.Windows.Forms.Button();
            this.grblistofaccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataaccount)).BeginInit();
            this.grbaccountinformation.SuspendLayout();
            this.grbfunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(100, 144);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(250, 22);
            this.txtpassword.TabIndex = 13;
            // 
            // grblistofaccount
            // 
            this.grblistofaccount.Controls.Add(this.btreset);
            this.grblistofaccount.Controls.Add(this.btsearch);
            this.grblistofaccount.Controls.Add(this.txtfind);
            this.grblistofaccount.Controls.Add(this.lbfind);
            this.grblistofaccount.Controls.Add(this.dataaccount);
            this.grblistofaccount.Dock = System.Windows.Forms.DockStyle.Right;
            this.grblistofaccount.Location = new System.Drawing.Point(382, 0);
            this.grblistofaccount.Name = "grblistofaccount";
            this.grblistofaccount.Size = new System.Drawing.Size(900, 653);
            this.grblistofaccount.TabIndex = 5;
            this.grblistofaccount.TabStop = false;
            this.grblistofaccount.Text = "List Of Account";
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(450, 43);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(75, 23);
            this.btreset.TabIndex = 16;
            this.btreset.Text = "Reset";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // btsearch
            // 
            this.btsearch.Location = new System.Drawing.Point(350, 44);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(75, 23);
            this.btsearch.TabIndex = 15;
            this.btsearch.Text = "Search";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(75, 44);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(250, 22);
            this.txtfind.TabIndex = 14;
            // 
            // lbfind
            // 
            this.lbfind.AutoSize = true;
            this.lbfind.Location = new System.Drawing.Point(12, 50);
            this.lbfind.Name = "lbfind";
            this.lbfind.Size = new System.Drawing.Size(36, 16);
            this.lbfind.TabIndex = 9;
            this.lbfind.Text = "Find:";
            // 
            // dataaccount
            // 
            this.dataaccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataaccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataaccount.Location = new System.Drawing.Point(3, 100);
            this.dataaccount.Name = "dataaccount";
            this.dataaccount.RowHeadersWidth = 51;
            this.dataaccount.RowTemplate.Height = 24;
            this.dataaccount.Size = new System.Drawing.Size(894, 550);
            this.dataaccount.TabIndex = 0;
            this.dataaccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataaccount_CellContentClick);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(100, 94);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(250, 22);
            this.txtusername.TabIndex = 10;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(100, 43);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(125, 22);
            this.txtid.TabIndex = 9;
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Location = new System.Drawing.Point(12, 150);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(70, 16);
            this.lbpassword.TabIndex = 3;
            this.lbpassword.Text = "Password:";
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Location = new System.Drawing.Point(12, 100);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(73, 16);
            this.lbusername.TabIndex = 1;
            this.lbusername.Text = "Username:";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(12, 50);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(23, 16);
            this.lbid.TabIndex = 0;
            this.lbid.Text = "ID:";
            // 
            // grbaccountinformation
            // 
            this.grbaccountinformation.Controls.Add(this.txtpassword);
            this.grbaccountinformation.Controls.Add(this.txtusername);
            this.grbaccountinformation.Controls.Add(this.txtid);
            this.grbaccountinformation.Controls.Add(this.lbpassword);
            this.grbaccountinformation.Controls.Add(this.lbusername);
            this.grbaccountinformation.Controls.Add(this.lbid);
            this.grbaccountinformation.Location = new System.Drawing.Point(0, 0);
            this.grbaccountinformation.Name = "grbaccountinformation";
            this.grbaccountinformation.Size = new System.Drawing.Size(376, 200);
            this.grbaccountinformation.TabIndex = 3;
            this.grbaccountinformation.TabStop = false;
            this.grbaccountinformation.Text = "Account Information";
            // 
            // grbfunction
            // 
            this.grbfunction.Controls.Add(this.btrefresh);
            this.grbfunction.Controls.Add(this.btdelete);
            this.grbfunction.Controls.Add(this.btupdate);
            this.grbfunction.Controls.Add(this.btadd);
            this.grbfunction.Location = new System.Drawing.Point(0, 206);
            this.grbfunction.Name = "grbfunction";
            this.grbfunction.Size = new System.Drawing.Size(376, 100);
            this.grbfunction.TabIndex = 17;
            this.grbfunction.TabStop = false;
            this.grbfunction.Text = "Function";
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(200, 50);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 23);
            this.btdelete.TabIndex = 19;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(100, 50);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(75, 23);
            this.btupdate.TabIndex = 18;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(12, 50);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 23);
            this.btadd.TabIndex = 17;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btrefresh
            // 
            this.btrefresh.Location = new System.Drawing.Point(300, 50);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(75, 23);
            this.btrefresh.TabIndex = 21;
            this.btrefresh.Text = "Refresh";
            this.btrefresh.UseVisualStyleBackColor = true;
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // AccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.grbfunction);
            this.Controls.Add(this.grblistofaccount);
            this.Controls.Add(this.grbaccountinformation);
            this.Name = "AccountPage";
            this.Text = "AccountPage";
            this.Load += new System.EventHandler(this.AccountPage_Load);
            this.grblistofaccount.ResumeLayout(false);
            this.grblistofaccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataaccount)).EndInit();
            this.grbaccountinformation.ResumeLayout(false);
            this.grbaccountinformation.PerformLayout();
            this.grbfunction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.GroupBox grblistofaccount;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Label lbfind;
        private System.Windows.Forms.DataGridView dataaccount;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.GroupBox grbaccountinformation;
        private System.Windows.Forms.GroupBox grbfunction;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btrefresh;
    }
}