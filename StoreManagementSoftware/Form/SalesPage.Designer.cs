namespace StoreManagementSoftware
{
    partial class SalesPage
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
            this.grblistoftable = new System.Windows.Forms.GroupBox();
            this.btupdatetable = new System.Windows.Forms.Button();
            this.btsearchtable = new System.Windows.Forms.Button();
            this.txtfindtable = new System.Windows.Forms.TextBox();
            this.lbfindtable = new System.Windows.Forms.Label();
            this.btresettable = new System.Windows.Forms.Button();
            this.datatable = new System.Windows.Forms.DataGridView();
            this.grblistofproduct = new System.Windows.Forms.GroupBox();
            this.btresetproduct = new System.Windows.Forms.Button();
            this.btsearchproduct = new System.Windows.Forms.Button();
            this.txtfindproduct = new System.Windows.Forms.TextBox();
            this.lbfindproduct = new System.Windows.Forms.Label();
            this.dataproduct = new System.Windows.Forms.DataGridView();
            this.grblistofinvoicedetails = new System.Windows.Forms.GroupBox();
            this.btrefresh = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.txtdatefounded = new System.Windows.Forms.DateTimePicker();
            this.lbvndtp = new System.Windows.Forms.Label();
            this.txttotalprice = new System.Windows.Forms.TextBox();
            this.lbdatefounded = new System.Windows.Forms.Label();
            this.btpay = new System.Windows.Forms.Button();
            this.lbvnd = new System.Windows.Forms.Label();
            this.lbprint = new System.Windows.Forms.Button();
            this.datainvoicedetails = new System.Windows.Forms.DataGridView();
            this.txtdiscount = new System.Windows.Forms.ComboBox();
            this.txtquantity = new System.Windows.Forms.NumericUpDown();
            this.txtunitprice = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.lbtablename = new System.Windows.Forms.Label();
            this.txttablename = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lbdelete = new System.Windows.Forms.Button();
            this.lbupdate = new System.Windows.Forms.Button();
            this.lbquantity = new System.Windows.Forms.Label();
            this.lbadd = new System.Windows.Forms.Button();
            this.lbtotalprice = new System.Windows.Forms.Label();
            this.lbdiscount = new System.Windows.Forms.Label();
            this.lbunitprice = new System.Windows.Forms.Label();
            this.laproductname = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.grblistoftable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatable)).BeginInit();
            this.grblistofproduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataproduct)).BeginInit();
            this.grblistofinvoicedetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datainvoicedetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).BeginInit();
            this.SuspendLayout();
            // 
            // grblistoftable
            // 
            this.grblistoftable.Controls.Add(this.btupdatetable);
            this.grblistoftable.Controls.Add(this.btsearchtable);
            this.grblistoftable.Controls.Add(this.txtfindtable);
            this.grblistoftable.Controls.Add(this.lbfindtable);
            this.grblistoftable.Controls.Add(this.btresettable);
            this.grblistoftable.Controls.Add(this.datatable);
            this.grblistoftable.Dock = System.Windows.Forms.DockStyle.Left;
            this.grblistoftable.Location = new System.Drawing.Point(0, 0);
            this.grblistoftable.Name = "grblistoftable";
            this.grblistoftable.Size = new System.Drawing.Size(350, 653);
            this.grblistoftable.TabIndex = 7;
            this.grblistoftable.TabStop = false;
            this.grblistoftable.Text = "List Of Table";
            // 
            // btupdatetable
            // 
            this.btupdatetable.Location = new System.Drawing.Point(250, 72);
            this.btupdatetable.Name = "btupdatetable";
            this.btupdatetable.Size = new System.Drawing.Size(75, 23);
            this.btupdatetable.TabIndex = 32;
            this.btupdatetable.Text = "Update";
            this.btupdatetable.UseVisualStyleBackColor = true;
            this.btupdatetable.Click += new System.EventHandler(this.btupdatetable_Click);
            // 
            // btsearchtable
            // 
            this.btsearchtable.Location = new System.Drawing.Point(75, 72);
            this.btsearchtable.Name = "btsearchtable";
            this.btsearchtable.Size = new System.Drawing.Size(75, 23);
            this.btsearchtable.TabIndex = 31;
            this.btsearchtable.Text = "Search";
            this.btsearchtable.UseVisualStyleBackColor = true;
            this.btsearchtable.Click += new System.EventHandler(this.btsearchtable_Click);
            // 
            // txtfindtable
            // 
            this.txtfindtable.Location = new System.Drawing.Point(75, 44);
            this.txtfindtable.Name = "txtfindtable";
            this.txtfindtable.Size = new System.Drawing.Size(250, 22);
            this.txtfindtable.TabIndex = 30;
            // 
            // lbfindtable
            // 
            this.lbfindtable.AutoSize = true;
            this.lbfindtable.Location = new System.Drawing.Point(12, 50);
            this.lbfindtable.Name = "lbfindtable";
            this.lbfindtable.Size = new System.Drawing.Size(36, 16);
            this.lbfindtable.TabIndex = 29;
            this.lbfindtable.Text = "Find:";
            // 
            // btresettable
            // 
            this.btresettable.Location = new System.Drawing.Point(156, 72);
            this.btresettable.Name = "btresettable";
            this.btresettable.Size = new System.Drawing.Size(75, 23);
            this.btresettable.TabIndex = 28;
            this.btresettable.Text = "Reset";
            this.btresettable.UseVisualStyleBackColor = true;
            this.btresettable.Click += new System.EventHandler(this.btresettable_Click);
            // 
            // datatable
            // 
            this.datatable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datatable.Location = new System.Drawing.Point(3, 100);
            this.datatable.Name = "datatable";
            this.datatable.RowHeadersWidth = 51;
            this.datatable.RowTemplate.Height = 24;
            this.datatable.Size = new System.Drawing.Size(344, 550);
            this.datatable.TabIndex = 23;
            this.datatable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datatable_CellContentClick);
            // 
            // grblistofproduct
            // 
            this.grblistofproduct.Controls.Add(this.btresetproduct);
            this.grblistofproduct.Controls.Add(this.btsearchproduct);
            this.grblistofproduct.Controls.Add(this.txtfindproduct);
            this.grblistofproduct.Controls.Add(this.lbfindproduct);
            this.grblistofproduct.Controls.Add(this.dataproduct);
            this.grblistofproduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.grblistofproduct.Location = new System.Drawing.Point(932, 0);
            this.grblistofproduct.Name = "grblistofproduct";
            this.grblistofproduct.Size = new System.Drawing.Size(350, 653);
            this.grblistofproduct.TabIndex = 8;
            this.grblistofproduct.TabStop = false;
            this.grblistofproduct.Text = "List Of Product";
            // 
            // btresetproduct
            // 
            this.btresetproduct.Location = new System.Drawing.Point(250, 72);
            this.btresetproduct.Name = "btresetproduct";
            this.btresetproduct.Size = new System.Drawing.Size(75, 23);
            this.btresetproduct.TabIndex = 16;
            this.btresetproduct.Text = "Reset";
            this.btresetproduct.UseVisualStyleBackColor = true;
            this.btresetproduct.Click += new System.EventHandler(this.btresetproduct_Click);
            // 
            // btsearchproduct
            // 
            this.btsearchproduct.Location = new System.Drawing.Point(75, 72);
            this.btsearchproduct.Name = "btsearchproduct";
            this.btsearchproduct.Size = new System.Drawing.Size(75, 23);
            this.btsearchproduct.TabIndex = 15;
            this.btsearchproduct.Text = "Search";
            this.btsearchproduct.UseVisualStyleBackColor = true;
            this.btsearchproduct.Click += new System.EventHandler(this.btsearchproduct_Click);
            // 
            // txtfindproduct
            // 
            this.txtfindproduct.Location = new System.Drawing.Point(75, 44);
            this.txtfindproduct.Name = "txtfindproduct";
            this.txtfindproduct.Size = new System.Drawing.Size(250, 22);
            this.txtfindproduct.TabIndex = 14;
            // 
            // lbfindproduct
            // 
            this.lbfindproduct.AutoSize = true;
            this.lbfindproduct.Location = new System.Drawing.Point(12, 50);
            this.lbfindproduct.Name = "lbfindproduct";
            this.lbfindproduct.Size = new System.Drawing.Size(36, 16);
            this.lbfindproduct.TabIndex = 9;
            this.lbfindproduct.Text = "Find:";
            // 
            // dataproduct
            // 
            this.dataproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataproduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataproduct.Location = new System.Drawing.Point(3, 100);
            this.dataproduct.Name = "dataproduct";
            this.dataproduct.RowHeadersWidth = 51;
            this.dataproduct.RowTemplate.Height = 24;
            this.dataproduct.Size = new System.Drawing.Size(344, 550);
            this.dataproduct.TabIndex = 0;
            this.dataproduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataproduct_CellContentClick);
            // 
            // grblistofinvoicedetails
            // 
            this.grblistofinvoicedetails.Controls.Add(this.btrefresh);
            this.grblistofinvoicedetails.Controls.Add(this.btreset);
            this.grblistofinvoicedetails.Controls.Add(this.txtdatefounded);
            this.grblistofinvoicedetails.Controls.Add(this.lbvndtp);
            this.grblistofinvoicedetails.Controls.Add(this.txttotalprice);
            this.grblistofinvoicedetails.Controls.Add(this.lbdatefounded);
            this.grblistofinvoicedetails.Controls.Add(this.btpay);
            this.grblistofinvoicedetails.Controls.Add(this.lbvnd);
            this.grblistofinvoicedetails.Controls.Add(this.lbprint);
            this.grblistofinvoicedetails.Controls.Add(this.datainvoicedetails);
            this.grblistofinvoicedetails.Controls.Add(this.txtdiscount);
            this.grblistofinvoicedetails.Controls.Add(this.txtquantity);
            this.grblistofinvoicedetails.Controls.Add(this.txtunitprice);
            this.grblistofinvoicedetails.Controls.Add(this.txtproductname);
            this.grblistofinvoicedetails.Controls.Add(this.lbtablename);
            this.grblistofinvoicedetails.Controls.Add(this.txttablename);
            this.grblistofinvoicedetails.Controls.Add(this.txtid);
            this.grblistofinvoicedetails.Controls.Add(this.lbdelete);
            this.grblistofinvoicedetails.Controls.Add(this.lbupdate);
            this.grblistofinvoicedetails.Controls.Add(this.lbquantity);
            this.grblistofinvoicedetails.Controls.Add(this.lbadd);
            this.grblistofinvoicedetails.Controls.Add(this.lbtotalprice);
            this.grblistofinvoicedetails.Controls.Add(this.lbdiscount);
            this.grblistofinvoicedetails.Controls.Add(this.lbunitprice);
            this.grblistofinvoicedetails.Controls.Add(this.laproductname);
            this.grblistofinvoicedetails.Controls.Add(this.lbid);
            this.grblistofinvoicedetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grblistofinvoicedetails.Location = new System.Drawing.Point(350, 0);
            this.grblistofinvoicedetails.Name = "grblistofinvoicedetails";
            this.grblistofinvoicedetails.Size = new System.Drawing.Size(582, 653);
            this.grblistofinvoicedetails.TabIndex = 9;
            this.grblistofinvoicedetails.TabStop = false;
            this.grblistofinvoicedetails.Text = "List Of Invoice Details";
            // 
            // btrefresh
            // 
            this.btrefresh.Location = new System.Drawing.Point(339, 255);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(75, 23);
            this.btrefresh.TabIndex = 60;
            this.btrefresh.Text = "Refresh";
            this.btrefresh.UseVisualStyleBackColor = true;
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(258, 255);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(75, 23);
            this.btreset.TabIndex = 59;
            this.btreset.Text = "Reset";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // txtdatefounded
            // 
            this.txtdatefounded.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdatefounded.Location = new System.Drawing.Point(400, 193);
            this.txtdatefounded.Name = "txtdatefounded";
            this.txtdatefounded.Size = new System.Drawing.Size(125, 22);
            this.txtdatefounded.TabIndex = 57;
            // 
            // lbvndtp
            // 
            this.lbvndtp.AutoSize = true;
            this.lbvndtp.Location = new System.Drawing.Point(230, 200);
            this.lbvndtp.Name = "lbvndtp";
            this.lbvndtp.Size = new System.Drawing.Size(36, 16);
            this.lbvndtp.TabIndex = 56;
            this.lbvndtp.Text = "VND";
            // 
            // txttotalprice
            // 
            this.txttotalprice.Location = new System.Drawing.Point(125, 194);
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.Size = new System.Drawing.Size(100, 22);
            this.txttotalprice.TabIndex = 55;
            // 
            // lbdatefounded
            // 
            this.lbdatefounded.AutoSize = true;
            this.lbdatefounded.Location = new System.Drawing.Point(300, 200);
            this.lbdatefounded.Name = "lbdatefounded";
            this.lbdatefounded.Size = new System.Drawing.Size(96, 16);
            this.lbdatefounded.TabIndex = 54;
            this.lbdatefounded.Text = "Date Founded:";
            // 
            // btpay
            // 
            this.btpay.Location = new System.Drawing.Point(420, 254);
            this.btpay.Name = "btpay";
            this.btpay.Size = new System.Drawing.Size(75, 23);
            this.btpay.TabIndex = 53;
            this.btpay.Text = "Pay";
            this.btpay.UseVisualStyleBackColor = true;
            this.btpay.Click += new System.EventHandler(this.btpay_Click);
            // 
            // lbvnd
            // 
            this.lbvnd.AutoSize = true;
            this.lbvnd.Location = new System.Drawing.Point(230, 150);
            this.lbvnd.Name = "lbvnd";
            this.lbvnd.Size = new System.Drawing.Size(36, 16);
            this.lbvnd.TabIndex = 52;
            this.lbvnd.Text = "VND";
            // 
            // lbprint
            // 
            this.lbprint.Location = new System.Drawing.Point(501, 254);
            this.lbprint.Name = "lbprint";
            this.lbprint.Size = new System.Drawing.Size(75, 23);
            this.lbprint.TabIndex = 51;
            this.lbprint.Text = "Print";
            this.lbprint.UseVisualStyleBackColor = true;
            this.lbprint.Click += new System.EventHandler(this.lbprint_Click);
            // 
            // datainvoicedetails
            // 
            this.datainvoicedetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datainvoicedetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datainvoicedetails.Location = new System.Drawing.Point(3, 300);
            this.datainvoicedetails.Name = "datainvoicedetails";
            this.datainvoicedetails.RowHeadersWidth = 51;
            this.datainvoicedetails.RowTemplate.Height = 24;
            this.datainvoicedetails.Size = new System.Drawing.Size(576, 350);
            this.datainvoicedetails.TabIndex = 50;
            this.datainvoicedetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datainvoicedetails_CellContentClick);
            // 
            // txtdiscount
            // 
            this.txtdiscount.FormattingEnabled = true;
            this.txtdiscount.Items.AddRange(new object[] {
            "2%",
            "3%",
            "5%",
            "10%",
            "20%",
            "50%"});
            this.txtdiscount.Location = new System.Drawing.Point(400, 142);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(126, 24);
            this.txtdiscount.TabIndex = 49;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(400, 94);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(125, 22);
            this.txtquantity.TabIndex = 48;
            // 
            // txtunitprice
            // 
            this.txtunitprice.Location = new System.Drawing.Point(125, 144);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.Size = new System.Drawing.Size(100, 22);
            this.txtunitprice.TabIndex = 47;
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(125, 94);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(150, 22);
            this.txtproductname.TabIndex = 46;
            // 
            // lbtablename
            // 
            this.lbtablename.AutoSize = true;
            this.lbtablename.Location = new System.Drawing.Point(300, 50);
            this.lbtablename.Name = "lbtablename";
            this.lbtablename.Size = new System.Drawing.Size(83, 16);
            this.lbtablename.TabIndex = 45;
            this.lbtablename.Text = "Table name:";
            // 
            // txttablename
            // 
            this.txttablename.Location = new System.Drawing.Point(400, 44);
            this.txttablename.Name = "txttablename";
            this.txttablename.Size = new System.Drawing.Size(125, 22);
            this.txttablename.TabIndex = 44;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(125, 44);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 43;
            // 
            // lbdelete
            // 
            this.lbdelete.Location = new System.Drawing.Point(177, 255);
            this.lbdelete.Name = "lbdelete";
            this.lbdelete.Size = new System.Drawing.Size(75, 23);
            this.lbdelete.TabIndex = 42;
            this.lbdelete.Text = "Delete";
            this.lbdelete.UseVisualStyleBackColor = true;
            this.lbdelete.Click += new System.EventHandler(this.lbdelete_Click);
            // 
            // lbupdate
            // 
            this.lbupdate.Location = new System.Drawing.Point(96, 254);
            this.lbupdate.Name = "lbupdate";
            this.lbupdate.Size = new System.Drawing.Size(75, 23);
            this.lbupdate.TabIndex = 41;
            this.lbupdate.Text = "Update";
            this.lbupdate.UseVisualStyleBackColor = true;
            this.lbupdate.Click += new System.EventHandler(this.lbupdate_Click);
            // 
            // lbquantity
            // 
            this.lbquantity.AutoSize = true;
            this.lbquantity.Location = new System.Drawing.Point(300, 100);
            this.lbquantity.Name = "lbquantity";
            this.lbquantity.Size = new System.Drawing.Size(58, 16);
            this.lbquantity.TabIndex = 40;
            this.lbquantity.Text = "Quantity:";
            // 
            // lbadd
            // 
            this.lbadd.Location = new System.Drawing.Point(15, 255);
            this.lbadd.Name = "lbadd";
            this.lbadd.Size = new System.Drawing.Size(75, 23);
            this.lbadd.TabIndex = 39;
            this.lbadd.Text = "Add";
            this.lbadd.UseVisualStyleBackColor = true;
            this.lbadd.Click += new System.EventHandler(this.lbadd_Click);
            // 
            // lbtotalprice
            // 
            this.lbtotalprice.AutoSize = true;
            this.lbtotalprice.Location = new System.Drawing.Point(12, 200);
            this.lbtotalprice.Name = "lbtotalprice";
            this.lbtotalprice.Size = new System.Drawing.Size(74, 16);
            this.lbtotalprice.TabIndex = 38;
            this.lbtotalprice.Text = "Total price:";
            // 
            // lbdiscount
            // 
            this.lbdiscount.AutoSize = true;
            this.lbdiscount.Location = new System.Drawing.Point(300, 150);
            this.lbdiscount.Name = "lbdiscount";
            this.lbdiscount.Size = new System.Drawing.Size(62, 16);
            this.lbdiscount.TabIndex = 37;
            this.lbdiscount.Text = "Discount:";
            // 
            // lbunitprice
            // 
            this.lbunitprice.AutoSize = true;
            this.lbunitprice.Location = new System.Drawing.Point(12, 150);
            this.lbunitprice.Name = "lbunitprice";
            this.lbunitprice.Size = new System.Drawing.Size(66, 16);
            this.lbunitprice.TabIndex = 36;
            this.lbunitprice.Text = "Unit price:";
            // 
            // laproductname
            // 
            this.laproductname.AutoSize = true;
            this.laproductname.Location = new System.Drawing.Point(12, 100);
            this.laproductname.Name = "laproductname";
            this.laproductname.Size = new System.Drawing.Size(103, 16);
            this.laproductname.TabIndex = 35;
            this.laproductname.Text = "Product\'s name:";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(12, 50);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(23, 16);
            this.lbid.TabIndex = 34;
            this.lbid.Text = "ID:";
            // 
            // SalesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.grblistofinvoicedetails);
            this.Controls.Add(this.grblistofproduct);
            this.Controls.Add(this.grblistoftable);
            this.Name = "SalesPage";
            this.Text = "SalesPage";
            this.Load += new System.EventHandler(this.SalesPage_Load);
            this.grblistoftable.ResumeLayout(false);
            this.grblistoftable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatable)).EndInit();
            this.grblistofproduct.ResumeLayout(false);
            this.grblistofproduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataproduct)).EndInit();
            this.grblistofinvoicedetails.ResumeLayout(false);
            this.grblistofinvoicedetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datainvoicedetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grblistoftable;
        private System.Windows.Forms.GroupBox grblistofproduct;
        private System.Windows.Forms.Button btresetproduct;
        private System.Windows.Forms.Button btsearchproduct;
        private System.Windows.Forms.TextBox txtfindproduct;
        private System.Windows.Forms.Label lbfindproduct;
        private System.Windows.Forms.DataGridView dataproduct;
        private System.Windows.Forms.GroupBox grblistofinvoicedetails;
        private System.Windows.Forms.Button btresettable;
        private System.Windows.Forms.DataGridView datatable;
        private System.Windows.Forms.DataGridView datainvoicedetails;
        private System.Windows.Forms.ComboBox txtdiscount;
        private System.Windows.Forms.NumericUpDown txtquantity;
        private System.Windows.Forms.TextBox txtunitprice;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Label lbtablename;
        private System.Windows.Forms.TextBox txttablename;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button lbdelete;
        private System.Windows.Forms.Button lbupdate;
        private System.Windows.Forms.Label lbquantity;
        private System.Windows.Forms.Button lbadd;
        private System.Windows.Forms.Label lbtotalprice;
        private System.Windows.Forms.Label lbdiscount;
        private System.Windows.Forms.Label lbunitprice;
        private System.Windows.Forms.Label laproductname;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Button btupdatetable;
        private System.Windows.Forms.Button btsearchtable;
        private System.Windows.Forms.TextBox txtfindtable;
        private System.Windows.Forms.Label lbfindtable;
        private System.Windows.Forms.Button lbprint;
        private System.Windows.Forms.Label lbvnd;
        private System.Windows.Forms.Button btpay;
        private System.Windows.Forms.Label lbdatefounded;
        private System.Windows.Forms.Label lbvndtp;
        private System.Windows.Forms.TextBox txttotalprice;
        private System.Windows.Forms.DateTimePicker txtdatefounded;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btrefresh;
    }
}