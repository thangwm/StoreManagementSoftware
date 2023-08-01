namespace StoreManagementSoftware
{
    partial class TablePage
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
            this.btdelete = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.grbfunction = new System.Windows.Forms.GroupBox();
            this.btupdate = new System.Windows.Forms.Button();
            this.grbtableinformation = new System.Windows.Forms.GroupBox();
            this.txtstatus = new System.Windows.Forms.ComboBox();
            this.txttablename = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lbstatus = new System.Windows.Forms.Label();
            this.lbtablename = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.datatable = new System.Windows.Forms.DataGridView();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.btreset = new System.Windows.Forms.Button();
            this.btsearch = new System.Windows.Forms.Button();
            this.grblistoftable = new System.Windows.Forms.GroupBox();
            this.lbfind = new System.Windows.Forms.Label();
            this.btrefresh = new System.Windows.Forms.Button();
            this.grbfunction.SuspendLayout();
            this.grbtableinformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatable)).BeginInit();
            this.grblistoftable.SuspendLayout();
            this.SuspendLayout();
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
            // grbfunction
            // 
            this.grbfunction.Controls.Add(this.btrefresh);
            this.grbfunction.Controls.Add(this.btdelete);
            this.grbfunction.Controls.Add(this.btupdate);
            this.grbfunction.Controls.Add(this.btadd);
            this.grbfunction.Location = new System.Drawing.Point(0, 206);
            this.grbfunction.Name = "grbfunction";
            this.grbfunction.Size = new System.Drawing.Size(376, 100);
            this.grbfunction.TabIndex = 20;
            this.grbfunction.TabStop = false;
            this.grbfunction.Text = "Function";
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
            // grbtableinformation
            // 
            this.grbtableinformation.Controls.Add(this.txtstatus);
            this.grbtableinformation.Controls.Add(this.txttablename);
            this.grbtableinformation.Controls.Add(this.txtid);
            this.grbtableinformation.Controls.Add(this.lbstatus);
            this.grbtableinformation.Controls.Add(this.lbtablename);
            this.grbtableinformation.Controls.Add(this.lbid);
            this.grbtableinformation.Location = new System.Drawing.Point(0, 0);
            this.grbtableinformation.Name = "grbtableinformation";
            this.grbtableinformation.Size = new System.Drawing.Size(376, 200);
            this.grbtableinformation.TabIndex = 18;
            this.grbtableinformation.TabStop = false;
            this.grbtableinformation.Text = "Table Information";
            // 
            // txtstatus
            // 
            this.txtstatus.FormattingEnabled = true;
            this.txtstatus.Items.AddRange(new object[] {
            "Empty",
            "Have Customer"});
            this.txtstatus.Location = new System.Drawing.Point(100, 142);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(250, 24);
            this.txtstatus.TabIndex = 11;
            // 
            // txttablename
            // 
            this.txttablename.Location = new System.Drawing.Point(100, 94);
            this.txttablename.Name = "txttablename";
            this.txttablename.Size = new System.Drawing.Size(250, 22);
            this.txttablename.TabIndex = 10;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(100, 43);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(125, 22);
            this.txtid.TabIndex = 9;
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Location = new System.Drawing.Point(12, 150);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(47, 16);
            this.lbstatus.TabIndex = 3;
            this.lbstatus.Text = "Status:";
            // 
            // lbtablename
            // 
            this.lbtablename.AutoSize = true;
            this.lbtablename.Location = new System.Drawing.Point(12, 100);
            this.lbtablename.Name = "lbtablename";
            this.lbtablename.Size = new System.Drawing.Size(83, 16);
            this.lbtablename.TabIndex = 1;
            this.lbtablename.Text = "Table name:";
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
            // datatable
            // 
            this.datatable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datatable.Location = new System.Drawing.Point(3, 100);
            this.datatable.Name = "datatable";
            this.datatable.RowHeadersWidth = 51;
            this.datatable.RowTemplate.Height = 24;
            this.datatable.Size = new System.Drawing.Size(894, 550);
            this.datatable.TabIndex = 0;
            this.datatable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datatable_CellContentClick);
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(75, 44);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(250, 22);
            this.txtfind.TabIndex = 14;
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
            // grblistoftable
            // 
            this.grblistoftable.Controls.Add(this.btreset);
            this.grblistoftable.Controls.Add(this.btsearch);
            this.grblistoftable.Controls.Add(this.txtfind);
            this.grblistoftable.Controls.Add(this.lbfind);
            this.grblistoftable.Controls.Add(this.datatable);
            this.grblistoftable.Dock = System.Windows.Forms.DockStyle.Right;
            this.grblistoftable.Location = new System.Drawing.Point(382, 0);
            this.grblistoftable.Name = "grblistoftable";
            this.grblistoftable.Size = new System.Drawing.Size(900, 653);
            this.grblistoftable.TabIndex = 19;
            this.grblistoftable.TabStop = false;
            this.grblistoftable.Text = "List Of Table";
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
            // btrefresh
            // 
            this.btrefresh.Location = new System.Drawing.Point(300, 50);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(75, 23);
            this.btrefresh.TabIndex = 22;
            this.btrefresh.Text = "Refresh";
            this.btrefresh.UseVisualStyleBackColor = true;
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // TablePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.grbfunction);
            this.Controls.Add(this.grbtableinformation);
            this.Controls.Add(this.grblistoftable);
            this.Name = "TablePage";
            this.Text = "TablePage";
            this.Load += new System.EventHandler(this.TablePage_Load);
            this.grbfunction.ResumeLayout(false);
            this.grbtableinformation.ResumeLayout(false);
            this.grbtableinformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatable)).EndInit();
            this.grblistoftable.ResumeLayout(false);
            this.grblistoftable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.GroupBox grbfunction;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.GroupBox grbtableinformation;
        private System.Windows.Forms.TextBox txttablename;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lbstatus;
        private System.Windows.Forms.Label lbtablename;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.DataGridView datatable;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.GroupBox grblistoftable;
        private System.Windows.Forms.Label lbfind;
        private System.Windows.Forms.ComboBox txtstatus;
        private System.Windows.Forms.Button btrefresh;
    }
}