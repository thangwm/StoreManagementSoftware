namespace StoreManagementSoftware
{
    partial class ProductPage
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
            this.lbvnd = new System.Windows.Forms.Label();
            this.lbimage = new System.Windows.Forms.Label();
            this.btaddptb = new System.Windows.Forms.Button();
            this.txtunitprice = new System.Windows.Forms.ComboBox();
            this.txtproducttype = new System.Windows.Forms.ComboBox();
            this.grblistofproduct = new System.Windows.Forms.GroupBox();
            this.btreset = new System.Windows.Forms.Button();
            this.btsearch = new System.Windows.Forms.Button();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.lbfind = new System.Windows.Forms.Label();
            this.dataproduct = new System.Windows.Forms.DataGridView();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.ptbproduct = new System.Windows.Forms.PictureBox();
            this.btupdate = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lbunitprice = new System.Windows.Forms.Label();
            this.lbproducttype = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.grbproductinformation = new System.Windows.Forms.GroupBox();
            this.lbproductname = new System.Windows.Forms.Label();
            this.grbfunction = new System.Windows.Forms.GroupBox();
            this.btrefresh = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.grblistofproduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbproduct)).BeginInit();
            this.grbproductinformation.SuspendLayout();
            this.grbfunction.SuspendLayout();
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
            // lbvnd
            // 
            this.lbvnd.AutoSize = true;
            this.lbvnd.Location = new System.Drawing.Point(180, 200);
            this.lbvnd.Name = "lbvnd";
            this.lbvnd.Size = new System.Drawing.Size(36, 16);
            this.lbvnd.TabIndex = 22;
            this.lbvnd.Text = "VND";
            // 
            // lbimage
            // 
            this.lbimage.AutoSize = true;
            this.lbimage.Location = new System.Drawing.Point(12, 250);
            this.lbimage.Name = "lbimage";
            this.lbimage.Size = new System.Drawing.Size(48, 16);
            this.lbimage.TabIndex = 21;
            this.lbimage.Text = "Image:";
            // 
            // btaddptb
            // 
            this.btaddptb.Location = new System.Drawing.Point(75, 243);
            this.btaddptb.Name = "btaddptb";
            this.btaddptb.Size = new System.Drawing.Size(100, 23);
            this.btaddptb.TabIndex = 20;
            this.btaddptb.Text = "Add Picture";
            this.btaddptb.UseVisualStyleBackColor = true;
            this.btaddptb.Click += new System.EventHandler(this.btaddptb_Click);
            // 
            // txtunitprice
            // 
            this.txtunitprice.FormattingEnabled = true;
            this.txtunitprice.Location = new System.Drawing.Point(75, 192);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.Size = new System.Drawing.Size(100, 24);
            this.txtunitprice.TabIndex = 16;
            // 
            // txtproducttype
            // 
            this.txtproducttype.FormattingEnabled = true;
            this.txtproducttype.Location = new System.Drawing.Point(100, 142);
            this.txtproducttype.Name = "txtproducttype";
            this.txtproducttype.Size = new System.Drawing.Size(100, 24);
            this.txtproducttype.TabIndex = 14;
            // 
            // grblistofproduct
            // 
            this.grblistofproduct.Controls.Add(this.btreset);
            this.grblistofproduct.Controls.Add(this.btsearch);
            this.grblistofproduct.Controls.Add(this.txtfind);
            this.grblistofproduct.Controls.Add(this.lbfind);
            this.grblistofproduct.Controls.Add(this.dataproduct);
            this.grblistofproduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.grblistofproduct.Location = new System.Drawing.Point(382, 0);
            this.grblistofproduct.Name = "grblistofproduct";
            this.grblistofproduct.Size = new System.Drawing.Size(900, 653);
            this.grblistofproduct.TabIndex = 5;
            this.grblistofproduct.TabStop = false;
            this.grblistofproduct.Text = "List Of Product";
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
            // dataproduct
            // 
            this.dataproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataproduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataproduct.Location = new System.Drawing.Point(3, 100);
            this.dataproduct.Name = "dataproduct";
            this.dataproduct.RowHeadersWidth = 51;
            this.dataproduct.RowTemplate.Height = 24;
            this.dataproduct.Size = new System.Drawing.Size(894, 550);
            this.dataproduct.TabIndex = 0;
            this.dataproduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataproduct_CellContentClick);
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(125, 94);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(200, 22);
            this.txtproductname.TabIndex = 10;
            // 
            // ptbproduct
            // 
            this.ptbproduct.Image = global::StoreManagementSoftware.Properties.Resources._3;
            this.ptbproduct.Location = new System.Drawing.Point(220, 142);
            this.ptbproduct.Name = "ptbproduct";
            this.ptbproduct.Size = new System.Drawing.Size(150, 200);
            this.ptbproduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbproduct.TabIndex = 7;
            this.ptbproduct.TabStop = false;
            this.ptbproduct.Click += new System.EventHandler(this.ptbproduct_Click);
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
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(75, 44);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(125, 22);
            this.txtid.TabIndex = 9;
            // 
            // lbunitprice
            // 
            this.lbunitprice.AutoSize = true;
            this.lbunitprice.Location = new System.Drawing.Point(12, 200);
            this.lbunitprice.Name = "lbunitprice";
            this.lbunitprice.Size = new System.Drawing.Size(66, 16);
            this.lbunitprice.TabIndex = 6;
            this.lbunitprice.Text = "Unit price:";
            // 
            // lbproducttype
            // 
            this.lbproducttype.AutoSize = true;
            this.lbproducttype.Location = new System.Drawing.Point(12, 150);
            this.lbproducttype.Name = "lbproducttype";
            this.lbproducttype.Size = new System.Drawing.Size(85, 16);
            this.lbproducttype.TabIndex = 2;
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
            // grbproductinformation
            // 
            this.grbproductinformation.Controls.Add(this.lbvnd);
            this.grbproductinformation.Controls.Add(this.lbimage);
            this.grbproductinformation.Controls.Add(this.btaddptb);
            this.grbproductinformation.Controls.Add(this.txtunitprice);
            this.grbproductinformation.Controls.Add(this.txtproducttype);
            this.grbproductinformation.Controls.Add(this.txtproductname);
            this.grbproductinformation.Controls.Add(this.txtid);
            this.grbproductinformation.Controls.Add(this.ptbproduct);
            this.grbproductinformation.Controls.Add(this.lbunitprice);
            this.grbproductinformation.Controls.Add(this.lbproducttype);
            this.grbproductinformation.Controls.Add(this.lbproductname);
            this.grbproductinformation.Controls.Add(this.lbid);
            this.grbproductinformation.Location = new System.Drawing.Point(0, 0);
            this.grbproductinformation.Name = "grbproductinformation";
            this.grbproductinformation.Size = new System.Drawing.Size(376, 349);
            this.grbproductinformation.TabIndex = 3;
            this.grbproductinformation.TabStop = false;
            this.grbproductinformation.Text = "Product Information";
            // 
            // lbproductname
            // 
            this.lbproductname.AutoSize = true;
            this.lbproductname.Location = new System.Drawing.Point(12, 100);
            this.lbproductname.Name = "lbproductname";
            this.lbproductname.Size = new System.Drawing.Size(103, 16);
            this.lbproductname.TabIndex = 1;
            this.lbproductname.Text = "Product\'s name:";
            // 
            // grbfunction
            // 
            this.grbfunction.Controls.Add(this.btrefresh);
            this.grbfunction.Controls.Add(this.btdelete);
            this.grbfunction.Controls.Add(this.btupdate);
            this.grbfunction.Controls.Add(this.btadd);
            this.grbfunction.Location = new System.Drawing.Point(0, 355);
            this.grbfunction.Name = "grbfunction";
            this.grbfunction.Size = new System.Drawing.Size(376, 100);
            this.grbfunction.TabIndex = 4;
            this.grbfunction.TabStop = false;
            this.grbfunction.Text = "Function";
            // 
            // btrefresh
            // 
            this.btrefresh.Location = new System.Drawing.Point(300, 50);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(75, 23);
            this.btrefresh.TabIndex = 20;
            this.btrefresh.Text = "Refresh";
            this.btrefresh.UseVisualStyleBackColor = true;
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // ProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.grblistofproduct);
            this.Controls.Add(this.grbproductinformation);
            this.Controls.Add(this.grbfunction);
            this.Name = "ProductPage";
            this.Text = "ProductPage";
            this.Load += new System.EventHandler(this.ProductPage_Load);
            this.grblistofproduct.ResumeLayout(false);
            this.grblistofproduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbproduct)).EndInit();
            this.grbproductinformation.ResumeLayout(false);
            this.grbproductinformation.PerformLayout();
            this.grbfunction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Label lbvnd;
        private System.Windows.Forms.Label lbimage;
        private System.Windows.Forms.Button btaddptb;
        private System.Windows.Forms.ComboBox txtunitprice;
        private System.Windows.Forms.ComboBox txtproducttype;
        private System.Windows.Forms.GroupBox grblistofproduct;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Label lbfind;
        private System.Windows.Forms.DataGridView dataproduct;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.PictureBox ptbproduct;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lbunitprice;
        private System.Windows.Forms.Label lbproducttype;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.GroupBox grbproductinformation;
        private System.Windows.Forms.Label lbproductname;
        private System.Windows.Forms.GroupBox grbfunction;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btrefresh;
    }
}