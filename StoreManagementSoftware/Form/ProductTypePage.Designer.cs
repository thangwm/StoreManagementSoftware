namespace StoreManagementSoftware
{
    partial class ProductTypePage
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
            this.grbaccountinformation = new System.Windows.Forms.GroupBox();
            this.txtproducttype = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lbproducttype = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.dataproducttype = new System.Windows.Forms.DataGridView();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.btreset = new System.Windows.Forms.Button();
            this.btsearch = new System.Windows.Forms.Button();
            this.grblistofproducttype = new System.Windows.Forms.GroupBox();
            this.lbfind = new System.Windows.Forms.Label();
            this.btrefresh = new System.Windows.Forms.Button();
            this.grbfunction.SuspendLayout();
            this.grbaccountinformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataproducttype)).BeginInit();
            this.grblistofproducttype.SuspendLayout();
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
            this.grbfunction.Location = new System.Drawing.Point(0, 156);
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
            // grbaccountinformation
            // 
            this.grbaccountinformation.Controls.Add(this.txtproducttype);
            this.grbaccountinformation.Controls.Add(this.txtid);
            this.grbaccountinformation.Controls.Add(this.lbproducttype);
            this.grbaccountinformation.Controls.Add(this.lbid);
            this.grbaccountinformation.Location = new System.Drawing.Point(0, 0);
            this.grbaccountinformation.Name = "grbaccountinformation";
            this.grbaccountinformation.Size = new System.Drawing.Size(376, 150);
            this.grbaccountinformation.TabIndex = 18;
            this.grbaccountinformation.TabStop = false;
            this.grbaccountinformation.Text = "Product Type Information";
            // 
            // txtproducttype
            // 
            this.txtproducttype.Location = new System.Drawing.Point(100, 94);
            this.txtproducttype.Name = "txtproducttype";
            this.txtproducttype.Size = new System.Drawing.Size(250, 22);
            this.txtproducttype.TabIndex = 10;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(100, 43);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(125, 22);
            this.txtid.TabIndex = 9;
            // 
            // lbproducttype
            // 
            this.lbproducttype.AutoSize = true;
            this.lbproducttype.Location = new System.Drawing.Point(12, 100);
            this.lbproducttype.Name = "lbproducttype";
            this.lbproducttype.Size = new System.Drawing.Size(85, 16);
            this.lbproducttype.TabIndex = 1;
            this.lbproducttype.Text = "Product type:";
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
            // dataproducttype
            // 
            this.dataproducttype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataproducttype.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataproducttype.Location = new System.Drawing.Point(3, 100);
            this.dataproducttype.Name = "dataproducttype";
            this.dataproducttype.RowHeadersWidth = 51;
            this.dataproducttype.RowTemplate.Height = 24;
            this.dataproducttype.Size = new System.Drawing.Size(894, 550);
            this.dataproducttype.TabIndex = 0;
            this.dataproducttype.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataproducttype_CellContentClick);
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
            // grblistofproducttype
            // 
            this.grblistofproducttype.Controls.Add(this.btreset);
            this.grblistofproducttype.Controls.Add(this.btsearch);
            this.grblistofproducttype.Controls.Add(this.txtfind);
            this.grblistofproducttype.Controls.Add(this.lbfind);
            this.grblistofproducttype.Controls.Add(this.dataproducttype);
            this.grblistofproducttype.Dock = System.Windows.Forms.DockStyle.Right;
            this.grblistofproducttype.Location = new System.Drawing.Point(382, 0);
            this.grblistofproducttype.Name = "grblistofproducttype";
            this.grblistofproducttype.Size = new System.Drawing.Size(900, 653);
            this.grblistofproducttype.TabIndex = 19;
            this.grblistofproducttype.TabStop = false;
            this.grblistofproducttype.Text = "List Of Product Type";
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
            this.btrefresh.TabIndex = 21;
            this.btrefresh.Text = "Refresh";
            this.btrefresh.UseVisualStyleBackColor = true;
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // ProductTypePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.grbfunction);
            this.Controls.Add(this.grbaccountinformation);
            this.Controls.Add(this.grblistofproducttype);
            this.Name = "ProductTypePage";
            this.Text = "ProductTypePage";
            this.Load += new System.EventHandler(this.ProductTypePage_Load);
            this.grbfunction.ResumeLayout(false);
            this.grbaccountinformation.ResumeLayout(false);
            this.grbaccountinformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataproducttype)).EndInit();
            this.grblistofproducttype.ResumeLayout(false);
            this.grblistofproducttype.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.GroupBox grbfunction;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.GroupBox grbaccountinformation;
        private System.Windows.Forms.TextBox txtproducttype;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lbproducttype;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.DataGridView dataproducttype;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.GroupBox grblistofproducttype;
        private System.Windows.Forms.Label lbfind;
        private System.Windows.Forms.Button btrefresh;
    }
}